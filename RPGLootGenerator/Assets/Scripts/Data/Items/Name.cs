using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace RPGLootGenerator
{
    public class Name
    {
        public string LootNames;
        public string CombineName(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
    }
}
