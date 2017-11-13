using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class CarManager
    {
        private HashSet<Car> _cars;
        public int Count => _cars.Count;
        public CarManager()
        {
            _cars = new HashSet<Car>();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public Car GetCarById(int id)
        {
            return _cars.SingleOrDefault(car => car.Id.Equals(id));
        }
    }
}
