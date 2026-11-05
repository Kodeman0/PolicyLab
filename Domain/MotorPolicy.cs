namespace PolicyLab.Domain;

public class MotorPolicy : Policy
{
    public decimal VehicleValue { get; }

    public MotorPolicy (string number, string holderName, decimal vehicleValue)
        : base(number, holderName)
    {
        if (vehicleValue <= 0)
            throw new ArgumentException("Vehicle value must be greater than zero ", nameof(vehicleValue));

        VehicleValue = vehicleValue;
    }

    public override decimal CalculatePremium()
    {
        return VehicleValue * 0.05m + Claims.Count * 500m;
    }


}