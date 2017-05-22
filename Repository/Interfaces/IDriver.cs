using Repository.Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDriver
    {
        List<Driver> GetDrivers();
        Driver GetDriver(int id);
        Boolean AddNewDriver(Driver driver);
        Boolean EditDriver(Driver driver);
        Boolean DeleteDriver(Driver driver);
    }
}
