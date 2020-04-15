using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {
        [HttpGet]
        public Dictionary<string, object> Object() {
            return new Dictionary<string, object> {
                ["A"] = 100,
                ["B"] = "Ok"
            };
        }

        [HttpGet]
        public Dictionary<string, object> Annonymous() {
            return new Dictionary<string, object> {
                ["A"] = 100,
                ["B"] = new {
                    B1 = 100,
                    B2 = 100
                }
            };
        }

        [HttpGet]
        public Dictionary<int, object> Int() {
            return new Dictionary<int, object> {
                [1] = 100,
                [2] = new {
                    B1 = 100,
                    B2 = 100
                }
            };
        }
    }
}