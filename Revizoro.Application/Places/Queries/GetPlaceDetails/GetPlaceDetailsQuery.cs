using System;
using System.Collections.Generic;
using MediatR;

namespace Revizoro.Application.Places.Queries.GetPlaceDetails
{
    public class GetPlaceDetailsQuery : IRequest<GetPlaceDetailsVm>
    {
        public Guid Id { get; set; }
        public GetPlaceDetailsVm Place { get; set; }
    }
}
