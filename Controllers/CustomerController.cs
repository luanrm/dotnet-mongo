using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_mongo.Models;
using dotnet_mongo.Services;
using Microsoft.AspNetCore.Cors;

namespace dotnet_mongo.Controllers
{
    [ApiController]
    [Route("/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> Get() =>
            _customerService.Get();
    }
}
