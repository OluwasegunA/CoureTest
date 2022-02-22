using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Question2.Models;
using Question2.Models.ViewModel;

namespace Question2.Utility{
  public class AutoMapperConfig: Profile{
    public AutoMapperConfig()
    {
      CreateMap<Country, CountryModel>();
          // .ForMember(dest =>
          //     dest.country.countryCode,
          //     opt => opt.MapFrom(src => src.CountryCode))
          //     .ForMember(dest =>
          //     dest.country.countryIso,
          //     opt => opt.MapFrom(src => src.CountryIso))
          //     .ForMember(dest =>
          //     dest.country.name,
          //     opt => opt.MapFrom(src => src.Name))
          // .ForMember(dest =>
          //     dest.country.countryDetails,
          //     opt => opt.MapFrom(src => src.CountryDetail != null || src.CountryDetail.Count() != 0 ? src.CountryDetail.ToList() : default));
          CreateMap<Details, CountryDetails>()
          .ForMember(dest =>
              dest.Operator,
              opt => opt.MapFrom(src => src.countryOperator))
              .ForMember(dest =>
              dest.OperatorCode,
              opt => opt.MapFrom(src => src.operatorCode));
          // .ForMember(dest =>
          //     dest.country.countryDetails,
          //     opt => opt.MapFrom(src => src.CountryDetail != null || src.CountryDetail.Count() != 0 ? src.CountryDetail.ToList() : default));
    } 
  }
}