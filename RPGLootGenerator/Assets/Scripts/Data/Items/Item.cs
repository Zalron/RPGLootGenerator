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
                    int itemStatInt1, int itemStatInt2, int itemStatInt3, int itemStatInt4, int itemStatInt5, int itemStatInt6)
        {
            this.itemName = itemName;
            this.itemRarity = itemRarity;
            this.itemType = itemType;
            this.itemRequirements = itemRequirements;
            this.itemStat1 = itemStat1;
            this.itemStat1 = itemStat2;
            this.itemStat1 = itemStat3;
            this.itemStat1 = itemStat4;
            this.itemStat1 = itemStat5;
            this.itemStat1 = itemStat6;
            this.itemStatInt1 = itemStatInt1;
            this.itemStatInt2 = itemStatInt2;
            this.itemStatInt3 = itemStatInt3;
            this.itemStatInt4 = itemStatInt4;
            this.itemStatInt5 = itemStatInt5;
            this.itemStatInt6 = itemStatInt6;
        }
        #endregion

        public void ItemGenerator()
        {
            itemName = ItemName.GenerateItemName();
            if (itemName == ItemTypeName.ITEM_COUNTSTART)
            {
                itemName = ItemName.GenerateItemName();
            }
            itemRarity = ItemRarities.RarityGenerator();
            switch (itemRarity)
            {
                case ItemRarity.COUNTSTART:
                    break;
                case ItemRarity.COMMON:
                    itemCombinedNameString = itemNameString;
                    break;
                case ItemRarity.UNCOMMON:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = "";
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.RARE:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = ConvertString.ConvertStringSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.UNQIUE:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemPrefix2String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = ConvertString.ConvertStringSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.MASTERWORK:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemPrefix2String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = ConvertString.ConvertStringSuffixs();
                    itemSuffix2String = ConvertString.ConvertStringSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.EXOTIC:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemPrefix2String = ConvertString.ConvertStringPrefixs();
                    itemPrefix3String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = ConvertString.ConvertStringSuffixs();
                    itemSuffix2String = ConvertString.ConvertStringSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.LEGENDARY:
                    itemPrefix1String = ConvertString.ConvertStringPrefixs();
                    itemPrefix2String = ConvertString.ConvertStringPrefixs();
                    itemPrefix3String = ConvertString.ConvertStringPrefixs();
                    itemSuffix1String = ConvertString.ConvertStringSuffixs();
                    itemSuffix2String = ConvertString.ConvertStringSuffixs();
                    itemSuffix3String = ConvertString.ConvertStringSuffixs();
                    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
                    break;
                case ItemRarity.COUNTEND:
                    break;
                default:
                    break;
            }
            itemType = ItemTypes.ItemTypeGenerator(itemName);
            itemRequirements = ItemRequirements.RequirementsGenerator();
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_KNIFE ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SHIELD ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_RAPIER ||
                itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_CLUB ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_SWORD ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_WARHAMMER ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_HALBERD ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_AXE ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_CLUB ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_STAFF ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_SPEAR ||
                itemType == ItemType.ITEM_WEAPON_MELEE_TWOHANDED_CLAWS)
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
            }
        }
    }
}
