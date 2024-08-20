using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCompaniesController : ControllerBase
	{
		private readonly ICargoCompanyService _cargoCompanyService;
		private readonly IMapper _mapper;

		public CargoCompaniesController(ICargoCompanyService cargoCompanyService, IMapper mapper)
		{
			_cargoCompanyService = cargoCompanyService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var values = _cargoCompanyService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
		{
			var value = _mapper.Map<CargoCompany>(createCargoCompanyDto);
			_cargoCompanyService.TInsert(value);
			return Ok("Company created");
		}

		[HttpDelete("{id}")]
		public IActionResult RemoveCargoCompany(int id)
		{
			_cargoCompanyService.TDelete(id);
			return Ok("Company removed");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCompanyById(int id)
		{
			var value = _cargoCompanyService.TGetById(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
		{
			var value = _mapper.Map<CargoCompany>(updateCargoCompanyDto);
			_cargoCompanyService.TUpdate(value);
			return Ok("Company updated");
		}
	}
}
