using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.BLL.Abstracts;
using VehicleApp.Dtos.Busses;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;
        private readonly IMapper _mapper;

        public BusController(IBusService busService, IMapper mapper)
        {
            _busService = busService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetBusByColor")]
        public async Task<IActionResult> GetBusByColor(string color)
        {
            List<BusDto> busses = await _busService.GetBusByColorAsync(color);
            if (busses == null) return NotFound();
            else return Ok(busses);
        }
    }
}
