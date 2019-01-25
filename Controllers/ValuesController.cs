using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WindowsAuthentication.Models;
using System.Web.Http.Cors;

namespace WindowsAuthentication.Controllers
{
  
  // [Authorize(Roles = "LOGISTICS\\UKothiralla")]
    [Route("api/[controller]")]
    [EnableCors(origins: "http://localhost:4256", headers: "*", methods: "*", SupportsCredentials = true)]
    public class ValuesController : Controller
    {
        WindowsIdentity objWindowsIdentity = new WindowsIdentity();
        // GET api/values
        [HttpGet]
        
        public IActionResult Get()
        {
            //objWindowsIdentity.Authenticated = User.Identity.Name;
            //objWindowsIdentity.AuthenticationType = User.Identity.AuthenticationType;
            //objWindowsIdentity.IsAuthenticated = User.Identity.IsAuthenticated;
            //return objWindowsIdentity;
            bool authenticated = false;
            if (!User.Identity.IsAuthenticated)
            {
                return BadRequest(authenticated);
            }
            authenticated = true;
            return new OkObjectResult(authenticated);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }
    }
}
