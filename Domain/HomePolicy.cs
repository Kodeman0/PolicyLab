namespace PolicyLab.Domain;


public class HomePolicy : Policy
{
    public decimal BuildingValue { get; }

    public HomePolicy(string number, string holderName, decimal buildingValue)
        : base(number, holderName)
    {
        if (buildingValue <= 0)
            throw new ArgumentException("The building value must be more than 0", nameof(buildingValue));

        BuildingValue = buildingValue;
        
    }

    public override decimal CalculatePremium()
    {
        return (BuildingValue * 0.01m) + Claims.Count * 1000;
    }


}