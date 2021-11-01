using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    ///<summary> Inventory Class </summary>
    class Inventory: BaseClass
    {
        ///<summary> int user_id </summary>
        public int user_id;
        ///<summary> int item_id </summary>
        public int item_id;
        ///<summary> uint quantity </summary>
        public uint quantity = 1;

        // A required property must have a value on creation, it cannot be left blank

        // Required properties
        // user_id - from User id
        // item_id - from Item id
        // quantity - int, default value: 1, cannot be less than 0

    }
}
