using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews;

public static class ReviewErrors
{
    public static readonly Error NotEligible = new(
        "Revisão.NãoEligível",
        "A avaliação não é elegível porque a reserva ainda não foi concluída");
}