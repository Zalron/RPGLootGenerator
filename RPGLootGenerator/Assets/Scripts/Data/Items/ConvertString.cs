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
        public static string ConvertStringOneHandedWarhammer(OneHandedWarhammersNames oneHandedWarhammer)
        {
            string OneHandedWarhammersNamesString;
            switch (oneHandedWarhammer)
            {
                case OneHandedWarhammersNames.ClawedPick:
                    OneHandedWarhammersNamesString = "Clawed Pick";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.DoubleHeader:
                    OneHandedWarhammersNamesString = "Double Header";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.SkullSinger:
                    OneHandedWarhammersNamesString = "Skull Singer";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.StoneBreaker:
                    OneHandedWarhammersNamesString = "Stone Breaker";
                    return OneHandedWarhammersNamesString;
                default:
                    return "ERROR";
            }
        }
        public static string ConvertStringShortSword(ShortSwordNames shortSwordNames)
        {
            string ShortSwordNamesString;
            switch (shortSwordNames)
            {
                case ShortSwordNames.BronzeKopis:
                    ShortSwordNamesString = "Bronze Kopis";
                    return ShortSwordNamesString;
                case ShortSwordNames.DustKhopesh:
                    ShortSwordNamesString = "Dust Khopesh";
                    return ShortSwordNamesString;
                case ShortSwordNames.ObsidianMaquahuitl:
                    ShortSwordNamesString = "Obsidian Maquahuitl";
                    return ShortSwordNamesString;
                case ShortSwordNames.SteelGladius:
                    ShortSwordNamesString = "Steel Gladius";
                    return ShortSwordNamesString;
                default:
                    return "ERROR";
            }
        }
        public static string ConvertStringOneHandedMaces(OneHandedMacesNames oneHandedMacesNames)
        {
            string OneHandedMacesNamesString = null;
            switch (oneHandedMacesNames)
            {
                case OneHandedMacesNames.EnergyCorrector:
                    OneHandedMacesNamesString = "Energy Corrector";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.BlackJack:
                    OneHandedMacesNamesString = "Black Jack";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.MorningStar:
                    OneHandedMacesNamesString = "Morning Star";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.IronTeeth:
                    OneHandedMacesNamesString = "Iron Teeth";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.BedeckedShishpar:
                    OneHandedMacesNamesString = "Bedecked Shishpar";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.NightGada:
                    OneHandedMacesNamesString = "Night Gada";
                    return OneHandedMacesNamesString;
                default:
                    return "ERROR";
            }
        }
    }
}
