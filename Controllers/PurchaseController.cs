using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_task_from_alif.Models;
using test_task_from_alif.Sevices;

namespace test_task_from_alif.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PurchaseController : ControllerBase
	{	
		[HttpGet("GetPaymentAmount")]
		public IActionResult GetPaymentAmount([FromQuery] PurchaseTransaction transaction)
		{
			PurchaseTransactionHandlerService purchaseTransactionHandlerService = 
				new PurchaseTransactionHandlerService(transaction);

			decimal sum = purchaseTransactionHandlerService.getSum();
			var sender = new SendMessageService(transaction, sum);
			sender.SendMessage();
			return Ok(sum);
		}
	}
}
