using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace jamstack.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost, Route("contact")]
        public ActionResult<ContactRequest> Post([FromBody]ContactRequest request)
        {
            // just echo back
            return Ok(request);
        }
    }

    public class ContactRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}