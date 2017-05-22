using Core.Interfaces;
using Core.Managers;
using Microsoft.Practices.Unity;
using Repository.Interfaces;
using Repository.Repositores;
using System.Web.Http;
using Unity.WebApi;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            container.RegisterType<ICarManager, CarManager>();
            container.RegisterType<IDriverManager, DriverManager>();
            container.RegisterType<ICar, CarRepository>();
            container.RegisterType<IDriverCar, DriverCarRepository>();
            container.RegisterType<IDriver, DriverRepository>();
        }
    }
}