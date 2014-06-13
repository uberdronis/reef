using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionDemo.DataAccess.Raven
{
    /// <summary>
    /// Implementation of the RavenDB Data Access Layer;
    /// </summary>
    public class RavenDB : IDBDirector
    {
        /// <summary>
        /// Gets List of Items (To be implemented)
        /// </summary>
        /// <returns>List of Item models</returns>
        public IEnumerable<Item> GetAllItems()
        {
            return GetListOfItems();
        }

        /// <summary>
        /// Get single Item by ID
        /// </summary>
        /// <param name="id">Identifier for the Item model</param>
        /// <returns>Item instance that matches the id passed in</returns>
        public Item GetItemById(int id)
        {
            return GetListOfItems().Where(x => x.Id == id).FirstOrDefault();
        }

        private List<Item> GetListOfItems()
        {
            List<Item> result = new List<Item>();

            result.Add(new Item() {
                Id = 1,
                Name = "C-3PO ",
                Price = 1000,
                BulkPrice = 1,
                CreatedDate = DateTime.UtcNow,
                CreatedUser = "System",
                DatabaseTechnology = DatabaseTechnologyEnum.RavenDB });

            result.Add(new Item() {
                Id = 2,
                Name = "R2-D2 ",
                Price = 5000,
                BulkPrice = 5,
                CreatedDate = DateTime.UtcNow,
                CreatedUser = "System",
                DatabaseTechnology = DatabaseTechnologyEnum.RavenDB });
            
            result.Add(new Item() {
                Id = 3,
                Name = "AT-AT ",
                Price = 10000,
                BulkPrice = 10,
                CreatedDate = DateTime.UtcNow,
                CreatedUser = "System",
                DatabaseTechnology = DatabaseTechnologyEnum.RavenDB });

            result.Add(new Item() {
                Id = 4,
                Name = "X-Wing",
                Price = 100000,
                BulkPrice = 100,
                CreatedDate = DateTime.UtcNow,
                CreatedUser = "System",
                DatabaseTechnology = DatabaseTechnologyEnum.RavenDB });
            
            result.Add(new Item() {
                Id = 5,
                Name = "TIE/LN",
                Price = 1000000,
                BulkPrice = 1000,
                CreatedDate = DateTime.UtcNow,
                CreatedUser = "System",
                DatabaseTechnology = DatabaseTechnologyEnum.RavenDB });

            return result;
        }
    }
}