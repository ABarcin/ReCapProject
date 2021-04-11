using Business.Abstract;
using Entitites.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        IWebHostEnvironment _webHostEnvironment;
        ICreditCardCheckService _creditCardCheckService;

        public CreditCardsController(ICreditCardCheckService creditCardCheckService, IWebHostEnvironment webHostEnvironment)
        {
            _creditCardCheckService = creditCardCheckService;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpPost("check")]
        public bool Check(CreditCard creditCard)
        {
            bool result = _creditCardCheckService.CheckCreditCard(creditCard);
            return result;
        }
    }
}
