using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ItemTypes
    {
        public enum OneHandedMelee
        {
            SHORTSWORD,
            ONEHANDEDMACE,
            KNIFE,
            ONEHANDEDWARHAMMERS,
            ONEHANDEDAXE,
            SHIELD,
            RAPIER,
            ONEHANDEDCLUB,
        }
        public enum TwoHandedMelee
        {
            LONGSWORD,
            TWOHANDEDMACE,
            TWOHANDEDWARHAMMER,
            HALBERD,
            TWOHANDEDAXE,
            TWOHANDEDCLUB,
            STAFF,
            SPEAR,
            CLAWS,
        }
        public enum OneHandedRanged
        {
            WAND,
            THROWINGKNIFES,
            THROWINGAXES,
            PISTOL,
            HANDCROSSBOW,
        }
        public enum TwoHandedRanged
        {
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
        static OneHandedMelee oneHandedMelee;
        static TwoHandedMelee twoHandedMelee;
        static OneHandedRanged oneHandedRanged;
        static TwoHandedRanged twoHandedRanged;
        public static string ItemTypeGenerator()
        {
            string ItemTypeString = null;
            int itemTypeGeneratorInt = Random.Range(1, 5);
            if (itemTypeGeneratorInt == 1)
            {
                oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
                switch (oneHandedMelee)
                {
                    case OneHandedMelee.ONEHANDEDMACE:
                        ItemTypeString = "One Handed Mace";
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDAXE:
                        ItemTypeString = "One Handed Axe";
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDWARHAMMERS:
                        ItemTypeString = "One Handed Warhammer";
                        return ItemTypeString;
                    case OneHandedMelee.KNIFE:
                        ItemTypeString = "Knife";
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDCLUB:
                        ItemTypeString = "One Handed Club";
                        return ItemTypeString;
                    case OneHandedMelee.RAPIER:
                        ItemTypeString = "Rapier";
                        return ItemTypeString;
                    case OneHandedMelee.SHIELD:
                        ItemTypeString = "Shield";
                        return ItemTypeString;
                    case OneHandedMelee.SHORTSWORD:
                        ItemTypeString = "Short Swords";
                        return ItemTypeString;
                    default:
                        return "Not Done Yet";
                }
            }
            else if (itemTypeGeneratorInt == 2)
            {
                twoHandedMelee = (TwoHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedMelee)).Length);
                switch (twoHandedMelee)
                {
                    case TwoHandedMelee.TWOHANDEDMACE:
                        ItemTypeString = "Two Handed Mace";
                        return ItemTypeString;
                    case TwoHandedMelee.TWOHANDEDAXE:
                        ItemTypeString = "Two Handed Axes";
                        return ItemTypeString;
                    case TwoHandedMelee.TWOHANDEDCLUB:
                        ItemTypeString = "Two Handed Club";
                        return ItemTypeString;
                    case TwoHandedMelee.TWOHANDEDWARHAMMER:
                        ItemTypeString = "Two Handed Warhammer";
                        return ItemTypeString;
                    case TwoHandedMelee.STAFF:
                        ItemTypeString = "Staff";
                        return ItemTypeString;
                    case TwoHandedMelee.SPEAR:
                        ItemTypeString = "Spear";
                        return ItemTypeString;
                    case TwoHandedMelee.LONGSWORD:
                        ItemTypeString = "Long Sword";
                        return ItemTypeString;
                    case TwoHandedMelee.HALBERD:
                        ItemTypeString = "Halberd";
                        return ItemTypeString;
                    case TwoHandedMelee.CLAWS:
                        ItemTypeString = "Claws";
                        return ItemTypeString;
                    default:
                        return "Not Done Yet";
                }
            }
            else if (itemTypeGeneratorInt == 3)
            {
                oneHandedRanged = (OneHandedRanged)Random.Range(0, System.Enum.GetValues(typeof(OneHandedRanged)).Length);
                switch (oneHandedRanged)
                {
                    case OneHandedRanged.HANDCROSSBOW:
                        ItemTypeString = "Hand Crossbow";
                        return ItemTypeString;
                    case OneHandedRanged.PISTOL:
                        ItemTypeString = "Pistol";
                        return ItemTypeString;
                    case OneHandedRanged.THROWINGAXES:
                        ItemTypeString = "Throwing Axes";
                        return ItemTypeString;
                    case OneHandedRanged.THROWINGKNIFES:
                        ItemTypeString = "Throwing Knifes";
                        return ItemTypeString;
                    case OneHandedRanged.WAND:
                        ItemTypeString = "Wand";
                        return ItemTypeString;
                    default:
                        return "Not Done Yet";
                }
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
