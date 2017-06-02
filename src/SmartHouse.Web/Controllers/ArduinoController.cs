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
        [Route("api/Arduino/{indoorCelsius}" +
               "/{outdoorCelsius}" +
               "/{humidityProcent}" +
               "/{relay1}" +
               "/{relay2}" +
               "/{relay3}" +
               "/{relay4}" +
               "/{dateSend}")]
        public IHttpActionResult Get(
            string indoorCelsius
            , string outdoorCelsius
             , string humidityProcent
             , string relay1
             , string relay2
             , string relay3
             , string relay4
             , string dateSend
            )
        {
            try
            {
                var model = new ArduinoDataModelPost();

                model.@in = Double.Parse(indoorCelsius);
                model.@out = Double.Parse(outdoorCelsius);
                model.hum = Double.Parse(humidityProcent);
       
                model.time = dateSend;

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
