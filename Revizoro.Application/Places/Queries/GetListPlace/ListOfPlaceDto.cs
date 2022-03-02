using System;
using System.Collections.Generic;
using AutoMapper;
using Revizoro.Application.Common.Mappings;
using Revizorro.Domain;

namespace Revizoro.Application.Places.Queries.GetListPlace
{
    public class ListOfPlaceDto : IMapWith<Place>
    {
        public Guid Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public float Rating { get; set; }
        public int CountOfReviews { get; set; }
        public IEnumerable<string> Photos { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Place, ListOfPlaceDto>().ForMember(placeDto => placeDto.Id,
                                                       opt => opt.MapFrom(place => place.Id))
                                                       .ForMember(placeDto => placeDto.Photo,
                                                       opt => opt.MapFrom(place => place.MainPhoto))
                                                       .ForMember(placeDto => placeDto.Title,
                                                       opt => opt.MapFrom(place => place.Title))
                                                       .ForMember(placeDto => placeDto.Rating,
                                                       opt => opt.MapFrom(place => place.Rating))
                                                       .ForMember(placeDto => placeDto.Photos,
                                                       opt => opt.MapFrom(place => place.GalleryPhotos));
        }
    }
}