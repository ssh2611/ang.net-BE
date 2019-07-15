using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        [HttpGet]
        public IEnumerable<Models.Message> Get()
        {
            return new Models.Message[] {
                new Models.Message {
                    Owner = "John",
                    Text = "hello"
                },
                new Models.Message
                {
                    Owner = "Tim",
                    Text = "Hi"
                }
            };
        }
        [HttpPost]
        public void post([FromBody] Models.Message message)
        {
            
        }
    }
}