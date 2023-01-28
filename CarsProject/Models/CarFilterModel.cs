using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsProject.Models
{
    public class CarFilterModel
    {
        public string Make { set; get; }
        public string NumberOfDoors { set; get; }
        public string NumberOfCylinders { set; get; }
        public int? HorsePower { set; get; }
        public double? Price { set; get; }
    }
}