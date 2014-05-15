using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessService;
using Domain.Models;
using BusinessServiceTests.Mocks;

namespace BusinessServiceTests
{
    [TestClass]
    public class FilterServiceTest
    {
        [TestMethod]
        public void FilterShows_Always_ReturnAnArrayOfShows()
        {
            //Arrange
            var target = new FilterService();

            //Action

            var actual = target.FilterShows(ShowsMockHelper.GetMockedRequest());

            //Assert

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual,typeof(Show[]));
        }

        [TestMethod]
        public void FilterShows_Returns_CorrectNumberOfShows()
        {
            //Arrange
            var target = new FilterService();
            var expected = ShowsMockHelper.GetMockedShows().Length;
            //Action

            var actual = target.FilterShows(ShowsMockHelper.GetMockedRequest());

            //Assert

            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.Length, expected);
        }



        [TestMethod]
        public void FilterShows_ReturnsCorrectShows_ForAValidRequest()
        {
            //Arrange
            var target = new FilterService();
            var expected = ShowsMockHelper.GetMockedShows();
            //Action

            var actual = target.FilterShows(ShowsMockHelper.GetMockedRequest());

            //Assert

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FilterShows_ReturnsNull_WhenRequestIsNull()
        {
            //Arrange
            var target = new FilterService();
            
            //Action

            var actual = target.FilterShows(null);

            //Assert

            Assert.IsNull(actual);
           
        }

        [TestMethod]
        public void FilterShows_ReturnsNull_WhenPayloadIsNull()
        {
            //Arrange
            var target = new FilterService();
            var request = new Request();

            //Action

            var actual = target.FilterShows(request);

            //Assert

            Assert.IsNull(actual);

        }
    }


}
