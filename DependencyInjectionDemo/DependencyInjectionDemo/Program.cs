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

            if (args.Count() > 0)
            {
                ItemManager im = new ItemManager(_kernel.Get<IItemLogic>());

                // First let's print a list of all items
                im.PrintAllItems();

                // Now, let's print a list of the item names and prices
                im.PrintItemsAndPrices();
            }
        }
    }
}