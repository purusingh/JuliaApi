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
    public class PersonController : BaseApiController
    {
        // GET: Person
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Person.GetPersons());
            }catch(Exception ex)
            {
                logger.Error(ex.Message);
            }

            return null;
           
        }

        [Authorize]
        public IHttpActionResult Get(int id)
        {
            var u = User;
            try
            {
                logger.InfoFormat("trying to get id for {0}", id);
                return Ok(Person.GetPersons(id));
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            return null;

            
            
        }

        [Authorize(Roles = "admin")]
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