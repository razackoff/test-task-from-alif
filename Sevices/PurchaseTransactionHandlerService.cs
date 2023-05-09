using test_task_from_alif.Models;

namespace test_task_from_alif.Sevices
{
	public class PurchaseTransactionHandlerService
	{
		private PurchaseTransaction purchaseTransaction { get; set; }
        public PurchaseTransactionHandlerService(PurchaseTransaction purchaseTransaction)
        {
            this.purchaseTransaction = purchaseTransaction;
        }
        public decimal getSum()
		{
			var sum = purchaseTransaction.ProductCost;
			var installmentRange = getInstallmentPercentage();
			sum += sum / 100 * installmentRange;
			return sum;
		}

		private decimal getInstallmentPercentage() 
		{ 
			if(purchaseTransaction.ProductCategory == "Smartphone")
			{
				if(purchaseTransaction.InstallmentRange == 12)
				{
					return 3;
				}
				else if(purchaseTransaction.InstallmentRange == 18)
				{
					return 6;
				}
				else if(purchaseTransaction.InstallmentRange == 24)
				{
					return 9;
				}
				return 0;
			}
			else if(purchaseTransaction.ProductCategory == "Computer")
			{
				if (purchaseTransaction.InstallmentRange == 18)
				{
					return 4;
				}
				else if(purchaseTransaction.InstallmentRange == 24)
				{
					return 8;
				}
				return 0;
			}
			else if(purchaseTransaction.ProductCategory == "TV")
			{
				if (purchaseTransaction.InstallmentRange == 24)
				{
					return 5;
				}
				return 5;
			}
			return 0;
		}
	}
}
