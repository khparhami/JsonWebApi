using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessService;
using NSubstitute;
using Domain.Models;
using JsonWebApi.Controllers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Net.Http;
using System.Net;
using JsonWebApi;

namespace JsonWebApiTests
{
    [TestClass]
    public class ShowApiControllerTest
    {
        private IFilterService filterService;

        [TestInitialize]
        public void Setup()
        {
            this.filterService = Substitute.For<IFilterService>();
            filterService.FilterShows(Arg.Any<Request>()).Returns(new[] { new Show() });
        }


        [TestMethod]
        public void Post_AlwaysReturns_HttpResponseMessage()
        {
            //Arrange
            var target = GetController();
            var request = GetRequest();

            //Action
            var actual = target.Post(request);
            
            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(HttpResponseMessage));

        }


        [TestMethod]
        public void Post_ReturnsStatusCodeOK_WhenRequestIsValid()
        {
            //Arrange
            var target = GetController();
            var request = GetRequest();

            //Action
            var actual = target.Post(request);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.StatusCode, HttpStatusCode.OK);

        }


        [TestMethod]
        public void Post_ReturnsStatusCodeBadRequest_WhenModelStateIsInvalid()
        {
            //Arrange
            var target = GetController();
            target.ModelState.AddModelError("Any Key", "Any Error");
            var request = GetRequest();

            //Action
            var actual = target.Post(request);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.StatusCode, HttpStatusCode.BadRequest);

        }

        [TestMethod]
        public void Post_ReturnsStatusCodeBadRequest_WhenRequestIsNull()
        {
            //Arrange
            var target = GetController();
            Request request = null;

            //Action
            var actual = target.Post(request);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.StatusCode, HttpStatusCode.BadRequest);

        }


        [TestMethod]
        public void Post_ReturnsCorrectErrorMessage_WhenBadRequestSent()
        {
            //Arrange
            var target = GetController();
            Request request = null;

            //Action
            var response = target.Post(request);
            var error = (ObjectContent<Error>)response.Content;
            var actual = ((Error)error.Value).error;

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual, Constants.ErrorMessage);

        }

        [TestMethod]
        public void Post_FilterShowsWillBeCalledOnce_WhenRequestIsValid()
        {
            //Arrange
            var target = GetController();
            var request = GetRequest();

            //Action
            var actual = target.Post(request);


            //Assert
            this.filterService.Received(1).FilterShows(request);

        }



        private ShowApiController GetController()
        {
            var controller = new ShowApiController(this.filterService);
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            return controller;
        }

        private Request GetRequest()
        {
            var request = new Request
            {
                payload = new[] { new Payload
            {
                country = "UK",
                description = "What's life like when you have enough children to field your own football team?",
                drm = true,
                episodeCount = 3,
                image = new Image
                {
                    showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/16KidsandCounting1280.jpg"
                },
                language = "English",
                nextEpisode = null,
                primaryColour = "#ff7800",
                seasons = new[] { new Season { slug = "show/16kidsandcounting/season/1" } },
                slug = "show/16kidsandcounting",
                title = "16 Kids and Counting",
                tvChannel = "GEM"
            } }
            };
            return request;
        }
    }
}
