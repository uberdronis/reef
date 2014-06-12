using DependencyInjectionDemo.Models.Enums;
using System;

namespace DependencyInjectionDemo.Models
{
    /// <summary>
    /// Base Class for all of the Models
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Database Technology where this data resides
        /// </summary>
        public DatabaseTechnologyEnum DatabaseTechnology { get; set; }

        /// <summary>
        /// Date when the model record was created
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// User that created the model record
        /// </summary>
        public string CreatedUser { get; set; }
    }
}