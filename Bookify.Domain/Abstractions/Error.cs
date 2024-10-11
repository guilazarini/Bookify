namespace Bookify.Domain.Abstractions;

public class Error(string Code, string Name)
{
    public static Error None = new Error(string.Empty, string.Empty);

    public static Error NullValue = new("Error.NullValue", "Null value was provided");
}
