using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCustomersController : ControllerBase
	{
		private readonly ICargoCustomerService _cargoCustomerService;
		private readonly IMapper _mapper;

		public CargoCustomersController(ICargoCustomerService cargoCustomerService, IMapper mapper)
		{
			_cargoCustomerService = cargoCustomerService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var values = _cargoCustomerService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
		{
			var value = _mapper.Map<CargoCustomer>(createCargoCustomerDto);
			_cargoCustomerService.TInsert(value);
			return Ok("Customer created");
		}

		[HttpDelete]
		public IActionResult RemoveCargoCustomer(int id)
		{
			_cargoCustomerService.TDelete(id);
			return Ok("Customer removed");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCustomerById(int id)
		{
			var value = _cargoCustomerService.TGetById(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
		{
			var value = _mapper.Map<CargoCustomer>(updateCargoCustomerDto);
			_cargoCustomerService.TUpdate(value);
			return Ok("Customer updated");
		}
	}
}
