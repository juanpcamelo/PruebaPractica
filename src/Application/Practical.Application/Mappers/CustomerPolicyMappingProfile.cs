using AutoMapper;
using Practical.Application.DTOs.Request;
using Practical.Application.DTOs.Response;
using PracticalApplication.Domain.Customer;

namespace Practical.Application.Mappers
{
    public class CustomerPolicyMappingProfile : Profile
    {
        public CustomerPolicyMappingProfile()
        {
            CreateMap< ViewClientPolicy, CustomerPolicy>()
                .ForMember(c => c.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(c => c.Name, opt => opt.MapFrom(src => src.NombreCliente))
                .ForMember(c => c.Identification, opt => opt.MapFrom(src => src.IdentificacionCliente))
                .ForMember(c => c.BirthDate, opt => opt.MapFrom(src => src.FechaNacimientoCliente))
                .ForMember(c => c.PolizaStartDate, opt => opt.MapFrom(src => src.FechaPoliza))
                .ForMember(c => c.PolizaEndDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(c => c.Coverage, opt => opt.MapFrom(src => src.Coberturas))
                .ForMember(c => c.MaxCoverage, opt => opt.MapFrom(src => src.ValorMaximoCubierto))
                .ForMember(c => c.NamePoliza, opt => opt.MapFrom(src => src.NombrePlan))
                .ForMember(c => c.CityResidence, opt => opt.MapFrom(src => src.CiudadResidenciaCliente))
                .ForMember(c => c.AddressResidence, opt => opt.MapFrom(src => src.DireccionResidenciaCliente))
                .ForMember(c => c.PlacaAutomotor, opt => opt.MapFrom(src => src.PlacaAutomotor))
                .ForMember(c => c.VehicleInspection, opt => opt.MapFrom(src => src.TieneInspeccionVehiculo)).ReverseMap();


            CreateMap<CreateClientPolicy, CustomerPolicy>()
                .ForMember(c => c.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(c => c.Name, opt => opt.MapFrom(src => src.NombreCliente))
                .ForMember(c => c.Identification, opt => opt.MapFrom(src => src.IdentificacionCliente))
                .ForMember(c => c.BirthDate, opt => opt.MapFrom(src => src.FechaNacimientoCliente))
                .ForMember(c => c.PolizaStartDate, opt => opt.MapFrom(src => src.FechaPoliza))
                .ForMember(c => c.PolizaEndDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(c => c.Coverage, opt => opt.MapFrom(src => src.Coberturas))
                .ForMember(c => c.MaxCoverage, opt => opt.MapFrom(src => src.ValorMaximoCubierto))
                .ForMember(c => c.NamePoliza, opt => opt.MapFrom(src => src.NombrePlan))
                .ForMember(c => c.CityResidence, opt => opt.MapFrom(src => src.CiudadResidenciaCliente))
                .ForMember(c => c.AddressResidence, opt => opt.MapFrom(src => src.DireccionResidenciaCliente))
                .ForMember(c => c.PlacaAutomotor, opt => opt.MapFrom(src => src.PlacaAutomotor))
                .ForMember(c => c.VehicleInspection, opt => opt.MapFrom(src => src.TieneInspeccionVehiculo));

        }


    }
}
