using DependencyInjectionDemo.DataAccess;
using DependencyInjectionDemo.DomainLogic.Interfaces;
using DependencyInjectionDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionDemo.DomainLogic
{
    /// <summary>
    /// Domain Logic for the Item Models;
    /// </summary>
    public class ItemLogic : IItemLogic
    {
        IDBDirector _dbStore = null;

        /// <summary>
        /// Constructor for the Item Domain Logic
        /// </summary>
        /// <param name="dbStore">IDBDirector interface - contract</param>
        public ItemLogic(IDBDirector dbStore)
        {
            _dbStore = dbStore;
        }

        /// <summary>
        /// Returns a list of all items
        /// </summary>
        /// <returns>List of Items</returns>
        public List<Item> GetAllItems()
        {
            return _dbStore.GetAllItems().ToList();
        }

        /// <summary>
        /// Returns a single item by ID
        /// </summary>
        /// <param name="id">Integer containing Id for Item</param>
        /// <returns>Single Item instance</returns>
        public Item GetItemById(int id)
        {
            return _dbStore.GetItemById(id);
        }

        /// <summary>
        /// Returns a collection of Items and their price (default behavior)
        /// </summary>
        /// <returns>Dictionary containing Items and Prices</returns>
        public Dictionary<string, decimal> GetItemNamesAndPrices()
        {
            return _dbStore.GetAllItems()
                .ToDictionary(x => x.Name, x => x.Price);
        }
    }
}