using System.Diagnostics;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace jamstack.Controllers
{
    public class NewsletterController : Controller
    {
        [HttpPost, Route("newsletter")]
        public ActionResult Post([FromBody] SignUpRequest request)
        {
            Trace.TraceInformation(request.Email);
            return Ok();
        }
    }

    public class SignUpRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}