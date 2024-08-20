using AutoMapper;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Mapper
{
	public class CargoProfile : Profile
	{
		public CargoProfile()
		{
			CreateMap<CreateCargoCompanyDto, CargoCompany>();
			CreateMap<UpdateCargoCompanyDto, CargoCompany>();
		}
	}
}
