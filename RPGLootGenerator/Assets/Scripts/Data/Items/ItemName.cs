using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemTypeName 
    {
        ITEM_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_WETKOPIS,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL,
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTSTART,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEXSCUTUM,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_ODENROUNDSHEILD,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_BUCKERLER,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_NAKHTUAASHEILD,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_PAINTEDKITESHEILD,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEATERSHEILD,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTEND,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND,
        ITEM_COUNTEND
    }
    [CreateAssetMenu(fileName = "Individual Item", menuName = "Item", order = 1)]
    public class ItemName : ScriptableObject
    {
        public string ItemNameString;
        public static ItemTypeName GenerateItemName()
        {
            ItemTypeName ItemName;
            int itemNameNum = Random.Range(1, 5 + 1);
            switch (itemNameNum)
            {
                case 1:
                    ItemName = GenerateOneHandedAxesNames();
                    return ItemName;
                case 2:
                    ItemName = GenerateOneHandedMacesNames();
                    return ItemName;
                case 3:
                    ItemName = GenerateOneHandedWarHammerNames();
                    return ItemName;
                case 4:
                    ItemName = GenerateOneHandedSwordsNames();
                    return ItemName;
                case 5:
                    ItemName = GenerateTwoHandedAxeNames();
                    return ItemName;
                default:
                    return 0;
            }
        }
        public static ItemTypeName GenerateOneHandedAxesNames()
        {
            ItemTypeName oneHandedAxesNames;
            oneHandedAxesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND);
            return oneHandedAxesNames;
        }
        public static ItemTypeName GenerateOneHandedMacesNames()
        {
            ItemTypeName oneHandedMacesNames;
            oneHandedMacesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND);
            return oneHandedMacesNames;
        }
        public static ItemTypeName GenerateOneHandedWarHammerNames()
        {
            ItemTypeName oneHandedWarHammerNames;
            oneHandedWarHammerNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND);
            return oneHandedWarHammerNames;
        }
        public static ItemTypeName GenerateOneHandedSwordsNames()
        {
            ItemTypeName oneHandedSwordNames;
            oneHandedSwordNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND);
            return oneHandedSwordNames;
        }
        public static ItemTypeName GenerateTwoHandedAxeNames()
        {
            ItemTypeName twoHandedAxeNames;
            twoHandedAxeNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND);
            return twoHandedAxeNames;
        }
    }
}
