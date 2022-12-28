using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal interface ICarBrand
    {
        string BrandName { get; set; }
        string ModelName { get; set; }
        string Horsepower { get; set; }
        string MaxSpeed { get; set; }
        CarType Type { get; }
    }
}
