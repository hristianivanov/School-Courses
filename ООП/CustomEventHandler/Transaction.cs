namespace CustomEventHandler
{
    public class Transaction
    {
        public string TransactionType { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }

        public Transaction(string transactionType, decimal amount, DateTime date)
        {
            TransactionType = transactionType;
            Amount = amount;
            Date = date;
        }
    }
}
