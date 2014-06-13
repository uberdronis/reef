using DependencyInjectionDemo.Common;
using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionDemo.DataAccess.SQLServer
{
    public class SQLServerDB : IDBDirector
    {
        protected DependencyInjectionDBContext _db = new DependencyInjectionDBContext(
            ConfigurationManagerHelper.GetConnectionString("SQLServerConnectionString"));
        
        public IEnumerable<Item> GetAllItems()
        {
            List<Item> result = _db.Set<Item>().ToList();
            foreach (Item item in result)
                item.DatabaseTechnology = DatabaseTechnologyEnum.MicrosoftSQLServer;
            return result;
        }

        public Item GetItemById(int id)
        {
            Item result = _db.Set<Item>().Where(x => x.Id == id).FirstOrDefault();
            result.DatabaseTechnology = DatabaseTechnologyEnum.MicrosoftSQLServer;
            return result;
        }
    }
}
