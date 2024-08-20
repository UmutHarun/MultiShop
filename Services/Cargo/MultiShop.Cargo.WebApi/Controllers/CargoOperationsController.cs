using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoOperationsController : ControllerBase
	{
		private readonly ICargoOperationService _cargoOperationService;
		private readonly IMapper _mapper;

		public CargoOperationsController(ICargoOperationService cargoOperationService, IMapper mapper)
		{
			_cargoOperationService = cargoOperationService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var values = _cargoOperationService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
		{
			var value = _mapper.Map<CargoOperation>(createCargoOperationDto);
			_cargoOperationService.TInsert(value);
			return Ok("Operation created");
		}

		[HttpDelete]
		public IActionResult RemoveCargoOperation(int id)
		{
			_cargoOperationService.TDelete(id);
			return Ok("Operation removed");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoOperationById(int id)
		{
			var value = _cargoOperationService.TGetById(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
		{
			var value = _mapper.Map<CargoOperation>(updateCargoOperationDto);
			_cargoOperationService.TUpdate(value);
			return Ok("Operation updated");
		}
	}
}
