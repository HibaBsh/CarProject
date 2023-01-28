using CarsProject.Context;
using CarsProject.Data;
using CarsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsProject.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            CarContext context = new CarContext();
            CarModel carmodel = new CarModel();
            carmodel.licars = context.cars.ToList();
            return View("Index", carmodel);
           
        }
        
        public ActionResult GetAllCarsbyfilter( CarModel search)
        {
            try
            {
                using (CarContext _context = new CarContext())
                {

                    List<Cars> data = _context.cars.Where(h =>
                    ((search.carfilter.Make == h.Make) ||
                    (search.carfilter.NumberOfCylinders == h.NumberOfCylinders) ||
                    (search.carfilter.NumberOfDoors == h.NumOfDoors) ||
                    (search.carfilter.HorsePower == h.HorsePower) ||
                    (search.carfilter.Price == h.Price))).ToList();

                    CarModel carmodel = new CarModel();
                    carmodel.licars = data;
                    return View("Index", carmodel);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}