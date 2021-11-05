using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// The class all other classes inherit from
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// String of Object IDs
        /// </summary>
        /// <value> Object IDs </value>
        public string id { get; set; }
        /// <summary>
        /// DateTime object that shows when the object was created
        /// </summary>
        /// <value> Datetime object </value>
        public DateTime date_created { get; set; }
        /// <summary>
        /// DateTime object that shows when the object was updated
        /// </summary>
        /// <value> Datetime Object </value>
        public DateTime date_updated { get; set; }

        /// <summary>
        /// Baseclass constructor
        /// </summary>
        public BaseClass() {
            this.id = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Trim('=');
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
