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
        public static string ItemTypeGenerator()
        {
            string ItemTypeString = null;
            int ItemTypeGenerator = Random.Range(0, 2);
            if (ItemTypeGenerator == 1)
            {
                oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
                switch (oneHandedMelee)
                {
                    case OneHandedMelee.ONEHANDEDMACE:
                        ItemTypeString = OneHandedMaces.GenerateOneHandedMacesNames();
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDAXES:
                        ItemTypeString = OneHandedAxes.GenerateOneHandedAxesNames();
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDWARHAMMERS:
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                    case OneHandedMelee.KNIFE:
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                    case OneHandedMelee.ONEHANDEDCLUB:
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                    case OneHandedMelee.RAPIER:
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                    case OneHandedMelee.SHIELD:
                        ItemTypeString = "Not done yet";
                        return ItemTypeString;
                    case OneHandedMelee.SHORTSWORD:
                        ItemTypeString = "Not done yet";
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
