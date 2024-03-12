using LiveStock.Domain.Common.Base;
using LiveStock.Domain.Common.Enums;
using LiveStock.Domain.Common.ValueObjects;
using LiveStock.Domain.Entities.Employee.ValueObjects;

namespace LiveStock.Domain.Entities.Employee.Entity;

public class Employee(Name employeeName, 
    Address permanentAddress, 
    Address currentAddress, 
    AadharNumber aadharNumber, 
    ContactNumber primaryMobileNumber,
    Name fatherName,
    Name? spouseName,
    ContactNumber? spouseMobileNumber,
    PoliceVerification isPoliceVerificationDone,
    Name referenceName,
    ContactNumber referenceMobileNumber,
    EmployeeType employeeType) : BaseEntity
{
    public Name EmployeeName { get; init; } = employeeName;
    public Name FatherName { get; init; } = fatherName;
    public Name ReferenceName { get; init; } = referenceName;
    public Name? SpouseName { get; init; } = spouseName;
    public Address PermanentAddress { get; init; } = permanentAddress;
    public Address CurrentAddress { get; init; } = currentAddress; 
    public AadharNumber AadharNumber { get; init; } = aadharNumber;
    public ContactNumber PrimaryMobileNumber { get; init; } = primaryMobileNumber;
    public ContactNumber? SpouseMobileNumber { get; init; } = spouseMobileNumber;
    public ContactNumber ReferenceMobileNumber { get; init; } = referenceMobileNumber;
    public PoliceVerification IsPoliceVerificationDone { get; init; } = isPoliceVerificationDone;
    public EmployeeType EmployeeType { get; init; } = employeeType;
}