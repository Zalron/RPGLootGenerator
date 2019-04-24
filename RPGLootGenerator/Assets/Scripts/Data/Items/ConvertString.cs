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
        public static string ItemTypeGenerator(ItemTypeName itemTypes)
        {
            string ItemTypeString = null;
            if (itemTypes == ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_BLOODCLEAVER ||
                itemTypes == ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_VIKINGAXE ||
                itemTypes == ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_WOODEDAXE ||
                itemTypes == ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_BONEHACHET ||
                itemTypes == ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_BLOODCLEAVER) 
            {
                return ItemTypeString; 
            }
            return "ERROR";
        }
        public static string RarityGenerator(/*string ItemRarity*/)
        {
            string ItemRarityString = null;
            Rarities rarity;
            rarity = (Rarities)Random.Range(0, System.Enum.GetValues(typeof(Rarities)).Length);
            switch (rarity)
            {
                case Rarities.COMMON:
                    ItemRarityString = "Common";
                    return ItemRarityString;
                case Rarities.UNCOMMON:
                    ItemRarityString = "Uncommon";
                    return ItemRarityString;
                case Rarities.RARE:
                    ItemRarityString = "Rare";
                    return ItemRarityString;
                case Rarities.MASTERWORK:
                    ItemRarityString = "Masterwork";
                    return ItemRarityString;
                case Rarities.LEGENDARY:
                    ItemRarityString = "Legendary";
                    return ItemRarityString;
                case Rarities.UNQIUE:
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
                case ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_CLAWEDPICK:
                    OneHandedWarhammersNamesString = "Clawed Pick";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_DOUBLEHEADER:
                    OneHandedWarhammersNamesString = "Double Header";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_SKULLSINGER:
                    OneHandedWarhammersNamesString = "Skull Singer";
                    return OneHandedWarhammersNamesString;
                case ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_STONEBREAKER:
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
        public static string AttackSpeedGenerator(string itemRarity)
        {
            int AttackSpeedMin;
            string AttackSpeedString;
            if (itemRarity == "Common")
            {
                AttackSpeedMin = Random.Range(10, 13);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Uncommon")
            {
                AttackSpeedMin = Random.Range(8, 11);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                AttackSpeedMin = Random.Range(6, 9);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Masterwork")
            {
                AttackSpeedMin = Random.Range(8, 5);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Legendary")
            {
                AttackSpeedMin = Random.Range(5, 3);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Unqiue")
            {
                AttackSpeedMin = Random.Range(3, 13);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            return "ERROR";
        }
        public static string CriticalChanceGenerator(string itemRarity)
        {
            int CriticalChance;
            string CriticalChanceString;
            if (itemRarity == "Common")
            {
                CriticalChance = Random.Range(1, 5);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Uncommon")
            {
                CriticalChance = Random.Range(4, 8);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Rare")
            {
                CriticalChance = Random.Range(7, 12);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Masterwork")
            {
                CriticalChance = Random.Range(11, 16);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Legendary")
            {
                CriticalChance = Random.Range(1, 3);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Unqiue")
            {
                CriticalChance = Random.Range(1, 13);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            return "ERROR";
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
