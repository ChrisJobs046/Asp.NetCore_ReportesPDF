using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace WebReportesPDF.Controllers
{
    public class CrearPDFController : Controller
    {
        public IActionResult Index()
        {
            //Este metodo se crea, al instalar Rotativa.Asp.NetCore
            return new ViewAsPdf("Index")
            {

            };
        }
    }
}
