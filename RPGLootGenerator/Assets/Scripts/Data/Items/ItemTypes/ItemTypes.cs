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
            //two handed melee
            LONGSWORD,
            TWOHANDEDMACE,
            TWOHANDEDWARHAMMER,
            HALBERD,
            TWOHANDEDAXE,
            TWOHANDEDCLUB,
            STAFF,
            SPEAR,
            CLAWS,
            //one handed ranged
            WAND,
            THROWINGKNIFES,
            THROWINGAXES,
            PISTOL,
            HANDCROSSBOW,
            // two handed ranged
            BOW,
            CROSSBOW,
            MATCHlockRifle,
                     Carbine,
                     Bullpup,
                     AssaultRifle,
                     SniperRifle,
                     MachineGun,
                     Shotgun,
                     GrenadeLauncher,
                     RocketLauncher,


        }
        static ItemType itemType;
        public static string ItemTypeGenerator()
        {
            string ItemTypeString = null;
            switch (itemType) 
            {
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
                case ItemType.HALBERD:
                    ItemTypeString = "Halberd";
                    return ItemTypeString;
                case ItemType.CLAWS:
                    ItemTypeString = "Claws";
                    return ItemTypeString;
                default:
                    return "ERROR";
            }
        }
    }
}
