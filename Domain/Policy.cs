namespace PolicyLab.Domain;

public abstract class Policy
{
    private readonly List<Claim> _claims = new();

    public string Number { get; }
    public string HolderName { get; }
    public bool IsCancelled { get; private set; }
    public IReadOnlyList<Claim> Claims => _claims;

    protected Policy(string number, string holderName)
    {
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Policy number is required.", nameof(number));

        Number = number;
        HolderName = holderName;
    }

    public void AddClaim(Claim claim)
    {
        if (IsCancelled)
            throw new InvalidOperationException("Cannot add a claim to a cancelled policy.");

        _claims.Add(claim);
    }

    public void Cancel()
    {
        IsCancelled = true;
    }

    public abstract decimal CalculatePremium();

    public override string ToString()
    {
        return $"{Number} | {HolderName} | Premium: R{CalculatePremium():N2}";
    }
}