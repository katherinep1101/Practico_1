using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practico_1.Controller
{
    public class BaseController
    {
        public Datos datos { get; set; }

        public BaseController()
        {
            datos = new Datos();
        }
    }
}
