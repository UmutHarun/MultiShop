using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoDetailsController : ControllerBase
	{
		private readonly ICargoDetailService _cargoDetailService;
		private readonly IMapper _mapper;

		public CargoDetailsController(ICargoDetailService cargoDetailService, IMapper mapper)
		{
			_cargoDetailService = cargoDetailService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var values = _cargoDetailService.GetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
		{
			var value = _mapper.Map<CargoDetail>(createCargoDetailDto);
			_cargoDetailService.Insert(value);
			return Ok("Detail created");
		}

		[HttpDelete("{id}")]
		public IActionResult RemoveCargoDetail(int id)
		{
			_cargoDetailService.Delete(id);
			return Ok("Detail removed");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoDetailById(int id)
		{
			var value = _cargoDetailService.GetById(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
		{
			var value = _mapper.Map<CargoDetail>(updateCargoDetailDto);
			_cargoDetailService.Update(value);
			return Ok("Detail updated");
		}
	}
}
