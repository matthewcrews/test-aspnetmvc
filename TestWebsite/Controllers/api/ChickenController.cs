using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebsite.Models;

namespace TestWebsite.Controllers.api
{
    [Produces("application/json")]
    [Route("api/Chicken")]
    public class ChickenController : Controller
    {
        private List<Chicken> _chickens = new List<Chicken>
        {
            new Chicken{Name = "Clark", Size = 10},
            new Chicken{Name = "Bill", Size = 12}
        };

        public string Index()
        {
            return "ChickenController";
        }
    }
}