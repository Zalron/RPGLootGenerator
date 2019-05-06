using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
        #region Item Variables and Constructor
        public ItemTypeName itemName;
        public Rarity itemRarity;
        public ItemType itemType;
        public ItemStatType itemStat1;
        public ItemStatType itemStat2;
        public ItemStatType itemStat3;
        public ItemStatType itemStat4;
        public ItemStatType itemStat5;
        public ItemStatType itemStat6;
        public string itemNameString;
        public string itemCombinedNameString;
        public string itemPrefix1String;
        public string itemPrefix2String;
        public string itemPrefix3String;
        public string itemSuffix1String;
        public string itemSuffix2String;
        public string itemSuffix3String;
        public string itemRarityString;
        public string itemTypeString;
        public string itemRequirementsString;
        public string itemStats1String;
        public string itemStats2String;
        public string itemStats3String;
        public string itemStats4String;
        public string itemStats5String;
        public string itemStats6String;
        public string itemImplisits;
        public string itemExplisits;
        public Item(ItemTypeName itemName, 
                    string itemPrefix1, 
                    string itemSuffix1,
                    string itemCombinedName,
                    string itemRarity, 
                    string itemType, 
                    string itemRequirements)
        {
            this.itemName = itemName;
            this.itemPrefix1String = itemPrefix1;
            this.itemSuffix1String = itemSuffix1;
            this.itemRarityString = itemRarity;
            this.itemTypeString = itemType;
            this.itemRequirementsString = itemRequirements;
            this.itemCombinedNameString = itemCombinedName;
        }
        #endregion
        public void ItemGenerator()
        {
            itemName = ItemName.GenerateItemName();
            if (itemName == ItemTypeName.ITEM_COUNTSTART)
            {
                itemName = ItemName.GenerateItemName();
            }
            itemType = ItemTypes.ItemTypeGenerator(itemName);
            //if () 
            //{
                 
            //}
            itemRarity = ItemRarity.RarityGenerator();
            if (itemRarity == Rarity.COMMON)
            {
                itemCombinedNameString = itemNameString;
            }
            if (itemRarity == Rarity.UNCOMMON || 
                itemRarity == Rarity.RARE || 
                itemRarity == Rarity.UNQIUE || 
                itemRarity == Rarity.MASTERWORK || 
                itemRarity == Rarity.EXOTIC ||
                itemRarity == Rarity.LEGENDARY)
            {
                itemPrefix1String = Affixs.GeneratePrefixs();
                itemSuffix1String = Affixs.GenerateSuffixs();
                itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
            }
            itemRequirementsString = ItemRequirements.RequirementsGenerator();
            itemStat1 = ItemStats.AttackSpeedGenerator(itemRarity, itemType, itemRequirements);
            itemStat2 = ItemStats.CriticalChanceGenerator(itemRarity);
            itemStat3 = ItemStats.MagicalDamageGenerator(itemRarity);
            itemStat4 = ItemStats.PhysicalDamageGeneratorMin(itemRarity);

        }
    }
}
