using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace RPGLootGenerator
{
    public static class Name
    {
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
    }
}
