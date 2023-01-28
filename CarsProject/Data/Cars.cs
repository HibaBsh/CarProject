using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Data
{
    [Table("Cars")]
    public class Cars
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string NumOfDoors { get; set; }
        public string BodyStyle { get; set; }
        public string EngineLocation { get; set; }
        public string NumberOfCylinders { get; set; }
        public int HorsePower { get; set; }
        public double Price { get; set; }
    }
}