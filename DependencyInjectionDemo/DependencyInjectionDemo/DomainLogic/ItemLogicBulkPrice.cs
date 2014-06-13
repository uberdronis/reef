using DependencyInjectionDemo.DataAccess;
using DependencyInjectionDemo.DomainLogic.Interfaces;
using DependencyInjectionDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionDemo.DomainLogic
{
    public class ItemLogicBulkPrice : IItemLogic
    {
        IDBDirector _dbStore = null;

        /// <summary>
        /// Constructor for the Item Domain Logic
        /// </summary>
        /// <param name="dbStore">IDBDirector interface - contract</param>
        public ItemLogicBulkPrice(IDBDirector dbStore)
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
        /// Returns a collection of Items and their BULK PRICE!  Custom Logic!
        /// </summary>
        /// <returns>Dictionary containing Items and Prices</returns>
        public Dictionary<string, decimal> GetItemNamesAndPrices()
        {
            return _dbStore.GetAllItems()
                .ToDictionary(x => x.Name, x => x.BulkPrice);
        }
    }
}
