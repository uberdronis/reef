using DependencyInjectionDemo.Common;
using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Models.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DependencyInjectionDemo.DataAccess.MySQL
{
    /// <summary>
    /// Implementation of the MySQL DB.
    /// </summary>
    public class MySQLDB : IDBDirector
    {
        /// <summary>
        /// Gets all items from db
        /// </summary>
        /// <returns>List of Items</returns>
        public IEnumerable<Item> GetAllItems()
        {
            string query = "SELECT Id, Name, Price, BulkPrice, CreatedDate, CreatedUser FROM items";
            return GetItemsFromQuery(query);
        }

        /// <summary>
        /// Get a single item by ID
        /// </summary>
        /// <param name="id">Identifier for Model</param>
        /// <returns>Instance of Item Model</returns>
        public Item GetItemById(int id)
        {
            string query = "SELECT Id, Name, Price, BulkPrice, CreatedDate, CreatedUser FROM items WHERE id=" + id.ToString();
            return GetItemsFromQuery(query).FirstOrDefault();
        }

        private List<Item> GetItemsFromQuery(string query)
        {
            DataSet result = new DataSet();

            MySqlConnection connection = new MySqlConnection(ConfigurationManagerHelper.GetConnectionString("MySQLConnectionString"));
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(result);

            if (connection.State == ConnectionState.Open)
                connection.Close();

            return ConvertDataTableToListOfItems(result.Tables[0]);
        }

        private List<Item> ConvertDataTableToListOfItems(DataTable dt)
        {
            List<Item> result = new List<Item>();

            foreach(DataRow dr in dt.Rows)
            {
                result.Add(new Item() { 
                    DatabaseTechnology = DatabaseTechnologyEnum.MySQL,
                    Id = Int32.Parse(dr["Id"].ToString()),
                    Name = dr["Name"].ToString(),
                    Price = decimal.Parse(dr["Price"].ToString()),
                    BulkPrice = decimal.Parse(dr["BulkPrice"].ToString()),
                    CreatedDate = DateTime.Parse(dr["CreatedDate"].ToString()),
                    CreatedUser = dr["CreatedUser"].ToString() });
            }

            return result;
        }
    }
}
