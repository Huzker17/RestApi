using MediatR;
using Microsoft.EntityFrameworkCore;
using Revizoro.Application.Common.Exceptions;
using Revizoro.Application.Interfaces;
using Revizorro.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Revizoro.Application.Places.Commands.UpdatePlace
{
    public class UpdatePlaceCommandHandler : IRequestHandler<UpdatePlaceCommand>
    {
        private readonly IRevizoroDbContext _db;
        public UpdatePlaceCommandHandler(IRevizoroDbContext db) => _db = db;
        public async Task<Unit> Handle(UpdatePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = await _db.Places.FirstOrDefaultAsync(x => x.Id == request.Id,cancellationToken);
            if(place == null || place.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Place), request.Id);
            }
            place.Title = request.Title;
            place.Description = request.Description;
            place.GalleryPhotos.Append(request.Photo);
            _db.Places.Update(place);
            await _db.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
