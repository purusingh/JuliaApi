using log4net;
using MyWebApp.Dals;
using MyWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;


namespace MyWebApp.Controllers
{
    public class PersonTypeController : ApiController
    {
        // GET: Person
        public IHttpActionResult Get()
        {
            return Ok(PersonType.GetPersonTypes());
           
        }
    }
}