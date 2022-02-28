using Microsoft.EntityFrameworkCore;
using Revizorro.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Revizoro.Application.Interfaces
{
    public interface IRevizoroDbContext
    {
        DbSet<Place> Places { get; set; }
        DbSet<Review> Reviews { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
