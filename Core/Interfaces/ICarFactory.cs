using Repository.Database_Layer;

namespace Core.Factories
{
    public interface ICarFactory
    {
        Car GetCarFromBuilder(int version);
    }
}