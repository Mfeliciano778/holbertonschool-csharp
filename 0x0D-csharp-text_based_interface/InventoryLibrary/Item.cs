using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    class Item : BaseClass
    {
        string name { get; set; }
        string description { get; set; }
        float price { get; set; }
        List<string> tags { get; set; }

        public Item(string Name, string Description = null, float Price = 0.00f, List<string> Tags = null)
        {
            this.name = Name;
            this.description = Description;
            this.price = Price;
            this.tags = new List<string>();
            this.tags = Tags;
        }

        public override string ToString()
        {
            return string.Format(@"______________________________________________________
|
| ID: {0}    Date Created: {1}    Date Updated: {2}
| Name: {3}    Description: {4}    Price: {5}    Tags: {6}
|_____________________________________________________
", this.id, this.date_created, this.date_updated, this.name, this.description, this.price.ToString("0.00"), String.Join(", ", this.tags));
        }
    }    
}