using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.BLL.Abstracts;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Concretes;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.BLL.Concretes
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepostiory;
        private readonly IMapper _mapper;

        public CarManager(ICarRepository carRepostiory, IMapper mapper)
        {
            _carRepostiory = carRepostiory;
            _mapper = mapper;
        }

        /// <summary>
        /// Deletes the car with update it status value to passive.
        /// </summary>
        /// <param name="carId">Id of the car to be deleted</param>
        /// <returns>true or false</returns>
        public async Task<bool> DeleteCarByCarId(int carId)
        {
            var car = await _carRepostiory.GetByIdAsync(carId);

            if(car == null)
                return false;
            
            var isDeleted = await _carRepostiory.DeleteAsync(car);

            return isDeleted ? true : false;
        }

        /// <summary>
        /// Returns the cars of the given color as a list
        /// </summary>
        /// <param name="color">Color of cars to list</param>
        /// <returns>List<CarDto></returns>
        public async Task<List<CarDto>> GetCarByColorAsync(string color)
        {
            var cars = await _carRepostiory.GetByColorAsync(color);

            return _mapper.Map<List<CarDto>>(cars);
        }

        /// <summary>
        /// Turn on car headlights
        /// </summary>
        /// <param name="carId">Identity of the car whose headlights will be turned on</param>
        /// <returns>CarDto</returns>
        public async Task<CarDto> TurnOnHeadLights(int carId)
        {
           var car = await _carRepostiory.TurnOnHeadlights(carId);
           return _mapper.Map<CarDto>(car);
         
        }

        /// <summary>
        /// Turn off car headlights
        /// </summary>
        /// <param name="carId">Identity of the car whose headlights will be turned off</param>
        /// <returns>CarDto</returns>
        public async Task<CarDto> TurnOffHeadLights(int carId)
        {
            var car = await _carRepostiory.TurnOnHeadlights(carId);
            return _mapper.Map<CarDto>(car);
        }
    }
}
