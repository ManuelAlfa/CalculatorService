using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorApiService.Controllers
{
    public class CalculatorController : ApiController
    {

        [HttpGet]
        public int Add(int Termino1, int Termino2)
        {
            return Termino1 + Termino2;
        }

        [HttpGet]
        public int Substract(int Termino1, int Termino2)
        {
            return Termino1 - Termino2;
        }

        [HttpGet]
        public int Multiply(int Termino1, int Termino2)
        {
            return Termino1 * Termino2;
        }

        [HttpGet]
        public string Divide(int Termino1, int Termino2)
        {
          
            return Convert.ToString(Termino1 / Termino2);

        }

        [HttpGet]
        public string Get()
        {
            return "default";
        }


        [HttpGet]
        public string SquareRoot(double Termino)
        {
           return Convert.ToString( Math.Sqrt(Termino));
         
        }
    }
}
