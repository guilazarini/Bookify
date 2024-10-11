namespace Bookify.Domain.Shared;

public record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money frist, Money second)
    {
        if (frist.Currency != second.Currency)
        {
            throw new InvalidOperationException("As moedas têm que ser iguais");
        }
        return new Money(frist.Amount + second.Amount, frist.Currency);
    }

    public static Money Zero() => new(0, Currency.None);

    public static Money Zero(Currency currency) => new(0, currency);

    public bool IsZero() => this == Zero(Currency);
}