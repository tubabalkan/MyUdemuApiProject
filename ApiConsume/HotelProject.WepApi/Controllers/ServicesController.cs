using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IServicesService _servicesService;

		public ServicesController(IServicesService servicesService)
		{
			_servicesService = servicesService;
		}

		[HttpGet]
		public IActionResult ServicesList()
		{
			var values = _servicesService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddServices(Services services)
		{
			_servicesService.TInsert(services);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteServices(int id)
		{
			var values = _servicesService.TGetById(id);
			_servicesService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateServices(Services services)
		{
			_servicesService.TUpdate(services);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetServices(int id)
		{
			var values = _servicesService.TGetById(id);
			return Ok(values);
		}
	}
}
