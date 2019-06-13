using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
        #region Item Variables
        public ItemName itemName;
        public ItemRarity itemRarity;
        public ItemRequirement itemRequirements;
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
        public string itemCombinedNameString;
        #endregion

        #region Item Constructor
        public Item(ItemName itemName, ItemRarity itemRarity, ItemRequirement itemRequirements, ItemTypes itemType,
                    ItemStats itemStat1, ItemStats itemStat2, ItemStats itemStat3, ItemStats itemStat4, ItemStats itemStat5, ItemStats itemStat6,
                    ItemMod itemMod1, ItemMod itemMod2, ItemMod itemMod3, ItemMod itemMod4, ItemMod itemMod5, ItemMod itemMod6,
                    ItemAffixs itemPrefixs1, ItemAffixs itemPrefixs2, ItemAffixs itemPrefixs3, ItemAffixs itemSuffixs1, ItemAffixs itemSuffixs2, ItemAffixs itemSuffixs3)
        {
            this.itemName = itemName;
            this.itemRarity = itemRarity;
            itemName.itemType = itemType;
            this.itemRequirements = itemRequirements;
            this.itemStat1 = itemStat1;
            this.itemStat2 = itemStat2;
            this.itemStat3 = itemStat3;
            this.itemStat4 = itemStat4;
            this.itemStat5 = itemStat5;
            this.itemStat6 = itemStat6;
            this.itemPrefixs1 = itemPrefixs1;
            this.itemPrefixs2 = itemPrefixs2;
            this.itemPrefixs3 = itemPrefixs3;
            this.itemSuffixs1 = itemSuffixs1;
            this.itemSuffixs2 = itemSuffixs2;
            this.itemSuffixs3 = itemSuffixs3;
            this.itemCombinedNameString = itemCombinedNameString;
            ItemGenerator();
        }
        #endregion

        public void ItemGenerator()
        {

           
        }
    }
}
