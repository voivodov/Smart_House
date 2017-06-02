using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartHouse.Web.Models
{
    public class ArduinoDataModelPost
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Indoor Celsius")]
        public double @in { get; set; }

        [DisplayName("Outdoor Celsius")]
        public double @out { get; set; }

        [DisplayName("Humidity Procent")]
        public double @hum { get; set; }


        [DisplayName("Date Send")]
        public string time { get; set; }


        [DisplayName("Room 1")]
        public string room1 { get; set; }
    }
}