using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemType
    {
        //one handed melee
        ITEM_WEAPON_MELEE_ONEHANDED_SWORD,
        ITEM_WEAPON_MELEE_ONEHANDED_MACE,
        ITEM_WEAPON_MELEE_ONEHANDED_KNIFE,
        ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER,
        ITEM_WEAPON_MELEE_ONEHANDED_AXE,
        ITEM_WEAPON_MELEE_ONEHANDED_SHIELD,
        ITEM_WEAPON_MELEE_ONEHANDED_RAPIER,
        ITEM_WEAPON_MELEE_ONEHANDED_CLUB,
        //Two handed melee
        ITEM_WEAPON_MELEE_TWOHANDED_SWORD,
        ITEM_WEAPON_MELEE_TWOHANDED_MACE,
        ITEM_WEAPON_MELEE_TWOHANDED_WARHAMMER,
        ITEM_WEAPON_MELEE_TWOHANDED_HALBERD,
        ITEM_WEAPON_MELEE_TWOHANDED_AXE,
        ITEM_WEAPON_MELEE_TWOHANDED_CLUB,
        ITEM_WEAPON_MELEE_TWOHANDED_STAFF,
        ITEM_WEAPON_MELEE_TWOHANDED_SPEAR,
        ITEM_WEAPON_MELEE_TWOHANDED_CLAWS,
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
    public static class ItemTypes
    {
        public static ItemType ItemTypeGenerator(ItemTypeName itemTypeName)
        {
            ItemType itemType;
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE || 
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET) 
            {
                itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE;
                return itemType; 
            }
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR)
            {
                itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE;
                return itemType;
            }
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER)
            {
                itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER;
                return itemType;
            }
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL) 
            {
                itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD;
                return itemType; 
            }
            if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE ||
                itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER)
            {
                itemType = ItemType.ITEM_WEAPON_MELEE_TWOHANDED_AXE;
                return itemType;
            }
            return 0;
        }
    }
}
