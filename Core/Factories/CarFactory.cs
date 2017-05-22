using Core.Builders;
using Core.Directors;
using Core.Interfaces;
using Repository.Database_Layer;

namespace Core.Factories
{
    public class CarFactory : ICarFactory
    {
        private readonly AlfaRomeoBuilder alfaRomeoBuilder;
        private readonly MercedesBuilder mercedesBuilder;

        public CarFactory()
        {
            this.alfaRomeoBuilder = new AlfaRomeoBuilder();
            this.mercedesBuilder = new MercedesBuilder();
        }
        private static Car GetCar(CarBuilder carBuilder)
        {
            CarDirector director = new CarDirector(carBuilder);
            director.CreateCar();
            return director.GetCar();
        }

        public Car GetCarFromBuilder(int version)
        {
            switch (version)
            {
                case 0:
                    return GetCar(alfaRomeoBuilder);
                case 1:
                    return GetCar(mercedesBuilder);
                default:
                    return new Car();
            }
        }

    }
}