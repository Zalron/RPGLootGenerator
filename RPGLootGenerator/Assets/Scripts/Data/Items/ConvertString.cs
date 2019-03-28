using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace RPGLootGenerator
{
    public static class ConvertString
    {
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
        public static string ItemTypeGenerator(ItemTypes.ItemType itemType)
        {
            string ItemTypeString = null;
            switch (itemType)
            {
                //One handed melee
                case ItemTypes.ItemType.ONEHANDEDMACE:
                    ItemTypeString = "One Handed Mace";
                    return ItemTypeString;
                case ItemTypes.ItemType.ONEHANDEDAXE:
                    ItemTypeString = "One Handed Axe";
                    return ItemTypeString;
                case ItemTypes.ItemType.ONEHANDEDWARHAMMERS:
                    ItemTypeString = "One Handed Warhammer";
                    return ItemTypeString;
                case ItemTypes.ItemType.KNIFE:
                    ItemTypeString = "Knife";
                    return ItemTypeString;
                case ItemTypes.ItemType.ONEHANDEDCLUB:
                    ItemTypeString = "One Handed Club";
                    return ItemTypeString;
                case ItemTypes.ItemType.RAPIER:
                    ItemTypeString = "Rapier";
                    return ItemTypeString;
                case ItemTypes.ItemType.SHIELD:
                    ItemTypeString = "Shield";
                    return ItemTypeString;
                case ItemTypes.ItemType.SHORTSWORD:
                    ItemTypeString = "Short Swords";
                    return ItemTypeString;
                //Two handed melee
                case ItemTypes.ItemType.TWOHANDEDMACE:
                    ItemTypeString = "Two Handed Mace";
                    return ItemTypeString;
                case ItemTypes.ItemType.TWOHANDEDAXE:
                    ItemTypeString = "Two Handed Axes";
                    return ItemTypeString;
                case ItemTypes.ItemType.TWOHANDEDCLUB:
                    ItemTypeString = "Two Handed Club";
                    return ItemTypeString;
                case ItemTypes.ItemType.TWOHANDEDWARHAMMER:
                    ItemTypeString = "Two Handed Warhammer";
                    return ItemTypeString;
                case ItemTypes.ItemType.STAFF:
                    ItemTypeString = "Staff";
                    return ItemTypeString;
                case ItemTypes.ItemType.SPEAR:
                    ItemTypeString = "Spear";
                    return ItemTypeString;
                case ItemTypes.ItemType.LONGSWORD:
                    ItemTypeString = "Long Sword";
                    return ItemTypeString;
                case ItemTypes.ItemType.GREATSWORD:
                    ItemTypeString = "Great Sword";
                    return ItemTypeString;
                default:
                    return "Error";
            }
        }
        public static string ConvertStringOneHandedWarhammer(OneHandedWarhammers.OneHandedWarhammersNames oneHandedWarhammer)
        {
            string OneHandedWarhammersNamesString;
            switch (oneHandedWarhammer)
            {
                case OneHandedWarhammers.OneHandedWarhammersNames.ClawedPick:
                    OneHandedWarhammersNamesString = "Clawed Pick";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammers.OneHandedWarhammersNames.DoubleHeader:
                    OneHandedWarhammersNamesString = "Double Header";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammers.OneHandedWarhammersNames.SkullSinger:
                    OneHandedWarhammersNamesString = "Skull Singer";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammers.OneHandedWarhammersNames.StoneBreaker:
                    OneHandedWarhammersNamesString = "Stone Breaker";
                    return OneHandedWarhammersNamesString;
                default:
                    return "ERROR";
            }
        }
        public static string ConvertStringShortSword(ShortSword.ShortSwordNames shortSwordNames)
        {
            string ShortSwordNamesString;
            switch (shortSwordNames)
            {
                case ShortSword.ShortSwordNames.BronzeKopis:
                    ShortSwordNamesString = "Bronze Kopis";
                    return ShortSwordNamesString;
                case ShortSword.ShortSwordNames.DustKhopesh:
                    ShortSwordNamesString = "Dust Khopesh";
                    return ShortSwordNamesString;
                case ShortSword.ShortSwordNames.ObsidianMaquahuitl:
                    ShortSwordNamesString = "Obsidian Maquahuitl";
                    return ShortSwordNamesString;
                case ShortSword.ShortSwordNames.SteelGladius:
                    ShortSwordNamesString = "Steel Gladius";
                    return ShortSwordNamesString;
                default:
                    return "ERROR";
            }
        }
    }
}
