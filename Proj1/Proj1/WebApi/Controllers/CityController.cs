using ClassLibrary.BLL;
using ClassLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CityController : ApiController
    {

        [HttpGet]
        [Route("api/City/{_Code}")]
        public City GetCity(int _Code)
        {
            ProjDbContext db = new ProjDbContext();

            return db.Cities.SingleOrDefault(x => x.CityCode == _Code);
        }
    }
}