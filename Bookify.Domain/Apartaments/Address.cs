namespace Bookify.Domain.Entities;

public record Address(
    string Country,
    string State,
    string ZiipCode,
    string City,
    string Street);
