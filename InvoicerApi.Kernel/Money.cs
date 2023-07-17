namespace InvoicerApi.Kernel;

public record Money
{
    public Money(decimal amount, Currency currency)
    {
        VerifyMonetaryValue(amount);
        Currency = currency;
    }

    private decimal Amount { get; set; }

    public Currency Currency { get; init; }
    
    private void VerifyMonetaryValue(decimal amount)
    {
        if (Amount == decimal.MaxValue)
            throw new ArgumentException("The amount you gave is too large.");
        Amount = amount;
    }
}