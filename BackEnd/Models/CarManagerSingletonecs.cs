using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public static class CarManagerSingletonecs
    {
        private static CarManager _carManager = new CarManager();
        
        public static CarManager CarManager { get => _carManager; }
    }
}
