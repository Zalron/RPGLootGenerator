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
            ONEHANDEDWARHAMMER,
            ONEHANDEDAXES,
            SHIELD,
            RAPIER,
            ONEHANDEDCLUB,
        }
        public enum TwoHandedMelee
        {
            LONGSWORD,
            MACE,
            WARHAMMER,
            HALBERD,
            AXE,
            CLUB,
            STAFF,
            SPEAR,
            CLAWS,
        }
        static OneHandedMelee oneHandedMelee;
        public static void ItemTypeGenerator(string ItemType)
        {
            int ItemTypeGenerator = Random.Range(0, 2);
            if (ItemTypeGenerator == 1)
            {
                oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
                switch (oneHandedMelee)
                {
                    case OneHandedMelee.ONEHANDEDAXES:
                        OneHandedAxes.GenerateOneHandedAxesNames(ItemType);
                        break;
                    default:
                        ItemType = "Not done yet";
                        break;

                }
            }
        }
    }
}
