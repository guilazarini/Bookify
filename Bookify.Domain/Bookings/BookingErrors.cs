using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    public static Error NotFound = new(
        "Reserva.Encontrada",
        "A reserva com o identificador especificado não foi encontrada");

    public static Error Overlap = new(
        "Reserva.Sobreposição",
        "A reserva atual está sobreposta a uma existente");

    public static Error NotReserved = new(
        "Reserva.NãoReservada",
        "A reserva não está pendente");

    public static Error NotConfirmed = new(
        "Reserva.NãoReservada",
        "A reserva não está confirmada");

    public static Error AlreadyStarted = new(
        "Reserva.JáIniciada",
        "A reserva já começou");
}