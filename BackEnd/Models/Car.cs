using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Car
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Car(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
