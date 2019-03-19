﻿using System.Collections;
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
            ONEHANDEDAXES,
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
        static OneHandedMelee oneHandedMelee;
        static TwoHandedMelee twoHandedMelee;
        public static string ItemTypeGenerator()
        {
            string ItemTypeString = null;
            int itemTypeGeneratorInt = Random.Range(1, 3);
            if (itemTypeGeneratorInt == 1)
            {
                oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
                switch (oneHandedMelee)
                {
                    case OneHandedMelee.ONEHANDEDMACE:
                        //ItemTypeString = OneHandedMaces.GenerateOneHandedMacesNames();
                        ItemTypeString = "One Handed Mace";
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDAXES:
                        //ItemTypeString = OneHandedAxes.GenerateOneHandedAxesNames();
                        ItemTypeString = "One Handed Axes";
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
                        ItemTypeString = "ERROR";
                        return ItemTypeString;
                }
            }
            if (itemTypeGeneratorInt == 2)
            {
                twoHandedMelee = (TwoHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedMelee)).Length);
                switch (twoHandedMelee)
                {
                    case TwoHandedMelee.TWOHANDEDMACE:
                        ItemTypeString = "One Handed Mace";
                        return ItemTypeString;
                    case TwoHandedMelee.TWOHANDEDAXE:
                        ItemTypeString = "One Handed Axes";
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
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                }
            }
            return null;
        }
    }
}
