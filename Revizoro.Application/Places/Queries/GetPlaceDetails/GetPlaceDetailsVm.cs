using AutoMapper;
using Revizoro.Application.Common.Mappings;
using Revizorro.Domain;
using System;
using System.Collections.Generic;

namespace Revizoro.Application.Places.Queries.GetPlaceDetails
{
    public class GetPlaceDetailsVm : IMapWith<Place>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainPhoto { get; set; }
        public IEnumerable<string> GalleryPhotos { get; set; }
        public float Rating { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Place, GetPlaceDetailsVm>().ForMember(placeVm => placeVm.Id,
                                                            opt => opt.MapFrom(place => place.Id))
                                                            .ForMember(placeVm => placeVm.Title,
                                                            opt => opt.MapFrom(place => place.Title))
                                                            .ForMember(placeVm => placeVm.Description,
                                                            opt => opt.MapFrom(place => place.Description))
                                                            .ForMember(placeVm => placeVm.MainPhoto,
                                                            opt => opt.MapFrom(place => place.MainPhoto))
                                                            .ForMember(placeVm => placeVm.GalleryPhotos,
                                                            opt => opt.MapFrom(place => place.GalleryPhotos))
                                                            .ForMember(placeVm => placeVm.Rating,
                                                            opt => opt.MapFrom(place => place.Rating));

        }

    }
}