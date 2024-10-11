using Bookify.Domain.Entities;

namespace Bookify.Domain.Apartaments;

public interface IApartamentsRepository
{
   Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
