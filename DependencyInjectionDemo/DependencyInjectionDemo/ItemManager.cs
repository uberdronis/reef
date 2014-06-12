using DependencyInjectionDemo.DomainLogic.Interfaces;
using DependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;

namespace DependencyInjectionDemo
{
    /// <summary>
    /// This is the bridge between the user interface and the domain logic layer
    /// </summary>
    public class ItemManager
    {
        IItemLogic _itemLogic = null;

        /// <summary>
        /// Constructor for ItemLogic
        /// </summary>
        /// <param name="itemLogic">IItemLogic interface (pass in concrete object)</param>
        public ItemManager(IItemLogic itemLogic)
        {
            _itemLogic = itemLogic;
        }

        /// <summary>
        /// Print all items in the database
        /// </summary>
        public void PrintAllItems()
        {
            List<Item> items = _itemLogic.GetAllItems();
            foreach(Item i in items)
            {
                printToConsole(String.Format("({0}) {1} - {2} (${3}/${4}).",
                        i.DatabaseTechnology, i.Id, i.Name, i.Price, i.BulkPrice));
            }
        }

        /// <summary>
        /// Print all items and their current price
        /// </summary>
        public void PrintItemsAndPrices()
        {
            Dictionary<string, float> items = _itemLogic.GetItemNamesAndPrices();
            foreach (KeyValuePair<string, float> item in items)
            {
                printToConsole(String.Format("{0} - ${1}", item.Key, item.Value));
            }
        }

        private void printToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
