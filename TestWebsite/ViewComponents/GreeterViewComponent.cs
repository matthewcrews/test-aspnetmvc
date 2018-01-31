using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebsite.Services;

namespace TestWebsite.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;

        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfDay();
            return View("Default", model);
        }
    }
}
