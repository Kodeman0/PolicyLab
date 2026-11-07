using PolicyLab.Domain;

var policies = new List<Policy>
{

    new MotorPolicy("MOT-001", "John Smith", 250000m),
    new MotorPolicy("MOT-002", "Priya Pillay", 180000m),
    new HomePolicy("HOM-001", "John Smith", 1500000m),
    new HomePolicy("HOM-002","Thabo Mokoena",900000m)
};


policies[0].AddClaim(new Claim(5000m, "Cracked windscreen"));
policies[0].AddClaim(new Claim(12000m, "Rear bumper"));
policies[2].AddClaim(new Claim(3000m, "Geyser burst"));

foreach (var policy in policies)
{
    Console.WriteLine(policy);
}