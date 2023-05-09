namespace test_task_from_alif.Models
{
	public class PurchaseTransaction
	{
		public Guid TransactionID { get; set; }
		public string PhoneNumber { get; set; }
		public string ProductName { get; set; }
		public int InstallmentRange { get; set; }
		public decimal ProductCost { get; set; }
	}
}
