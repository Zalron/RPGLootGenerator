using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemTypeName 
    {
        ITEM_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_AXE_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_AXE_VIKINGAXE,
        ITEM_WEAPON_ONEHANDED_AXE_BONEHACHET,
        ITEM_WEAPON_ONEHANDED_AXE_WOODEDAXE,
        ITEM_WEAPON_ONEHANDED_AXE_BLOODCLEAVER,
        ITEM_WEAPON_ONEHANDED_AXE_COUNTEND,
        ITEM_WEAPON_ONEHANDED_MACE_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_MACE_MORNINGSTAR,
        ITEM_WEAPON_ONEHANDED_MACE_BLACKJACK,
        ITEM_WEAPON_ONEHANDED_MACE_IRONTEETH,
        ITEM_WEAPON_ONEHANDED_MACE_RINGEDPERNACH,
        ITEM_WEAPON_ONEHANDED_MACE_ENERGYCORRECTOR,
        ITEM_WEAPON_ONEHANDED_MACE_BEDECKEDSHISHPAR,
        ITEM_WEAPON_ONEHANDED_MACE_NIGHTGADA,
        ITEM_WEAPON_ONEHANDED_MACE_COUNTEND,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_CLAWEDPICK,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_SKULLSINGER,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_DOUBLEHEADER,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_STONEBREAKER,
        ITEM_WEAPON_ONEHANDED_WARHAMMER_COUNTEND,
        ITEM_WEAPON_ONEHANDED_SWORD_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_SWORD_BRONZEKOPIS,
        ITEM_WEAPON_ONEHANDED_SWORD_TUTONICSWORD,
        ITEM_WEAPON_ONEHANDED_SWORD_DUSTKHOPESH,
        ITEM_WEAPON_ONEHANDED_SWORD_STEELGLADIUS,
        ITEM_WEAPON_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL,
        ITEM_WEAPON_ONEHANDED_SWORD_COUNTEND,
        ITEM_WEAPON_ONEHANDED_SHIELD_COUNTSTART,
        ITEM_WEAPON_ONEHANDED_SHIELD_HEXSCUTUM,
        ITEM_WEAPON_ONEHANDED_SHIELD_ODENROUNDSHEILD,
        ITEM_WEAPON_ONEHANDED_SHIELD_COUNTEND,
        ITEM_WEAPON_TWOHANDEDAXE_COUNTSTART,
        ITEM_WEAPON_TWOHANDEDAXE_BATTLEAXE,
        ITEM_WEAPON_TWOHANDEDAXE_LANDHOWITER,
        ITEM_WEAPON_TWOHANDEDAXE_GOLDENREAVER,
        ITEM_WEAPON_TWOHANDEDAXE_DEMONSMALICE,
        ITEM_WEAPON_TWOHANDEDAXE_SEAOMEGA,
        ITEM_WEAPON_TWOHANDEDAXE_COUNTEND,
        ITEM_COUNTEND
    }
    public static class ItemName
    {
        public static ItemTypeName GenerateItemName() 
        {
            ItemTypeName ItemName;
            ItemName = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_COUNTSTART + 1, (int)ItemTypeName.ITEM_COUNTEND);
            return ItemName;
        }
        public static ItemTypeName GenerateOneHandedAxesNames()
        {
            ItemTypeName oneHandedAxesNames;
            oneHandedAxesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_ONEHANDED_AXE_COUNTEND);
            return oneHandedAxesNames;
        }
        public static ItemTypeName GenerateOneHandedMacesNames()
        {
            ItemTypeName oneHandedMacesNames;
            oneHandedMacesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_ONEHANDED_MACE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_ONEHANDED_MACE_COUNTEND);
            return oneHandedMacesNames;
        }
        public static ItemTypeName GenerateOneHandedWarHammerNames() 
        {
            ItemTypeName oneHandedWarHammerNames;
            oneHandedWarHammerNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_ONEHANDED_WARHAMMER_COUNTEND);
            return oneHandedWarHammerNames;
        }
        public static ItemTypeName GenerateOneHandedSwordsNames() 
        {
            ItemTypeName oneHandedSwordNames;
            oneHandedSwordNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_ONEHANDED_SWORD_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_ONEHANDED_SWORD_COUNTEND);
            return oneHandedSwordNames;
        }
    }
}
