using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
            // Error
            return new Dictionary<int, object> {
                [1] = 100,
                [2] = new {
                    B1 = 100,
                    B2 = 100
                }
            };
        }

        [HttpGet]
        public object Jobj() {
            var j = new JObject();
            j.Add("a", 100);
            j.Add("b", 200);

            var jj = j.ToObject<Dictionary<string, object>>();

            return new {
                A = 100,
                J = jj
            };
        }

        [HttpGet]
        public object Dict() {
            // Error

            var j = new JObject();
            j.Add("a", 100);
            j.Add("b", 200);

            return new {
                A = 100,
                J = j
            };
        }
    }
}