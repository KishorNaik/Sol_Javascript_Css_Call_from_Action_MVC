using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Javascript_Css_Manipluation.Models;

namespace Sol_Javascript_Css_Manipluation.Controllers
{
    public class DemoController : Controller
    {

        public DemoController()
        {
            Demo = new DemoModel();
        }

        [BindProperty]
        public DemoModel Demo { get; set; }

        public IActionResult Index()
        {
            Demo.JavascriptFuncCall = "funcCall();";

            int intValue = 11;

            Demo.JavascriptFuncParaCall = $"funcParaCall({intValue});";

            Demo.CssClassCall = "stylegreen";

            return View(Demo);
        }
    }
}