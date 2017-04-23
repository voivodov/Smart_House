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
        public double indoorCelsius { get; set; }

        [DisplayName("Outdoor Celsius")]
        public double outdoorCelsius { get; set; }

        [DisplayName("Humidity Procent")]
        public double humidityProcent { get; set; }

        [DisplayName("Relay 1")]
        public string relay1 { get; set; }

        [DisplayName("Relay 2")]
        public string relay2 { get; set; }

        [DisplayName("Relay 3")]
        public string relay3 { get; set; }

        [DisplayName("Relay 4")]
        public string relay4 { get; set; }

        [DisplayName("Date Send")]
        public string dateSend { get; set; }

    }
}