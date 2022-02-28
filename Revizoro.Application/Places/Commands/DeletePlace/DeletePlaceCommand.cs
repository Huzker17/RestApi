using System;
using MediatR;

namespace Revizoro.Application.Places.Commands.DeletePlace
{
    public class DeletePlaceCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
