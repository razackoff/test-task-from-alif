using test_task_from_alif.Models;

namespace test_task_from_alif.Sevices
{
	public class SendMessageService
	{
		private PurchaseTransaction purchaseTransaction {  get; set; }
		private decimal sum { get; set; }
        public SendMessageService(PurchaseTransaction purchaseTransaction, decimal sum)
        {
            this.purchaseTransaction = purchaseTransaction;
			this.sum = sum;
        }
        public void SendMessage()
		{
			var sms = "Product category: " + purchaseTransaction.ProductCategory + "\n";
			sms += "Product cost: " + purchaseTransaction.ProductCost + "$\n";
			sms += "Product installment range: " + purchaseTransaction.InstallmentRange + "\n";
			sms += "Total: " + sum + "$\n";
			Console.WriteLine(purchaseTransaction.PhoneNumber);
			Console.Write(sms);
		}
	}
}
