using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    class Inventory : BaseClass
    {
        string user_id { get; set; }
        string item_id { get; set; }
        int quantity { get; set; }

        public Inventory(string User_Id, string I_ID, int Quantity = 1)
        {
            this.user_id = User_Id;
            this.item_id = I_ID;
            if (Quantity < 1)
                Quantity = 1;
            this.quantity = Quantity;
        }
    }    
}