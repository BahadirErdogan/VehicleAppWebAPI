using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VehicleApp.BLL.Abstracts;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCarByColor")]
        public async Task<IActionResult> GetCarByColor(string color)
        {
            List<CarDto> cars = await _carService.GetCarByColorAsync(color);
            if (cars == null) return NotFound();
            else return Ok(cars);
        }

        [HttpDelete]
        [Route("DeleteCarBy/{carId}")]
        public async Task<IActionResult> DeleteCarBy(int carId)
        {
            var result = await _carService.DeleteCarByCarId(carId);

            if (result)
            {
                return Ok(new { message = "Car has been deleted." });
            }

            return BadRequest(new {message = "Something went wrong. Please check ID and try again."});
        }

        [HttpPut]
        [Route("TurnOnOffHeadLights/{carId}")]
        public async Task<IActionResult> TurnOnOffHeadLights(int carId)
        {
            var result = await _carService.TurnOnOffHeadLights(carId);
            if(result!= null)
            {
                if(result.Headlights)
                    return Ok(new { message = "Car headlights on." });
                else
                    return Ok(new { message = "Car headlights off." });
            }
            else
                return BadRequest(new { message = "Something went wrong. Please check ID and try again." });
        }
    }
}
