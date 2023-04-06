using System.Transactions;

namespace CustomEventHandler;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    public event EventHandler<Transaction> TransactionMade;

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;

        Transaction transaction = new Transaction("Deposit", amount, DateTime.Now);
        OnTransactionMade(transaction);
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient balance.");

        Balance -= amount;

        Transaction transaction = new Transaction("Withdrawal", amount, DateTime.Now);
        OnTransactionMade(transaction);
    }

    protected virtual void OnTransactionMade(Transaction transaction)
    {
        TransactionMade?.Invoke(this, transaction);
    }
}