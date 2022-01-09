using AutoMapper;
using HotelListing.Data;
using HotelListing.Model;

namespace HotelListing.Configuration
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Country, CreateHotelDTO>().ReverseMap();
        }
    }
}
