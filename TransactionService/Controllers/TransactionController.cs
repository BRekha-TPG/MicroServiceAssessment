using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TransactionService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
    //    private static readonly string[] Summaries = new[]
    //    {
    //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //};

        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Deposite")]
        public HttpStatusCode Deposite()
        {
            // Deposite
            return HttpStatusCode.OK;
        }

        [HttpPost(Name = "Withdraw")]
        public HttpStatusCode Withdraw()
        {
            // Deposite
            return HttpStatusCode.OK;
        }

        [HttpPost(Name = "Transfer")]
        public HttpStatusCode Transfer()
        {
            // Deposite
            return HttpStatusCode.OK;
        }

        [HttpGet]
        public HttpStatusCode CheckBalance()
        {
            // Deposite
            return HttpStatusCode.OK;
        }

        [HttpGet]
        public HttpStatusCode Transactions()
        {
            // Deposite
            return HttpStatusCode.OK;
        }

        [HttpGet]
        public HttpStatusCode History()
        {
            // Deposite
            return HttpStatusCode.OK;
        }
    }
}