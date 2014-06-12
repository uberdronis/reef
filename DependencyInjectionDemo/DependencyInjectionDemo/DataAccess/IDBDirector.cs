using DependencyInjectionDemo.Models;
using System.Collections.Generic;

namespace DependencyInjectionDemo.DataAccess
{
    /// <summary>
    /// Exposes a "contract" to all implementations of the data access layer
    /// </summary>
    public interface IDBDirector
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(int id);
    }
}