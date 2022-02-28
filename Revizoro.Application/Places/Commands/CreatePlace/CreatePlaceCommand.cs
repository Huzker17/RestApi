using System;
using MediatR;

namespace Revizoro.Application.Places.Commands.CreatePlace
{
    public class CreatePlaceCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
