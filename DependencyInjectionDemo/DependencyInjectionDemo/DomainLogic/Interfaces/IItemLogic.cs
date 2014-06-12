using DependencyInjectionDemo.Models;
using System.Collections.Generic;

namespace DependencyInjectionDemo.DomainLogic.Interfaces
{
    /// <summary>
    /// Exposes a "contract" for the Item Domain Logic
    /// </summary>
    public interface IItemLogic
    {
        List<Item> GetAllItems();
        Item GetItemById(int id);
        Dictionary<string, float> GetItemNamesAndPrices();
    }
}