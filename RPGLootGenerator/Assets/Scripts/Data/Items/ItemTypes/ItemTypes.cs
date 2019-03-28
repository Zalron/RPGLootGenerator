using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ItemTypes
    {
        public enum ItemType
        {
            //one handed melee
            SHORTSWORD,
            ONEHANDEDMACE,
            KNIFE,
            ONEHANDEDWARHAMMERS,
            ONEHANDEDAXE,
            SHIELD,
            RAPIER,
            ONEHANDEDCLUB,
            //Two handed melee
            LONGSWORD,
            GREATSWORD,
            TWOHANDEDMACE,
            TWOHANDEDWARHAMMER,
            HALBERD,
            TWOHANDEDAXE,
            TWOHANDEDCLUB,
            STAFF,
            SPEAR,
            CLAWS,
            //One handed ranged
            WAND,
            THROWINGKNIFES,
            THROWINGAXES,
            PISTOL,
            HANDCROSSBOW,
            //Two handed ranged
            BOW,
            CROSSBOW,
            MATCHLOCKRIFLE,
            CARBINE,
            BULLPUP,
            ASSAULTRIFLE,
            SNIPERRIFLE,
            MACHINEGUN,
            SHOTGUN,
            GRENADELAUNCHER,
            ROCKETLAUNCHER,
        }
        static ItemType itemType;
        public static string ItemTypeGenerator()
        {
            string ItemTypeString = null;
            itemType = (ItemType)Random.Range(0, System.Enum.GetValues(typeof(ItemType)).Length);
            switch (itemType)
            {
                //One handed melee
                case ItemType.ONEHANDEDMACE:
                    ItemTypeString = "One Handed Mace";
                    return ItemTypeString;
                case ItemType.ONEHANDEDAXE:
                    ItemTypeString = "One Handed Axe";
                    return ItemTypeString;
                case ItemType.ONEHANDEDWARHAMMERS:
                    ItemTypeString = "One Handed Warhammer";
                    return ItemTypeString;
                case ItemType.KNIFE:
                    ItemTypeString = "Knife";
                    return ItemTypeString;
                case ItemType.ONEHANDEDCLUB:
                    ItemTypeString = "One Handed Club";
                    return ItemTypeString;
                case ItemType.RAPIER:
                    ItemTypeString = "Rapier";
                    return ItemTypeString;
                case ItemType.SHIELD:
                    ItemTypeString = "Shield";
                    return ItemTypeString;
                case ItemType.SHORTSWORD:
                    ItemTypeString = "Short Swords";
                    return ItemTypeString;
                //Two handed melee
                case ItemType.TWOHANDEDMACE:
                    ItemTypeString = "Two Handed Mace";
                    return ItemTypeString;
                case ItemType.TWOHANDEDAXE:
                    ItemTypeString = "Two Handed Axes";
                    return ItemTypeString;
                case ItemType.TWOHANDEDCLUB:
                    ItemTypeString = "Two Handed Club";
                    return ItemTypeString;
                case ItemType.TWOHANDEDWARHAMMER:
                    ItemTypeString = "Two Handed Warhammer";
                    return ItemTypeString;
                case ItemType.STAFF:
                    ItemTypeString = "Staff";
                    return ItemTypeString;
                case ItemType.SPEAR:
                    ItemTypeString = "Spear";
                    return ItemTypeString;
                case ItemType.LONGSWORD:
                    ItemTypeString = "Long Sword";
                    return ItemTypeString;
                case ItemType.GREATSWORD:
                    ItemTypeString = "Great Sword";
                    return ItemTypeString;
                //One Handed Ranged 
                case ItemType.HANDCROSSBOW:
                    ItemTypeString = "Hand Crossbow";
                    return ItemTypeString;
                case ItemType.PISTOL:
                    ItemTypeString = "Pistol";
                    return ItemTypeString;
                case ItemType.THROWINGAXES:
                    ItemTypeString = "Throwing Axes";
                    return ItemTypeString;
                case ItemType.THROWINGKNIFES:
                    ItemTypeString = "Throwing Knifes";
                    return ItemTypeString;
                case ItemType.WAND:
                    ItemTypeString = "Wand";
                    return ItemTypeString;
                //Two Handed Ranged
                case ItemType.ASSAULTRIFLE:
                    ItemTypeString = "";
                    return ItemTypeString;
                default:
                    return "Error";
            }
        }
    }
}
