using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ItemTypes
    {
        //public enum ItemType
        //{
        //    //one handed melee
        //    SHORTSWORD,
        //    ONEHANDEDMACE,
        //    KNIFE,
        //    ONEHANDEDWARHAMMERS,
        //    ONEHANDEDAXE,
        //    SHIELD,
        //    RAPIER,
        //    ONEHANDEDCLUB,
        //    //Two handed melee
        //    LONGSWORD,
        //    GREATSWORD,
        //    TWOHANDEDMACE,
        //    TWOHANDEDWARHAMMER,
        //    HALBERD,
        //    TWOHANDEDAXE,
        //    TWOHANDEDCLUB,
        //    STAFF,
        //    SPEAR,
        //    CLAWS,
        //    //One handed ranged
        //    WAND,
        //    THROWINGKNIFES,
        //    THROWINGAXES,
        //    PISTOL,
        //    HANDCROSSBOW,
        //    //Two handed ranged
        //    BOW,
        //    CROSSBOW,
        //    MATCHLOCKRIFLE,
        //    CARBINE,
        //    BULLPUP,
        //    ASSAULTRIFLE,
        //    SNIPERRIFLE,
        //    MACHINEGUN,
        //    SHOTGUN,
        //    GRENADELAUNCHER,
        //    ROCKETLAUNCHER,
        //}
        //static ItemType itemType;
        public static string ItemTypeGenerator(ItemTypeName itemTypeName)
        {
            string ItemTypeString;
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDAXE_BLOODCLEAVER ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDAXE_VIKINGAXE ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDAXE_WOODEDAXE || 
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDAXE_BONEHACHET) 
            {
                ItemTypeString = "One Handed Axe";
                return ItemTypeString; 
            }
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_BLACKJACK ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_IRONTEETH ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_NIGHTGADA ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_MORNINGSTAR ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_RINGEDPERNACH ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_ENERGYCORRECTOR ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_ONEHANDEDMACE_BEDECKEDSHISHPAR)
            {
                ItemTypeString = "One Handed Mace";
                return ItemTypeString;
            }
            return "ERROR";
        }
    }
}
