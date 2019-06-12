using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
        #region Item Variables
        public ItemTypeName itemName;
        public ItemRarity itemRarity;
        public ItemType itemType;
        public ItemRequirement itemRequirements;
        public ItemStatType itemStat1;
        public ItemStatType itemStat2;
        public ItemStatType itemStat3;
        public ItemStatType itemStat4;
        public ItemStatType itemStat5;
        public ItemStatType itemStat6;
        public ItemPrefixs itemPrefixs1;
        public ItemPrefixs itemPrefixs2;
        public ItemPrefixs itemPrefixs3;
        public ItemSuffixs itemSuffixs1;
        public ItemSuffixs itemSuffixs2;
        public ItemSuffixs itemSuffixs3;
        public int itemStatInt1;
        public int itemStatInt2;
        public int itemStatInt3;
        public int itemStatInt4;
        public int itemStatInt5;
        public int itemStatInt6;
        //item strings
        public string itemNameString;
        public string itemCombinedNameString;
        public string itemRarityString;
        public string itemTypeString;
        public string itemRequirementsString;
        public string itemPrefix1String;
        public string itemPrefix2String;
        public string itemPrefix3String;
        public string itemSuffix1String;
        public string itemSuffix2String;
        public string itemSuffix3String;
        public string itemStats1String;
        public string itemStats2String;
        public string itemStats3String;
        public string itemStats4String;
        public string itemStats5String;
        public string itemStats6String;
        #endregion

        #region Item Constructor
        public Item(ItemTypeName itemName, ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements,
                    ItemStatType itemStat1, ItemStatType itemStat2, ItemStatType itemStat3, ItemStatType itemStat4, ItemStatType itemStat5, ItemStatType itemStat6,
                    int itemStatInt1, int itemStatInt2, int itemStatInt3, int itemStatInt4, int itemStatInt5, int itemStatInt6,
                    int itemModInt1, int itemModInt2, int itemModInt3, int itemModInt4, int itemModInt5, int itemModInt6,
                    ItemPrefixs itemPrefixs1, ItemPrefixs itemPrefixs2, ItemPrefixs itemPrefixs3, ItemSuffixs itemSuffixs1, ItemSuffixs itemSuffixs2, ItemSuffixs itemSuffixs3,
                    string itemNameString, string itemCombinedNameString, string itemRarityString, string itemTypeString, string itemRequirementsString,
                    string itemPrefix1String, string itemPrefix2String, string itemPrefix3String, string itemSuffix1String, string itemSuffix2String, string itemSuffix3String,
                    string itemStats1String, string itemStats2String, string itemStats3String, string itemStats4String, string itemStats5String, string itemStats6String,
                    string itemMod1String, string itemMod2String, string itemMod3String, string itemMod4String, string itemMod5String, string itemMod6String)
        {
            this.itemName = itemName;
            this.itemRarity = itemRarity;
            this.itemType = itemType;
            this.itemRequirements = itemRequirements;
            this.itemStat1 = itemStat1;
            this.itemStat2 = itemStat2;
            this.itemStat3 = itemStat3;
            this.itemStat4 = itemStat4;
            this.itemStat5 = itemStat5;
            this.itemStat6 = itemStat6;
            this.itemStatInt1 = itemStatInt1;
            this.itemStatInt2 = itemStatInt2;
            this.itemStatInt3 = itemStatInt3;
            this.itemStatInt4 = itemStatInt4;
            this.itemStatInt5 = itemStatInt5;
            this.itemStatInt6 = itemStatInt6;
            this.itemPrefixs1 = itemPrefixs1;
            this.itemPrefixs2 = itemPrefixs2;
            this.itemPrefixs3 = itemPrefixs3;
            this.itemSuffixs1 = itemSuffixs1;
            this.itemSuffixs2 = itemSuffixs2;
            this.itemSuffixs3 = itemSuffixs3;
            this.itemNameString = itemNameString;
            this.itemCombinedNameString = itemCombinedNameString;
            this.itemRarityString = itemRarityString;
            this.itemTypeString = itemTypeString;
            this.itemRequirementsString = itemRequirementsString;
            this.itemPrefix1String = itemPrefix1String;
            this.itemPrefix2String = itemPrefix2String;
            this.itemPrefix3String = itemPrefix3String;
            this.itemSuffix1String = itemSuffix1String;
            this.itemSuffix2String = itemSuffix2String;
            this.itemSuffix3String = itemSuffix3String;
            this.itemStats1String = itemStats1String;
            this.itemStats2String = itemStats2String;
            this.itemStats3String = itemStats3String;
            this.itemStats4String = itemStats4String;
            this.itemStats5String = itemStats5String;
            this.itemStats6String = itemStats6String;
            ItemGenerator();
        }
        #endregion

        public void ItemGenerator()
        {

            itemName = ItemName.GenerateItemName();
            itemType = ItemTypes.ItemTypeGenerator(itemName);
            itemRarity = ItemRarities.RarityGenerator();
            switch (itemRarity)
            {
                case ItemRarity.COUNTSTART:
                    break;
                case ItemRarity.COMMON:
                    itemCombinedNameString = itemNameString;
                    break;
                case ItemRarity.UNCOMMON:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    break;
                case ItemRarity.RARE:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs1 = ItemAffixs.GenerateSuffixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
                    break;
                case ItemRarity.UNQIUE:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs1 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs2 = ItemAffixs.GeneratePrefixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
                    break;
                case ItemRarity.MASTERWORK:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs1 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs2 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs2 = ItemAffixs.GenerateSuffixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
                    break;
                case ItemRarity.EXOTIC:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs1 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs2 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs2 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs3 = ItemAffixs.GeneratePrefixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
                    break;
                case ItemRarity.LEGENDARY:
                    itemPrefixs1 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs1 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs2 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs2 = ItemAffixs.GenerateSuffixs();
                    itemPrefixs3 = ItemAffixs.GeneratePrefixs();
                    itemSuffixs3 = ItemAffixs.GenerateSuffixs();
                    itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
                    itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
                    break;
                case ItemRarity.COUNTEND:
                    break;
                default:
                    break;
            }
            itemRequirements = ItemRequirements.RequirementsGenerator();
            if ()
            {
                itemStat1 = ItemStatType.AttackSpeed;
                itemStat2 = ItemStatType.CriticalChance;
                itemStat3 = ItemStatType.PhysicalDamage;
                itemStat4 = ItemStatType.MagicalDamage;
                itemStat5 = 0;
                itemStat6 = 0;
                itemStatInt1 = ItemStats.AttackSpeedGenerator(itemRarity, itemType, itemRequirements);
                itemStatInt2 = ItemStats.CriticalChanceGenerator(itemRarity, itemType, itemRequirements);
                itemStatInt3 = ItemStats.MagicalDamageGenerator(itemRarity, itemType, itemRequirements);
                itemStatInt4 = ItemStats.PhysicalDamageGenerator(itemRarity, itemType, itemRequirements);
                itemStatInt5 = 0;
                itemStatInt6 = 0;
                itemStats1String = ConvertString.AttackSpeedGenerator(itemStatInt1);
                itemStats2String = ConvertString.CriticalChanceGenerator(itemStatInt2);
                itemStats3String = ConvertString.PhysicalDamageGenerator(itemStatInt3);
                itemStats4String = ConvertString.AttackSpeedGenerator(itemStatInt4);
                itemStats5String = "";
                itemStats6String = "";
            }
            itemNameString = ConvertString.StringConvertItemName(itemName);
            itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
            itemRarityString = ConvertString.RarityGeneratorString(itemRarity);
            itemTypeString = ConvertString.ItemTypeString(itemType);
            itemRequirementsString = ConvertString.RequirementsStringConvertor(itemRequirements);
        }
    }
}
