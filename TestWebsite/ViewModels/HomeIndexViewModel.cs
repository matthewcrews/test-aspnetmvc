using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebsite.Models;

namespace TestWebsite.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurant { get; set; }
        public string CurrentMessage { get; set; }
    }
}
