using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Track : ICarBrand
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Horsepower { get; set; }
        public string MaxSpeed { get; set; }
        public CarType Type { get; }
        
        public Track(string brandName, string modelName, string horsepower, string maxSpeed)
        {
            BrandName = brandName;
            ModelName = modelName;
            Horsepower = horsepower;
            MaxSpeed = maxSpeed;
            Type = CarType.TRACK;
        }
    }
}
