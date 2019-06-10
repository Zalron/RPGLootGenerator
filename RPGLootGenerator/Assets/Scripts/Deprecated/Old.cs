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
}
