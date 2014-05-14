
using BusinessService;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonWebApi.Controllers
{
    public class ShowApiController : ApiController
    {

        private readonly IFilterService filterService;


        public ShowApiController(IFilterService filterService)
        {
            this.filterService = filterService;
        }


        public string Get()
        {
            return "Please use 'POST' method to retrieve data!";
        }

        public HttpResponseMessage Post([FromBody]Request request)
        {
            if (request != null && ModelState.IsValid)
            {
                return Request.CreateResponse<Response>(HttpStatusCode.OK, new Response { response = this.filterService.FilterShows(request) });
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, new Error { error = "Could not decode request: JSON parsing failed" });
            
        }

       
    }
}