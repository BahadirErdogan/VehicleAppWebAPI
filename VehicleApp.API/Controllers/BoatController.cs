using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApp.BLL.Abstracts;
using VehicleApp.Dtos.Boats;
using VehicleApp.Dtos.Busses;

namespace VehicleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;
        private readonly IMapper _mapper;

        public BoatController(IBoatService boatService, IMapper mapper)
        {
            _boatService = boatService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetBoatByColor")]
        public async Task<IActionResult> GetBoatByColor(string color)
        {
            List<BoatDto> boats = await _boatService.GetBoatByColorAsync(color);
            if (boats == null) return NotFound();
            else return Ok(boats);
        }
    }
}
