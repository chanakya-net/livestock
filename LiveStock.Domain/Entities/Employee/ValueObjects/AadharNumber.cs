namespace LiveStock.Domain.Entities.Employee.ValueObjects;

public record AadharNumber
{
    public AadharNumber(string aadharNumber)
    {
        // TODO: Domain validation for aadhar number
        if(aadharNumber.Length != 12)
        {
            throw new ArgumentException("Aadhar number should be 12 digits long");
        }
        UserAadharNumber = aadharNumber;
    }
    public string UserAadharNumber { get; init; }
}