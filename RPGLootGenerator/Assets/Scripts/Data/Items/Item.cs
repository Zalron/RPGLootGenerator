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
        public Requirements itemRequirements;
        public ItemStatType itemStat1;
        public ItemStatType itemStat2;
        public ItemStatType itemStat3;
        public ItemStatType itemStat4;
        public ItemStatType itemStat5;
        public ItemStatType itemStat6;
        public int itemAttackSpeedStatValue;
        public int itemCriticalChaceStatValue;
        public List <int> itemPhysicalDamageValue;
        public int itemStat4Value;
        public List<int> itemStat5Value;
        public List<int> itemStat6Value;
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
            switch (itemRarity)
            {
                case Rarity.COUNTSTART:
                    break;
                case Rarity.COMMON:
                    itemCombinedNameString = itemNameString;
                    break;
                case Rarity.UNCOMMON:
                    itemPrefix1String = Affixs.GeneratePrefixs();
                    itemSuffix1String = Affixs.GenerateSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case Rarity.RARE:
                    itemPrefix1String = Affixs.GeneratePrefixs();
                    itemPrefix2String = Affixs.GeneratePrefixs();
                    itemSuffix1String = Affixs.GenerateSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case Rarity.UNQIUE:
                    itemPrefix1String = Affixs.GeneratePrefixs();
                    itemPrefix2String = Affixs.GeneratePrefixs();
                    itemSuffix1String = Affixs.GenerateSuffixs();
                    itemSuffix2String = Affixs.GenerateSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case Rarity.MASTERWORK:
                    break;
                case Rarity.EXOTIC:
                    break;
                case Rarity.LEGENDARY:
                    break;
                case Rarity.COUNTEND:
                    break;
                default:
                    break;
            }
            itemRequirements = ItemRequirements.RequirementsGenerator();
            itemAttackSpeedStatValue = ItemStats.AttackSpeedGenerator(itemRarity, itemType, itemRequirements);
            itemCriticalChaceStatValue = ItemStats.CriticalChanceRarityGenerator(itemRarity);
            itemStat3Value = ItemStats.MagicalDamageGenerator(itemRarity);
            itemStat4Value = ItemStats.PhysicalDamageGenerator(itemRarity);

        }
    }
}
