using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAttributeRouting.Models;

namespace WebApiAttributeRouting.Controllers
{
    // This is optional: it is just to avoid repeating the first part of the URI
    // for each action method
    [RoutePrefix("api/users")]
    public class MyFancyController : ApiController
    {
        private User[] users = new[]
        {
            new User { Id = 1, Name = "Anders" }
        };

        // If we want the action method to be at precisely the RoutePrefix for the
        // controller, we must use an empty string as Route
        [Route("")]
        [HttpGet]  // <-- This method will only be called for HTTP GET requests
        public IEnumerable<User> FetchMyDamnUsers()
        {
            return users;
        }

        // If we need to extract parameters from request and send into the controller
        // action method, we must use curly brackets {} with name of method parameter inside
        [Route("{id}")]
        [HttpGet]
        public User FetchASpecificUser(int id)
        {
            return users.Where(u => u.Id == id).Single();
        }
    }
}
