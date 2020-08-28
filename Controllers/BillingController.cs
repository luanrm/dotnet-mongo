using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_mongo.Models;
using dotnet_mongo.Services;

namespace dotnet_mongo.Controllers
{
    [ApiController]
    [Route("/billing")]
    public class BillingController : ControllerBase
    {
        private readonly BillingService _billingService;

        public BillingController(BillingService billingService)
        {
            _billingService = billingService;
        }

        [HttpGet]
        public ActionResult<List<Billing>> Get() =>
            _billingService.Get();
    }
}
