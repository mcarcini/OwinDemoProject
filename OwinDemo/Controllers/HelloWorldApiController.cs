﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OwinDemo.Controllers
{
    [RoutePrefix("api")]
    public class HelloWorldApiController: ApiController
    {
        [Route("hello")]
        [HttpGet]
        public IHttpActionResult HelloWorld() {
            return Content(System.Net.HttpStatusCode.OK, "Hello from Web API");
        }
    }
}