using MediatR;
using Revizoro.Application.Interfaces;
using Revizorro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revizoro.Application.Places.Commands.CreatePlace
{
    public class CreatePlaceCommandHandler : IRequestHandler<CreatePlaceCommand, Guid>
    {
        private readonly IRevizoroDbContext _db;
        public CreatePlaceCommandHandler(IRevizoroDbContext db) => _db = db;

        public async Task<Guid> Handle(CreatePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = new Place
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Rating = 0,
            };
            await _db.Places.AddAsync(place, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return place.Id;
        }
    }
}
