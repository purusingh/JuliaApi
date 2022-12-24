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
    public class PersonController : ApiController
    {
        // GET: Person
        public IHttpActionResult Get()
        {
            return Ok(Person.GetPersons());
           
        }

        public IHttpActionResult Get(int id)
        {
            return  Ok(Person.GetPersons(id));
            
        }

        public IHttpActionResult Post(MPerson person)
        {
            return Ok(Person.PostPersons(person));

        }
        public IHttpActionResult put(int id, MPerson person)
        {
            Person.PutPerson(id, person);
            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult Delete(int id)
        {
            Person.DeletePerson(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}