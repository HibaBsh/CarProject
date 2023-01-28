using CarsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsProject.Models
{
    public class CarModel
    {
        public CarFilterModel carfilter { set; get; }
        public Cars car { set; get; }
        public List<Cars> licars { set; get; }
    }
}