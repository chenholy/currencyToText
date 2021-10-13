using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnLeashPorject.Controllers;

namespace UnLeashedProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private int _num;
        private int _float;
        public class InputText
        {
            public string iInt { get; set; }
            public string iFloat { get; set; }
        }

        [HttpGet]
        public string Get()
        {
            return "HelloWorld";
        }

        [HttpPost]
        public string Post(InputText input)
        {
            try
            {

                _num = Convert.ToInt32(input.iInt);
                _float = input.iFloat.Length >= 2 ? Convert.ToInt32(input.iFloat.Substring(0, 2)) : Convert.ToInt32(input.iFloat);

                var dollarString = _num == 0 ? "" : Helpers.convertDollarString(_num, _num.ToString().Length) + (_num == 1 ? " Dollar" : " Dollars");
                var centString = _float == 0 ? "" : Helpers.convertDollarString(_float, _float.ToString().Length) + (_float == 1 ? " Cent" : " Cents");

                return !String.IsNullOrEmpty(centString) && !String.IsNullOrEmpty(dollarString) ? dollarString + " And " + centString : dollarString + centString;
            }
            catch (OverflowException)
            {
                return "input number out of bound and might cause overflow!";
            }

        }


    }
}
