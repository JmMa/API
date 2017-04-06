using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LN.API2.Models;

namespace LN.API2.Controllers
{
    public class HotelController : ApiController
    {
        Hotel[] tempHotels = new Hotel[]
        {
            new Hotel { Name="酒店01", Address="厦门01" },
            new Hotel { Name="酒店02", Address="厦门02" },
            new Hotel { Name="酒店03", Address="厦门03" }
        };
        [HttpGet]
        public Hotel GetHotels(string Name)
        {
            return tempHotels.FirstOrDefault(m => m.Name == Name);
        }

        [HttpPost]
        public IEnumerable<Hotel> AllHotels()
        {
            return tempHotels;
        }
    }
}
