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
        public static string StringConvertItemName(ItemTypeName itemTypeName)
        {
            string itemTypeNameString;
            switch (itemTypeName)
            {
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR:
                    itemTypeNameString = "Energy Corrector";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK:
                    itemTypeNameString = "Black Jack";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR:
                    itemTypeNameString = "Morning Star";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH:
                    itemTypeNameString = "Iron Teeth";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR:
                    itemTypeNameString = "Bedecked Shishpar";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA:
                    itemTypeNameString = "Night Gada";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK:
                    itemTypeNameString = "Clawed Pick";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER:
                    itemTypeNameString = "Double Header";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER:
                    itemTypeNameString = "Skull Singer";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER:
                    itemTypeNameString = "Stone Breaker";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_WETKOPIS:
                    itemTypeNameString = "Wet Kopis";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH:
                    itemTypeNameString = "Dust Khopesh";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL:
                    itemTypeNameString = "Obsidian Maquahuitl";
                    return itemTypeNameString;
                case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS:
                    itemTypeNameString = "Steel Gladius";
                    return itemTypeNameString;
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
        public static string RequirementsStringConvertor(Requirements requirements)
        {
            string ItemRequirementsString;
            switch (requirements)
            {
                case Requirements.Lvl_1:
                    ItemRequirementsString = "Level 1";
                    return ItemRequirementsString;
                case Requirements.Lvl_2:
                    ItemRequirementsString = "Level 2";
                    return ItemRequirementsString;
                case Requirements.Lvl_3:
                    ItemRequirementsString = "Level 3";
                    return ItemRequirementsString;
                case Requirements.Lvl_4:
                    ItemRequirementsString = "Level 4";
                    return ItemRequirementsString;
                case Requirements.Lvl_5:
                    ItemRequirementsString = "Level 5";
                    return ItemRequirementsString;
                case Requirements.Lvl_6:
                    ItemRequirementsString = "Level 6";
                    return ItemRequirementsString;
                case Requirements.Lvl_7:
                    ItemRequirementsString = "Level 7";
                    return ItemRequirementsString;
                case Requirements.Lvl_8:
                    ItemRequirementsString = "Level 8";
                    return ItemRequirementsString;
                case Requirements.Lvl_9:
                    ItemRequirementsString = "Level 9";
                    return ItemRequirementsString;
                case Requirements.Lvl_10:
                    ItemRequirementsString = "Level 10";
                    return ItemRequirementsString;
                case Requirements.Lvl_11:
                    ItemRequirementsString = "Level 11";
                    return ItemRequirementsString;
                case Requirements.Lvl_12:
                    ItemRequirementsString = "Level 12";
                    return ItemRequirementsString;
                case Requirements.Lvl_13:
                    ItemRequirementsString = "Level 13";
                    return ItemRequirementsString;
                case Requirements.Lvl_14:
                    ItemRequirementsString = "Level 14";
                    return ItemRequirementsString;
                case Requirements.Lvl_15:
                    ItemRequirementsString = "Level 15";
                    return ItemRequirementsString;
                case Requirements.Lvl_16:
                    ItemRequirementsString = "Level 16";
                    return ItemRequirementsString;
                case Requirements.Lvl_17:
                    ItemRequirementsString = "Level 17";
                    return ItemRequirementsString;
                case Requirements.Lvl_18:
                    ItemRequirementsString = "Level 18";
                    return ItemRequirementsString;
                case Requirements.Lvl_19:
                    ItemRequirementsString = "Level 19";
                    return ItemRequirementsString;
                case Requirements.Lvl_20:
                    ItemRequirementsString = "Level 20";
                    return ItemRequirementsString;
                case Requirements.Lvl_21:
                    ItemRequirementsString = "Level 21";
                    return ItemRequirementsString;
                case Requirements.Lvl_22:
                    ItemRequirementsString = "Level 22";
                    return ItemRequirementsString;
                case Requirements.Lvl_23:
                    ItemRequirementsString = "Level 23";
                    return ItemRequirementsString;
                case Requirements.Lvl_24:
                    ItemRequirementsString = "Level 24";
                    return ItemRequirementsString;
                case Requirements.Lvl_25:
                    ItemRequirementsString = "Level 25";
                    return ItemRequirementsString;
                case Requirements.Lvl_26:
                    ItemRequirementsString = "Level 26";
                    return ItemRequirementsString;
                case Requirements.Lvl_27:
                    ItemRequirementsString = "Level 27";
                    return ItemRequirementsString;
                case Requirements.Lvl_28:
                    ItemRequirementsString = "Level 28";
                    return ItemRequirementsString;
                case Requirements.Lvl_29:
                    ItemRequirementsString = "Level 29";
                    return ItemRequirementsString;
                case Requirements.Lvl_30:
                    ItemRequirementsString = "Level 30";
                    return ItemRequirementsString;
                case Requirements.Lvl_31:
                    ItemRequirementsString = "Level 31";
                    return ItemRequirementsString;
                case Requirements.Lvl_32:
                    ItemRequirementsString = "Level 32";
                    return ItemRequirementsString;
                case Requirements.Lvl_33:
                    ItemRequirementsString = "Level 33";
                    return ItemRequirementsString;
                case Requirements.Lvl_34:
                    ItemRequirementsString = "Level 34";
                    return ItemRequirementsString;
                case Requirements.Lvl_35:
                    ItemRequirementsString = "Level 35";
                    return ItemRequirementsString;
                case Requirements.Lvl_36:
                    ItemRequirementsString = "Level 36";
                    return ItemRequirementsString;
                case Requirements.Lvl_37:
                    ItemRequirementsString = "Level 37";
                    return ItemRequirementsString;
                case Requirements.Lvl_38:
                    ItemRequirementsString = "Level 38";
                    return ItemRequirementsString;
                case Requirements.Lvl_39:
                    ItemRequirementsString = "Level 39";
                    return ItemRequirementsString;
                case Requirements.Lvl_40:
                    ItemRequirementsString = "Level 40";
                    return ItemRequirementsString;
                case Requirements.Lvl_41:
                    ItemRequirementsString = "Level 41";
                    return ItemRequirementsString;
                case Requirements.Lvl_42:
                    ItemRequirementsString = "Level 42";
                    return ItemRequirementsString;
                case Requirements.Lvl_43:
                    ItemRequirementsString = "Level 43";
                    return ItemRequirementsString;
                case Requirements.Lvl_44:
                    ItemRequirementsString = "Level 44";
                    return ItemRequirementsString;
                case Requirements.Lvl_45:
                    ItemRequirementsString = "Level 45";
                    return ItemRequirementsString;
                case Requirements.Lvl_46:
                    ItemRequirementsString = "Level 46";
                    return ItemRequirementsString;
                case Requirements.Lvl_47:
                    ItemRequirementsString = "Level 47";
                    return ItemRequirementsString;
                case Requirements.Lvl_48:
                    ItemRequirementsString = "Level 48";
                    return ItemRequirementsString;
                case Requirements.Lvl_49:
                    ItemRequirementsString = "Level 49";
                    return ItemRequirementsString;
                case Requirements.Lvl_50:
                    ItemRequirementsString = "Level 50";
                    return ItemRequirementsString;
                case Requirements.Lvl_51:
                    ItemRequirementsString = "Level 51";
                    return ItemRequirementsString;
                case Requirements.Lvl_52:
                    ItemRequirementsString = "Level 52";
                    return ItemRequirementsString;
                case Requirements.Lvl_53:
                    ItemRequirementsString = "Level 53";
                    return ItemRequirementsString;
                case Requirements.Lvl_54:
                    ItemRequirementsString = "Level 54";
                    return ItemRequirementsString;
                case Requirements.Lvl_55:
                    ItemRequirementsString = "Level 55";
                    return ItemRequirementsString;
                case Requirements.Lvl_56:
                    ItemRequirementsString = "Level 56";
                    return ItemRequirementsString;
                case Requirements.Lvl_57:
                    ItemRequirementsString = "Level 57";
                    return ItemRequirementsString;
                case Requirements.Lvl_58:
                    ItemRequirementsString = "Level 58";
                    return ItemRequirementsString;
                case Requirements.Lvl_59:
                    ItemRequirementsString = "Level 59";
                    return ItemRequirementsString;
                case Requirements.Lvl_60:
                    ItemRequirementsString = "Level 60";
                    return ItemRequirementsString;
                case Requirements.Lvl_61:
                    ItemRequirementsString = "Level 61";
                    return ItemRequirementsString;
                case Requirements.Lvl_62:
                    ItemRequirementsString = "Level 62";
                    return ItemRequirementsString;
                case Requirements.Lvl_63:
                    ItemRequirementsString = "Level 63";
                    return ItemRequirementsString;
                case Requirements.Lvl_64:
                    ItemRequirementsString = "Level 64";
                    return ItemRequirementsString;
                case Requirements.Lvl_65:
                    ItemRequirementsString = "Level 65";
                    return ItemRequirementsString;
                case Requirements.Lvl_66:
                    ItemRequirementsString = "Level 66";
                    return ItemRequirementsString;
                case Requirements.Lvl_67:
                    ItemRequirementsString = "Level 67";
                    return ItemRequirementsString;
                case Requirements.Lvl_68:
                    ItemRequirementsString = "Level 68";
                    return ItemRequirementsString;
                case Requirements.Lvl_69:
                    ItemRequirementsString = "Level 69";
                    return ItemRequirementsString;
                case Requirements.Lvl_70:
                    ItemRequirementsString = "Level 70";
                    return ItemRequirementsString;
                case Requirements.Lvl_71:
                    ItemRequirementsString = "Level 71";
                    return ItemRequirementsString;
                case Requirements.Lvl_72:
                    ItemRequirementsString = "Level 72";
                    return ItemRequirementsString;
                case Requirements.Lvl_73:
                    ItemRequirementsString = "Level 73";
                    return ItemRequirementsString;
                case Requirements.Lvl_74:
                    ItemRequirementsString = "Level 74";
                    return ItemRequirementsString;
                case Requirements.Lvl_75:
                    ItemRequirementsString = "Level 75";
                    return ItemRequirementsString;
                case Requirements.Lvl_76:
                    ItemRequirementsString = "Level 76";
                    return ItemRequirementsString;
                case Requirements.Lvl_77:
                    ItemRequirementsString = "Level 77";
                    return ItemRequirementsString;
                case Requirements.Lvl_78:
                    ItemRequirementsString = "Level 78";
                    return ItemRequirementsString;
                case Requirements.Lvl_79:
                    ItemRequirementsString = "Level 79";
                    return ItemRequirementsString;
                case Requirements.Lvl_80:
                    ItemRequirementsString = "Level 80";
                    return ItemRequirementsString;
                case Requirements.Lvl_81:
                    ItemRequirementsString = "Level 81";
                    return ItemRequirementsString;
                case Requirements.Lvl_82:
                    ItemRequirementsString = "Level 82";
                    return ItemRequirementsString;
                case Requirements.Lvl_83:
                    ItemRequirementsString = "Level 83";
                    return ItemRequirementsString;
                case Requirements.Lvl_84:
                    ItemRequirementsString = "Level 84";
                    return ItemRequirementsString;
                case Requirements.Lvl_85:
                    ItemRequirementsString = "Level 85";
                    return ItemRequirementsString;
                case Requirements.Lvl_86:
                    ItemRequirementsString = "Level 86";
                    return ItemRequirementsString;
                case Requirements.Lvl_87:
                    ItemRequirementsString = "Level 87";
                    return ItemRequirementsString;
                case Requirements.Lvl_88:
                    ItemRequirementsString = "Level 88";
                    return ItemRequirementsString;
                case Requirements.Lvl_89:
                    ItemRequirementsString = "Level 89";
                    return ItemRequirementsString;
                case Requirements.Lvl_90:
                    ItemRequirementsString = "Level 90";
                    return ItemRequirementsString;
                case Requirements.Lvl_91:
                    ItemRequirementsString = "Level 91";
                    return ItemRequirementsString;
                case Requirements.Lvl_92:
                    ItemRequirementsString = "Level 92";
                    return ItemRequirementsString;
                case Requirements.Lvl_93:
                    ItemRequirementsString = "Level 93";
                    return ItemRequirementsString;
                case Requirements.Lvl_94:
                    ItemRequirementsString = "Level 94";
                    return ItemRequirementsString;
                case Requirements.Lvl_95:
                    ItemRequirementsString = "Level 95";
                    return ItemRequirementsString;
                case Requirements.Lvl_96:
                    ItemRequirementsString = "Level 96";
                    return ItemRequirementsString;
                case Requirements.Lvl_97:
                    ItemRequirementsString = "Level 97";
                    return ItemRequirementsString;
                case Requirements.Lvl_98:
                    ItemRequirementsString = "Level 98";
                    return ItemRequirementsString;
                case Requirements.Lvl_99:
                    ItemRequirementsString = "Level 99";
                    return ItemRequirementsString;
                case Requirements.Lvl_100:
                    ItemRequirementsString = "Level 100";
                    return ItemRequirementsString;
                default:
                    ItemRequirementsString = "ERROR";
                    return ItemRequirementsString;
            }
        }
    }
}
