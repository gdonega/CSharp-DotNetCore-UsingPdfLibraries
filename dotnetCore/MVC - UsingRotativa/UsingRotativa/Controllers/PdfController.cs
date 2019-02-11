using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Rotativa.AspNetCore;

namespace UsingRotativa.Controllers
{
    /// <summary>
    /// This Controller has a method to gerate a pdf from a Razor page
    /// </summary>
    public class PdfController : Controller
    {
        /// <summary>
        /// This method generate a pdf from a Razor page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //Generate the pdf by the Razor page -> Views/Pdf/Pdf.cshtml
            //return new ViewAsPdf("Pdf");


            var a = this.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;

            var b = a.GetView(null, "~/Views/Pdf/Pdf.cshtml", false);

            //var j = new View;

            //j.ViewData = b.View;

            View();

            return null;
        }
    }
}