using MediatR;
using Revizoro.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Revizorro.Domain;
using Revizoro.Application.Common.Exceptions;

namespace Revizoro.Application.Places.Commands.DeletePlace
{
    public class DeletePlaceCommandHandler : IRequestHandler<DeletePlaceCommand>
    {
        private readonly IRevizoroDbContext _db;
        public DeletePlaceCommandHandler(IRevizoroDbContext db) => _db = db;
        public async Task<Unit> Handle(DeletePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = await _db.Places.FirstOrDefaultAsync(x => x.Id == request.Id,cancellationToken);
            if (place == null || place.UserId != request.UserId)
                throw new NotFoundException(nameof(Place), request.Id);
            _db.Places.Remove(place);
            await _db.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
