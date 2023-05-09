namespace test_task_from_alif.Sevices
{
	public static class SendMessageService
	{
		public static void SendMessage(string phoneNumber, string sms)
		{
			Console.WriteLine(phoneNumber);
			Console.Write(sms);
		}
	}
}
