using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartHouse.Web.Models;

namespace SmartHouse.Web.Controllers
{
    public class ArduinoController : ApiController
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        public IHttpActionResult Post(ArduinoDataModelPost model)
        {
            try
            {

                db.ArduinoDataModelPosts.Add(model);
                db.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        public IHttpActionResult Get(ArduinoDataModelPost model)
        {
            try
            {

                db.ArduinoDataModelPosts.Add(model);
                db.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
