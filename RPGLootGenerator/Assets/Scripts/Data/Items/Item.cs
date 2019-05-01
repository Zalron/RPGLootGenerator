using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
        public ItemTypeName itemName;
        public Rarity itemRarity;
        public ItemType itemType;
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
        public string itemRequirements;
        public string itemStats1;
        public string itemStats2;
        public string itemStats3;
        public string itemStats4;
        public string itemStats5;
        public string itemStats6;
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
            this.itemRequirements = itemRequirements;
            this.itemCombinedNameString = itemCombinedName;
        }
        public void ItemGenerator()
        {
            itemName = ItemName.GenerateItemName();
            if (itemName == ItemTypeName.ITEM_COUNTSTART)
            {
                itemName = ItemName.GenerateItemName();
            }
            else
            {
                
            }
            itemType = ItemTypes.ItemTypeGenerator(itemName);
            itemRarity = ItemRarity.RarityGenerator();
            if (itemRarity == Rarity.COMMON)
            {
                itemCombinedNameString = itemNameString;
            }
            if (itemRarity == Rarity.UNCOMMON || itemRarityString == "Rare" || itemRarityString == "Masterwork" || itemRarityString == "Legendary" || itemRarityString == "Unqiue")
            {
                itemPrefix1String = Affixs.GeneratePrefixs();
                itemSuffix1String = Affixs.GenerateSuffixs();
                itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
            }
            itemRequirements = ItemRequirements.RequirementsGenerator();
            itemStats1 = ItemStats.AttackSpeedGenerator(itemRarityString);
            itemStats2 = ItemStats.CriticalChanceGenerator(itemRarityString);
            itemStats3 = ItemStats.MagicalDamageGenerator(itemRarityString);
            itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarityString);

        }
    }
}
