using DependencyInjectionDemo.DomainLogic.Interfaces;
using DependencyInjectionDemo.IoC;
using Ninject;
using System.Linq;

namespace DependencyInjectionDemo
{
    /// <summary>
    /// Dependency Injection Demo - Here is where we start!
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            IKernel _kernel = Bootstrapper.Initialize();

            ItemManager im = new ItemManager(_kernel.Get<IItemLogic>());
            im.PrintAllItems();
            im.PrintItemsAndPrices();
        }
    }
}