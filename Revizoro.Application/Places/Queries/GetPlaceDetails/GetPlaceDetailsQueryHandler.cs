using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Revizoro.Application.Common.Exceptions;
using Revizoro.Application.Interfaces;
using Revizorro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revizoro.Application.Places.Queries.GetPlaceDetails
{
    public class GetPlaceDetailsQueryHandler : IRequestHandler<GetPlaceDetailsQuery, GetPlaceDetailsVm>
    {
        private readonly IRevizoroDbContext _db;
        private readonly IMapper _mapper;

        public GetPlaceDetailsQueryHandler(IRevizoroDbContext db, IMapper mapper) => (_db, _mapper) = (db, mapper);
        public async Task<GetPlaceDetailsVm> Handle(GetPlaceDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _db.Places.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                throw new NotFoundException(nameof(Place), request.Id);
            return _mapper.Map<GetPlaceDetailsVm>(entity);
        }
    }
}
