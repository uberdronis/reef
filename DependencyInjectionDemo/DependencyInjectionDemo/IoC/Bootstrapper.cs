using DependencyInjectionDemo.DomainLogic;
using DependencyInjectionDemo.DomainLogic.Interfaces;
using Ninject;

namespace DependencyInjectionDemo.IoC
{
    /// <summary>
    /// Dependency Injection Bootstrapper.  This is where the system decides what concrete
    /// classes to use based on configurations setup by the user;
    /// </summary>
    public static class Bootstrapper
    {
        public static IKernel Initialize()
        {
            // Instantiate a new Kernel, bind the interfaces, return the kernel object
            StandardKernel kernel = new StandardKernel();
            RegisterBindings(kernel);
            return kernel;
        }

        private static void RegisterBindings(IKernel kernel)
        {
            // Data Store Bindings


            // Logic Bindings
            kernel.Bind<IItemLogic>().To<ItemLogic>();
            //kernel.Bind<IItemLogic>().To<ItemLogicBulkPrice>();
        }
    }
}