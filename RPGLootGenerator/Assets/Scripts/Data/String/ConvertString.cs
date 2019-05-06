using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ConvertString
    {
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
        public static string ItemTypeString(ItemType itemTypes)
        {
            string ItemTypeString;
            switch(itemTypes)
            {
                case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE:
                    ItemTypeString = "One Handed Axe";
                    return ItemTypeString;
                case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE:
                    ItemTypeString = "One Handed Mace";
                    return ItemTypeString;
                case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER:
                    ItemTypeString = "One Handed Warhammer";
                    return ItemTypeString;
                case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_KNIFE:
                    ItemTypeString = "One Handed Knife";
                    return ItemTypeString;
                case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD:
                    ItemTypeString = "One Handed Sword";
                    return ItemTypeString;
            }
            return "ERROR";
        }
        public static string RarityGeneratorString(Rarity rarity)
        {
            string ItemRarityString;
            switch (rarity)
            {
                case Rarity.COMMON:
                    ItemRarityString = "Common";
                    return ItemRarityString;
                case Rarity.UNCOMMON:
                    ItemRarityString = "Uncommon";
                    return ItemRarityString;
                case Rarity.RARE:
                    ItemRarityString = "Rare";
                    return ItemRarityString;
                case Rarity.MASTERWORK:
                    ItemRarityString = "Masterwork";
                    return ItemRarityString;
                case Rarity.LEGENDARY:
                    ItemRarityString = "Legendary";
                    return ItemRarityString;
                case Rarity.UNQIUE:
                    ItemRarityString = "Unqiue";
                    return ItemRarityString;
                default:
                    ItemRarityString = "ERROR";
                    return ItemRarityString;
            }
        }
        public static string ConvertStringOneHandedWarhammer(ItemTypeName oneHandedWarhammer)
        {
            string OneHandedWarhammersNamesString;
            switch (oneHandedWarhammer)
            {
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK:
                    OneHandedWarhammersNamesString = "Clawed Pick";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER:
                    OneHandedWarhammersNamesString = "Double Header";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER:
                    OneHandedWarhammersNamesString = "Skull Singer";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER:
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
            string OneHandedMacesNamesString;
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
        public static string AttackSpeedGenerator(int AttackSpeedInt)
        {
            string AttackSpeedString;
            AttackSpeedString = "Attack Speed " + AttackSpeedInt;
            return AttackSpeedString;
        }
        public static string CriticalChanceGenerator(int CriticalChanceInt)
        {
            string CriticalChanceString;
            CriticalChanceString = "Critical Chance " + CriticalChanceInt + "%";
            return CriticalChanceString;
        }
        public static string PhysicalDamageGenerator(int PhysicalDamageMin, int PhysicalDamageMax)
        {
            string PhysicalDamageString;
            PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
            return PhysicalDamageString;
        }
        public static string MagicalDamageStringConverter(int MagicalDamageMin, int MagicalDamageMax)
        {
            string MagicalDamageString;
            MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
            return MagicalDamageString;
        }
    }
}
