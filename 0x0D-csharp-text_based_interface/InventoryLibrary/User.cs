using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    class User : BaseClass
    {
        string name { get; set; }

        public User(string Name)
        {
            this.name = Name;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + name.ToString();
        }
    }    
}