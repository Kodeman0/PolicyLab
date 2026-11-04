namespace PolicyLab.Domain;

public class Claim
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Description { get; }

    public Claim(decimal amount, string description)
    {
        if (amount <= 0)
            throw new ArgumentException("Claim amount must be greater than zero", nameof(amount));

        Amount = amount;
        Description = description;
        Date = DateTime.Today;

    }
}