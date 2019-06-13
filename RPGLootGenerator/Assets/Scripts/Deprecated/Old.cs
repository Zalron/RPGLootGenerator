using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old
{
    //public enum OneHandedMelee
    //{
    //    SHORTSWORD,
    //    ONEHANDEDMACE,
    //    KNIFE,
    //    ONEHANDEDWARHAMMERS,
    //    ONEHANDEDAXE,
    //    SHIELD,
    //    RAPIER,
    //    ONEHANDEDCLUB,
    //}
    //public enum TwoHandedMelee
    //{
    //    LONGSWORD,
    //    TWOHANDEDMACE,
    //    TWOHANDEDWARHAMMER,
    //    HALBERD,
    //    TWOHANDEDAXE,
    //    TWOHANDEDCLUB,
    //    STAFF,
    //    SPEAR,
    //    CLAWS,
    //}
    //public enum OneHandedRanged
    //{
    //    WAND,
    //    THROWINGKNIFES,
    //    THROWINGAXES,
    //    PISTOL,
    //    HANDCROSSBOW,
    //}
    //public enum TwoHandedRanged
    //{
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
    //static OneHandedMelee oneHandedMelee;
    //static TwoHandedMelee twoHandedMelee;
    //static OneHandedRanged oneHandedRanged;
    //static TwoHandedRanged twoHandedRanged;
    //public static string ItemTypeGenerator()
    //{
    //    string ItemTypeString = null;
    //    int itemTypeGeneratorInt = Random.Range(1, 5);
    //    if (itemTypeGeneratorInt == 1)
    //    {
    //        oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
    //        switch (oneHandedMelee)
    //        {
    //            case OneHandedMelee.ONEHANDEDMACE:
    //                ItemTypeString = "One Handed Mace";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDAXE:
    //                ItemTypeString = "One Handed Axe";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDWARHAMMERS:
    //                ItemTypeString = "One Handed Warhammer";
    //                return ItemTypeString;
    //            case OneHandedMelee.KNIFE:
    //                ItemTypeString = "Knife";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDCLUB:
    //                ItemTypeString = "One Handed Club";
    //                return ItemTypeString;
    //            case OneHandedMelee.RAPIER:
    //                ItemTypeString = "Rapier";
    //                return ItemTypeString;
    //            case OneHandedMelee.SHIELD:
    //                ItemTypeString = "Shield";
    //                return ItemTypeString;
    //            case OneHandedMelee.SHORTSWORD:
    //                ItemTypeString = "Short Swords";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else if (itemTypeGeneratorInt == 2)
    //    {
    //        twoHandedMelee = (TwoHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedMelee)).Length);
    //        switch (twoHandedMelee)
    //        {
    //            case TwoHandedMelee.TWOHANDEDMACE:
    //                ItemTypeString = "Two Handed Mace";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDAXE:
    //                ItemTypeString = "Two Handed Axes";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDCLUB:
    //                ItemTypeString = "Two Handed Club";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDWARHAMMER:
    //                ItemTypeString = "Two Handed Warhammer";
    //                return ItemTypeString;
    //            case TwoHandedMelee.STAFF:
    //                ItemTypeString = "Staff";
    //                return ItemTypeString;
    //            case TwoHandedMelee.SPEAR:
    //                ItemTypeString = "Spear";
    //                return ItemTypeString;
    //            case TwoHandedMelee.LONGSWORD:
    //                ItemTypeString = "Long Sword";
    //                return ItemTypeString;
    //            case TwoHandedMelee.HALBERD:
    //                ItemTypeString = "Halberd";
    //                return ItemTypeString;
    //            case TwoHandedMelee.CLAWS:
    //                ItemTypeString = "Claws";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else if (itemTypeGeneratorInt == 3)
    //    {
    //        oneHandedRanged = (OneHandedRanged)Random.Range(0, System.Enum.GetValues(typeof(OneHandedRanged)).Length);
    //        switch (oneHandedRanged)
    //        {
    //            case OneHandedRanged.HANDCROSSBOW:
    //                ItemTypeString = "Hand Crossbow";
    //                return ItemTypeString;
    //            case OneHandedRanged.PISTOL:
    //                ItemTypeString = "Pistol";
    //                return ItemTypeString;
    //            case OneHandedRanged.THROWINGAXES:
    //                ItemTypeString = "Throwing Axes";
    //                return ItemTypeString;
    //            case OneHandedRanged.THROWINGKNIFES:
    //                ItemTypeString = "Throwing Knifes";
    //                return ItemTypeString;
    //            case OneHandedRanged.WAND:
    //                ItemTypeString = "Wand";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else
    //    {
    //        return "ERROR";
    //    }
    //}
    //public int AttackSpeedOneHandedAxeInt = 3;
    //public int AttackSpeedOneHandedMaceInt = 3;
    //public int AttackSpeedOneHandedWarhammerInt = 4;
    //public int AttackSpeedOneHandedSwordInt = 7;
    //#region ItemStatCriticalChanceVariables

    //#region ItemStatCriticalChanceRarity
    //static readonly int CriticalChanceCommonInt = 1;
    //static readonly int CriticalChanceUncommonInt = 2;
    //static readonly int CriticalChanceRareInt = 3;
    //static readonly int CriticalChanceUniqueInt = 4;
    //static readonly int CriticalChanceMasterworkInt = 5;
    //static readonly int CriticalChanceExoticInt = 6;
    //static readonly int CriticalChanceLegendaryInt = 7;
    //#endregion

    //#region ItemStatCriticalChanceItemType
    //static readonly int CriticalChanceOneHandedAxeInt = 2;
    //static readonly int CriticalChanceOneHandedMaceInt = 3;
    //static readonly int CriticalChanceOneHandedWarhammerInt = 4;
    //static readonly int CriticalChanceOneHandedSwordInt = 2;
    //#endregion

    //#endregion

    //#region ItemStatPhysicalDamageVariables

    //#region ItemStatPhysicalDamageRarity
    //static readonly int PhysicalDamageCommonInt = 10;
    //static readonly int PhysicalDamageUncommonInt = 20;
    //static readonly int PhysicalDamageRareInt = 30;
    //static readonly int PhysicalDamageUnqiueInt = 40;
    //static readonly int PhysicalDamageMasterworkInt = 50;
    //static readonly int PhysicalDamageExoticInt = 60;
    //static readonly int PhysicalDamageLegendaryInt = 70;
    //#endregion

    //#region ItemStatPhysicalDamageItemType
    //static readonly int PhysicalDamageOneHandedAxeInt = 50;
    //static readonly int PhysicalDamageOneHandedMaceInt = 7;
    //static readonly int PhysicalDamageOneHandedWarhammerInt = 6;
    //static readonly int PhysicalDamageOneHandedSwordInt = 10;
    //#endregion

    //#endregion

    //#region ItemStatMagicalDamageVariables

    //#region ItemStatMagicalDamageRarity
    //static readonly int MagicalDamageCommonInt = 5;
    //static readonly int MagicalDamageUncommonInt = 10;
    //static readonly int MagicalDamageRareInt = 15;
    //static readonly int MagicalDamageUnqiueInt = 20;
    //static readonly int MagicalDamageMasterworkInt = 25;
    //static readonly int MagicalDamageExoticInt = 30;
    //static readonly int MagicalDamageLegendaryInt = 35;
    //#endregion

    //#region ItemStatMagicalDamageItemType
    //static readonly int MagicalDamageOneHandedAxeInt = 8;
    //static readonly int MagicalDamageOneHandedMaceInt = 7;
    //static readonly int MagicalDamageOneHandedWarhammerInt = 6;
    //static readonly int MagicalDamageOneHandedSwordInt = 10;
    //#endregion

    //#endregion

    //#endregion

    //#region ItemStateFunctions

    //#region ItemAttackSpeedFunctions
    //public static int AttackSpeedGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int AttackSpeedInt = 1;
    //    AttackSpeedInt += AttackSpeedItemTypeGenerator(AttackSpeedInt, itemType);
    //    AttackSpeedInt += AttackSpeedRarityGenerator(AttackSpeedInt, itemRarity);
    //    AttackSpeedInt += AttackSpeedRequirementGenerator(AttackSpeedInt, itemRequirements);
    //    return AttackSpeedInt;
    //}
    //public static int AttackSpeedItemTypeGenerator(int AttackSpeedInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedAxeInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedMaceInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedWarhammerInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedSwordInt;
    //        return AttackSpeedInt;
    //    }
    //    return AttackSpeedInt;
    //}
    //public static int AttackSpeedRarityGenerator(int AttackSpeedInt, ItemRarity itemRarity)
    //{

    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        AttackSpeedInt += AttackSpeedCommonInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        AttackSpeedInt += AttackSpeedUncommonInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        AttackSpeedInt += AttackSpeedRareInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        AttackSpeedInt += AttackSpeedUnqiueInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        AttackSpeedInt += AttackSpeedMasterworkInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        AttackSpeedInt += AttackSpeedExoticInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        AttackSpeedInt += AttackSpeedLegendaryInt;
    //        return AttackSpeedInt;
    //    }
    //    return 0;
    //}
    //public static int AttackSpeedRequirementGenerator(int AttackSpeedInt, ItemRequirement itemRequirements)
    //{
    //    AttackSpeedInt += (int)itemRequirements;
    //    return AttackSpeedInt;
    //}
    //#endregion

    //#region ItemCriticalChanceFunctions 
    //public static int CriticalChanceGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int CriticalChanceInt = 1;
    //    CriticalChanceInt += CriticalChanceItemTypeGenerator(CriticalChanceInt, itemType);
    //    CriticalChanceInt += CriticalChanceRarityGenerator(CriticalChanceInt, itemRarity);
    //    CriticalChanceInt += CriticalChanceRequirementGenerator(CriticalChanceInt, itemRequirements);
    //    return CriticalChanceInt;
    //}
    //public static int CriticalChanceRarityGenerator(int CriticalChanceInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        CriticalChanceInt += CriticalChanceCommonInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        CriticalChanceInt = CriticalChanceUncommonInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        CriticalChanceInt = CriticalChanceRareInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        CriticalChanceInt = CriticalChanceUniqueInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        CriticalChanceInt = CriticalChanceMasterworkInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        CriticalChanceInt = CriticalChanceExoticInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        CriticalChanceInt = CriticalChanceLegendaryInt;
    //        return CriticalChanceInt;
    //    }
    //    return 0;
    //}
    //public static int CriticalChanceItemTypeGenerator(int criticalChanceInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedAxeInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedMaceInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedWarhammerInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedSwordInt;
    //        return criticalChanceInt;
    //    }
    //    return 0;
    //}
    //public static int CriticalChanceRequirementGenerator(int CriticalChanceInt, ItemRequirement itemRequirements)
    //{
    //    CriticalChanceInt += (int)itemRequirements;
    //    return CriticalChanceInt;
    //}
    //#endregion

    //#region ItemPhysicalDamageFunctions

    //public static int PhysicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int PhysicalDamageInt = 1;
    //    PhysicalDamageInt += PhysicalDamageItemTypeGenerator(PhysicalDamageInt, itemType);
    //    PhysicalDamageInt += PhysicalDamageRarityGenerator(PhysicalDamageInt, itemRarity);
    //    PhysicalDamageInt += PhysicalDamageRequirementGenerator(PhysicalDamageInt, itemRequirements);
    //    return PhysicalDamageInt;
    //}
    //public static int PhysicalDamageRarityGenerator(int physicalDamageInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        physicalDamageInt += PhysicalDamageCommonInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        physicalDamageInt += PhysicalDamageUncommonInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        physicalDamageInt += PhysicalDamageRareInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        physicalDamageInt += PhysicalDamageUnqiueInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        physicalDamageInt += PhysicalDamageMasterworkInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        physicalDamageInt += PhysicalDamageExoticInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        physicalDamageInt += PhysicalDamageLegendaryInt;
    //        return physicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int PhysicalDamageItemTypeGenerator(int physicalDamageInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedAxeInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedMaceInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedWarhammerInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedSwordInt;
    //        return physicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int PhysicalDamageRequirementGenerator(int physicalDamageInt, ItemRequirement itemRequirements)
    //{
    //    physicalDamageInt += (int)itemRequirements;
    //    return physicalDamageInt;
    //}
    //#endregion

    //#region ItemMagicDamageFunctions

    //public static int MagicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int MagicalDamageInt = 0;
    //    MagicalDamageInt += MagicalDamageRarityGenerator(MagicalDamageInt, itemRarity);
    //    MagicalDamageInt += MagicalDamageItemTypeGenerator(MagicalDamageInt, itemType);
    //    MagicalDamageInt += MagicalDamageRequirementGenerator(MagicalDamageInt, itemRequirements);
    //    return MagicalDamageInt;
    //}
    //public static int MagicalDamageRarityGenerator(int magicalDamageInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        magicalDamageInt += MagicalDamageCommonInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        magicalDamageInt += MagicalDamageUncommonInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        magicalDamageInt += MagicalDamageRareInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        magicalDamageInt += MagicalDamageUnqiueInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        magicalDamageInt += MagicalDamageMasterworkInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        magicalDamageInt += MagicalDamageExoticInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        magicalDamageInt += MagicalDamageLegendaryInt;
    //        return magicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int MagicalDamageItemTypeGenerator(int magicalDamageInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedAxeInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedMaceInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedWarhammerInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedSwordInt;
    //        return magicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int MagicalDamageRequirementGenerator(int magicalDamageInt, ItemRequirement itemRequirements)
    //{
    //    magicalDamageInt += (int)itemRequirements;
    //    return magicalDamageInt;
    //}
    //#endregion

    //#endregion
    //public enum ItemType
    //{
    //    //one handed melee
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_KNIFE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_RAPIER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_CLUB,
    //    //Two handed melee
    //    ITEM_WEAPON_MELEE_TWOHANDED_SWORD,
    //    ITEM_WEAPON_MELEE_TWOHANDED_MACE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_WARHAMMER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_HALBERD,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_CLUB,
    //    ITEM_WEAPON_MELEE_TWOHANDED_STAFF,
    //    ITEM_WEAPON_MELEE_TWOHANDED_SPEAR,
    //    ITEM_WEAPON_MELEE_TWOHANDED_CLAWS,
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
    //public static ItemType ItemTypeGenerator(ItemTypeName itemTypeName)
    //{
    //    ItemType itemType;
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_TWOHANDED_AXE;
    //        return itemType;
    //    }
    //    return 0;
    //public static ItemTypeName GenerateOneHandedAxesNames()
    //{
    //    ItemTypeName oneHandedAxesNames;
    //    oneHandedAxesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND);
    //    return oneHandedAxesNames;
    //}
    //public static ItemTypeName GenerateOneHandedMacesNames()
    //{
    //    ItemTypeName oneHandedMacesNames;
    //    oneHandedMacesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND);
    //    return oneHandedMacesNames;
    //}
    //public static ItemTypeName GenerateOneHandedWarHammerNames()
    //{
    //    ItemTypeName oneHandedWarHammerNames;
    //    oneHandedWarHammerNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND);
    //    return oneHandedWarHammerNames;
    //}
    //public static ItemTypeName GenerateOneHandedSwordsNames()
    //{
    //    ItemTypeName oneHandedSwordNames;
    //    oneHandedSwordNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND);
    //    return oneHandedSwordNames;
    //}
    //public static ItemTypeName GenerateTwoHandedAxeNames()
    //{
    //    ItemTypeName twoHandedAxeNames;
    //    twoHandedAxeNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND);
    //    return twoHandedAxeNames;
    //}
    //}
    //public enum ItemTypeName
    //{
    //    ITEM_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_WETKOPIS,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEXSCUTUM,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_ODENROUNDSHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_BUCKERLER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_NAKHTUAASHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_PAINTEDKITESHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEATERSHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTEND,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND,
    //    ITEM_COUNTEND
    //}
    //public void ItemGenerator()
    //{
    //    itemName = ItemName.GenerateItemName();
    //    itemType = ItemTypes.ItemTypeGenerator(itemName);
    //    itemRarity = ItemRarities.RarityGenerator();
    //    switch (itemRarity)
    //    {
    //        case ItemRarity.COUNTSTART:
    //            break;
    //        case ItemRarity.COMMON:
    //            itemCombinedNameString = itemNameString;
    //            break;
    //        case ItemRarity.UNCOMMON:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            break;
    //        case ItemRarity.RARE:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.UNQIUE:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.MASTERWORK:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.EXOTIC:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs3 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.LEGENDARY:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs3 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs3 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.COUNTEND:
    //            break;
    //        default:
    //            break;
    //    }
    //    itemRequirements = ItemRequirements.RequirementsGenerator();
    //    if ()
    //    {
    //        itemStat1 = ItemStatType.AttackSpeed;
    //        itemStat2 = ItemStatType.CriticalChance;
    //        itemStat3 = ItemStatType.PhysicalDamage;
    //        itemStat4 = ItemStatType.MagicalDamage;
    //        itemStat5 = 0;
    //        itemStat6 = 0;
    //        itemStatInt1 = ItemStats.AttackSpeedGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt2 = ItemStats.CriticalChanceGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt3 = ItemStats.MagicalDamageGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt4 = ItemStats.PhysicalDamageGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt5 = 0;
    //        itemStatInt6 = 0;
    //        itemStats1String = ConvertString.AttackSpeedGenerator(itemStatInt1);
    //        itemStats2String = ConvertString.CriticalChanceGenerator(itemStatInt2);
    //        itemStats3String = ConvertString.PhysicalDamageGenerator(itemStatInt3);
    //        itemStats4String = ConvertString.AttackSpeedGenerator(itemStatInt4);
    //        itemStats5String = "";
    //        itemStats6String = "";
    //    }
    //    itemNameString = ConvertString.StringConvertItemName(itemName);
    //    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
    //    itemRarityString = ConvertString.RarityGeneratorString(itemRarity);
    //    itemTypeString = ConvertString.ItemTypeString(itemType);
    //    itemRequirementsString = ConvertString.RequirementsStringConvertor(itemRequirements);
    //}
}

