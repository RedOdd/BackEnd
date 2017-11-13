using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;

namespace BackEnd.Controllers
{//{"id":1,"name":"good car","price":1000}
    [Produces("application/json")]
    [Route("car")]
    public class CarController : Controller
    {
        private CarManager _carManager;
        public CarController()
        {
            _carManager = CarManagerSingletonecs.CarManager;
            //_carManager.Add(new Car(1, "good car", 1000));
            //_carManager.Add(new Car(2, "so good car", 200));
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetCarById(int id)
        {
            return Ok(_carManager.GetCarById(id));
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCar([FromBody] Car car)
        {
            _carManager.Add(car);
            return Ok(_carManager.Count);
        }
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody]Car car)
        {
            _carManager.GetCarById(car.Id).Name = car.Name;
            _carManager.GetCarById(car.Id).Price = car.Price;
            return Ok(_carManager.GetCarById(car.Id));
        }
    }
}