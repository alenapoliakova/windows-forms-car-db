namespace lab_3
{
    internal class Car : ICarBrand
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Horsepower { get; set; }
        public string MaxSpeed { get; set; }
        public CarType Type { get; }

        public Car(string brandName, string modelName, string horsepower, string maxSpeed)
        {
            BrandName = brandName;
            ModelName = modelName;
            Horsepower = horsepower;
            MaxSpeed = maxSpeed;
            Type = CarType.CAR;
        }
    }
}
