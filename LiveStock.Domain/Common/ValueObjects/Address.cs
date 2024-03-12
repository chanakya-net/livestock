namespace LiveStock.Domain.Common.ValueObjects;

public record Address(
    string AddressLine1,
    string? AddressLine2,
    string City,
    string State,
    string Country,
    string PostalCode,
    string LandMark);