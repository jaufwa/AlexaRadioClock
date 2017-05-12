using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RadioClock.Api.Controllers
{
    [RoutePrefix("api")]
    public class IndexController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            return Index(new { });
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Index(dynamic requestBody)
        {
            var testResponse = new
            {
                outputSpeech = new
                {
                    type = "PlainText",
                    text = "Hey Jonny just to let you know this has totally worked",
                },
                shouldEndSession = true
            };

            return Ok(testResponse);
        }
    }
}