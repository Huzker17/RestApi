using AutoMapper;
using Revizoro.Application.Common.Mappings;
using Revizorro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revizoro.Application.Places.Queries.GetPlaceDetails
{
    public class GetPlaceReviewsDto : IMapWith<Review>
    {
        public Guid Id { get; set; }
        public Guid PlaceId { get; set; }
        public DateTime PostedTime { get; set; }
        public string Description { get; set; }
        public float Mark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Review, GetPlaceReviewsDto>().ForMember(reviewDto => reviewDto.Id,
                                                        opt => opt.MapFrom(review => review.Id))
                                                        .ForMember(reviewDto => reviewDto.Description,
                                                        opt => opt.MapFrom(review => review.Description))
                                                        .ForMember(reviewDto => reviewDto.Mark,
                                                        opt => opt.MapFrom(reviewDto => reviewDto.Mark))
                                                        .ForMember(reviewDto => reviewDto.PlaceId,
                                                        opt => opt.MapFrom(review => review.PlaceId))
                                                        .ForMember(reviewDto => reviewDto.PostedTime,
                                                        opt => opt.MapFrom(review => review.PostedTime))
                                                        .ForMember(reviewDto => reviewDto.PlaceId,
                                                        opt => opt.MapFrom(review => review.PlaceId));
        }
    }
}
