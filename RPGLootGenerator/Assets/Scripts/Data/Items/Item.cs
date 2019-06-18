using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class Item : ScriptableObject
    {
        #region Item Variables
        public ItemName itemName;
        public string itemCombinedNameString;
        public ItemRarities itemRarity;
        public ItemRequirements itemRequirements;
        public ItemStats itemStat1;
        public ItemStats itemStat2;
        public ItemStats itemStat3;
        public ItemStats itemStat4;
        public ItemStats itemStat5;
        public ItemStats itemStat6;
        public ItemAffixs itemPrefixs1;
        public ItemAffixs itemPrefixs2;
        public ItemAffixs itemPrefixs3;
        public ItemAffixs itemSuffixs1;
        public ItemAffixs itemSuffixs2;
        public ItemAffixs itemSuffixs3;
        public ItemMod itemMod1;
        public ItemMod itemMod2;
        public ItemMod itemMod3;
        public ItemMod itemMod4;
        public ItemMod itemMod5;
        public ItemMod itemMod6;
        public int itemLevel;
        public int itemStatInt1;
        public int itemStatInt2;
        public int itemStatInt3;
        public int itemStatInt4;
        public int itemStatInt5;
        public int itemStatInt6;
        public int itemModInt1;
        public int itemModInt2;
        public int itemModInt3;
        public int itemModInt4;
        public int itemModInt5;
        public int itemModInt6;
        //item strings
        #endregion



        public void ItemGenerator()
        {

            
        }
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
        
    }
}
