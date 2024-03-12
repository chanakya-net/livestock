using Ardalis.SmartEnum;

namespace LiveStock.Domain.Common.Enums;

public class EmployeeType(string name, int value) : SmartEnum<EmployeeType>(name, value)
{
    public static readonly EmployeeType Helper = new("Helper", 0);
    public static readonly EmployeeType Incharge = new("Incharge", 1);
    public static readonly EmployeeType Doctor = new("Doctor", 2);
    public static readonly EmployeeType Manager = new("Manager", 3);
}