namespace DependencyInjectionDemo.Models
{
    /// <summary>
    /// Item Model - represents items persisted in the system;
    /// </summary>
    public class Item : BaseModel
    {
        /// <summary>
        /// Identifier for the item record;
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Item name;
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price for the item on a normal basis;
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Bulk Price for the item.  Applies to specific customers;
        /// </summary>
        public decimal BulkPrice { get; set; }
    }
}
