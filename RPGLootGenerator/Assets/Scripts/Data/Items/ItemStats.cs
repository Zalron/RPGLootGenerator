using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemStatType
    {
        CountStart,
        AttackSpeed,
        CriticalChance,
        PhysicalDamage,
        MagicalDamage,
        Armour,
        BlockChance,
        MagicGeneration,
        MovementSpeed,
        Evasion,
        ReloadSpeed,
        MagazineSize,
        CountEnd,
    }
    public static class ItemStats
    {

        #region ItemStatVariables

        #region ItemStatAttackSpeedVariables

        #region ItemStatAttackSpeedRarity
        static readonly int AttackSpeedCommonInt = 1;
        static readonly int AttackSpeedUncommonInt = 2;
        static readonly int AttackSpeedRareInt = 3;
        static readonly int AttackSpeedUnqiueInt = 4;
        static readonly int AttackSpeedMasterworkInt = 5;
        static readonly int AttackSpeedExoticInt = 6;
        static readonly int AttackSpeedLegendaryInt = 7;
        #endregion

        #region ItemStatAttackSpeedItemType
        static readonly int AttackSpeedOneHandedAxeInt = 3;
        static readonly int AttackSpeedOneHandedMaceInt = 3;
        static readonly int AttackSpeedOneHandedWarhammerInt = 4;
        static readonly int AttackSpeedOneHandedSwordInt = 7;
        #endregion

        #endregion

        #region ItemStatCriticalChanceVariables

        #region ItemStatCriticalChanceRarity
        static readonly int CriticalChanceCommonInt = 1;
        static readonly int CriticalChanceUncommonInt = 2;
        static readonly int CriticalChanceRareInt = 3;
        static readonly int CriticalChanceUniqueInt = 4;
        static readonly int CriticalChanceMasterworkInt = 5;
        static readonly int CriticalChanceExoticInt = 6;
        static readonly int CriticalChanceLegendaryInt = 7;
        #endregion

        #region ItemStatCriticalChanceItemType
        static readonly int CriticalChanceOneHandedAxeInt = 2;
        static readonly int CriticalChanceOneHandedMaceInt = 3;
        static readonly int CriticalChanceOneHandedWarhammerInt = 4;
        static readonly int CriticalChanceOneHandedSwordInt = 2;
        #endregion

        #endregion

        #region ItemStatPhysicalDamageVariables

        #region ItemStatPhysicalDamageRarity
        static readonly int PhysicalDamageCommonInt = 10;
        static readonly int PhysicalDamageUncommonInt = 20;
        static readonly int PhysicalDamageRareInt = 30;
        static readonly int PhysicalDamageUnqiueInt = 40;
        static readonly int PhysicalDamageMasterworkInt = 50;
        static readonly int PhysicalDamageExoticInt = 60;
        static readonly int PhysicalDamageLegendaryInt = 70;
        #endregion

        #region ItemStatPhysicalDamageItemType
        static readonly int PhysicalDamageOneHandedAxeInt = 50;
        static readonly int PhysicalDamageOneHandedMaceInt = 7;
        static readonly int PhysicalDamageOneHandedWarhammerInt = 6;
        static readonly int PhysicalDamageOneHandedSwordInt = 10;
        #endregion

        #endregion

        #region ItemStatMagicalDamageVariables

        #region ItemStatMagicalDamageRarity
        static readonly int MagicalDamageCommonInt = 5;
        static readonly int MagicalDamageUncommonInt = 10;
        static readonly int MagicalDamageRareInt = 15;
        static readonly int MagicalDamageUnqiueInt = 20;
        static readonly int MagicalDamageMasterworkInt = 25;
        static readonly int MagicalDamageExoticInt = 30;
        static readonly int MagicalDamageLegendaryInt = 35;
        #endregion

        #region ItemStatMagicalDamageItemType
        static readonly int MagicalDamageOneHandedAxeInt = 8;
        static readonly int MagicalDamageOneHandedMaceInt = 7;
        static readonly int MagicalDamageOneHandedWarhammerInt = 6;
        static readonly int MagicalDamageOneHandedSwordInt = 10;
        #endregion

        #endregion

        #endregion

        #region ItemStateFunctions

        #region ItemAttackSpeedFunctions
        public static int AttackSpeedGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
        {
            int AttackSpeedInt = 1;
            AttackSpeedItemTypeGenerator(AttackSpeedInt, itemType);
            AttackSpeedRarityGenerator(AttackSpeedInt, itemRarity);
            ItemTypeAttackSpeedRequirementGenerator(AttackSpeedInt, itemRequirements);
            return AttackSpeedInt;
        }
        public static int AttackSpeedItemTypeGenerator(int AttackSpeedInt, ItemType itemType)
        {
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
            {
                AttackSpeedInt += AttackSpeedOneHandedAxeInt;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
            {
                AttackSpeedInt += AttackSpeedOneHandedMaceInt;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
            {
                AttackSpeedInt += AttackSpeedOneHandedWarhammerInt;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
            {
                AttackSpeedInt += AttackSpeedOneHandedSwordInt;
                return AttackSpeedInt;
            }
            return AttackSpeedInt;
        }
        public static int AttackSpeedRarityGenerator(int AttackSpeedInt, ItemRarity itemRarity) 
        {
           
            if (itemRarity == ItemRarity.COMMON) 
            {
                AttackSpeedInt += AttackSpeedCommonInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.UNCOMMON)
            {
                AttackSpeedInt += AttackSpeedUncommonInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.RARE)
            {
                AttackSpeedInt += AttackSpeedRareInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.UNQIUE)
            {
                AttackSpeedInt += AttackSpeedUnqiueInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.MASTERWORK)
            {
                AttackSpeedInt += AttackSpeedMasterworkInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.EXOTIC)
            {
                AttackSpeedInt += AttackSpeedExoticInt;
                return AttackSpeedInt;
            }
            if (itemRarity == ItemRarity.LEGENDARY)
            {
                AttackSpeedInt += AttackSpeedLegendaryInt;
                return AttackSpeedInt;
            }
            return 0;
        }
        public static int ItemTypeAttackSpeedRequirementGenerator(int AttackSpeedInt, ItemRequirement itemRequirements)
        {
            for (int i = 1; i < (int)itemRequirements; i++)
            {
                AttackSpeedInt += (int)itemRequirements;
            }
            return AttackSpeedInt;
        }
        #endregion

        #region ItemCriticalChanceFunctions 
        public static int CriticalChanceGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
        {
            int CriticalChanceInt = 1;
            CriticalChanceItemTypeGenerator(CriticalChanceInt, itemType);
            CriticalChanceRarityGenerator(CriticalChanceInt, itemRarity);
            return CriticalChanceInt;
        }
        public static int CriticalChanceRarityGenerator(int CriticalChanceInt, ItemRarity itemRarity) 
        {
            if (itemRarity == ItemRarity.COMMON)
            {
                CriticalChanceInt += CriticalChanceCommonInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.UNCOMMON)
            {
                CriticalChanceInt = CriticalChanceUncommonInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.RARE)
            {
                CriticalChanceInt = CriticalChanceRareInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.UNQIUE)
            {
                CriticalChanceInt = CriticalChanceUniqueInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.MASTERWORK)
            {
                CriticalChanceInt = CriticalChanceMasterworkInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.EXOTIC)
            {
                CriticalChanceInt = CriticalChanceExoticInt;
                return CriticalChanceInt;
            }
            if (itemRarity == ItemRarity.LEGENDARY)
            {
                CriticalChanceInt = CriticalChanceLegendaryInt;
                return CriticalChanceInt;
            }
            return 0;
        }
        public static int CriticalChanceItemTypeGenerator(int criticalChanceInt, ItemType itemType)
        {
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
            {
                criticalChanceInt += AttackSpeedOneHandedAxeInt;
                return criticalChanceInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
            {
                criticalChanceInt += AttackSpeedOneHandedMaceInt;
                return criticalChanceInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
            {
                criticalChanceInt += AttackSpeedOneHandedWarhammerInt;
                return criticalChanceInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
            {
                criticalChanceInt += AttackSpeedOneHandedSwordInt;
                return criticalChanceInt;
            }
            return 0;
        }
        #endregion

        #region ItemPhysicalDamageFunctions

        public static int PhysicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
        {
            int PhysicalDamageInt = 1;
            PhysicalDamageInt += AttackSpeedItemTypeGenerator(PhysicalDamageInt, itemType);
            PhysicalDamageInt += PhysicalDamageRarityGenerator(PhysicalDamageInt, itemRarity);
            PhysicalDamageInt += PhysicalDamageRequirementGenerator(PhysicalDamageInt, itemRequirements);
            return PhysicalDamageInt;
        }
        public static int PhysicalDamageRarityGenerator(int physicalDamageInt, ItemRarity itemRarity)
        {
            if (itemRarity == ItemRarity.COMMON)
            {
                physicalDamageInt += PhysicalDamageCommonInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.UNCOMMON)
            {
                physicalDamageInt += PhysicalDamageUncommonInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.RARE)
            {
                physicalDamageInt += PhysicalDamageRareInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.UNQIUE)
            {
                physicalDamageInt += PhysicalDamageUnqiueInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.MASTERWORK)
            {
                physicalDamageInt += PhysicalDamageMasterworkInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.EXOTIC)
            {
                physicalDamageInt += PhysicalDamageExoticInt;
                return physicalDamageInt;
            }
            if (itemRarity == ItemRarity.LEGENDARY)
            {
                physicalDamageInt += PhysicalDamageLegendaryInt;
                return physicalDamageInt;
            }
            return 0;
        }
        public static int PhysicalDamageItemTypeGenerator(int physicalDamageInt, ItemType itemType)
        {
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
            {
                physicalDamageInt += PhysicalDamageOneHandedAxeInt;
                return physicalDamageInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
            {
                physicalDamageInt += PhysicalDamageOneHandedMaceInt;
                return physicalDamageInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
            {
                physicalDamageInt += PhysicalDamageOneHandedWarhammerInt;
                return physicalDamageInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
            {
                physicalDamageInt += PhysicalDamageOneHandedSwordInt;
                return physicalDamageInt;
            }
            return 0;
        }
        public static int PhysicalDamageRequirementGenerator(int physicalDamageInt, ItemRequirement itemRequirements)
        {
            for (int i = 1; i < (int)itemRequirements; i++)
            {
                physicalDamageInt += (int)itemRequirements;
            }
            return physicalDamageInt;
        }
        #endregion

        #region ItemMagicDamageFunctions

        public static int MagicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements) 
        {
            int MagicalDamageInt = 0;
            return MagicalDamageInt;
        }

        #endregion

        #endregion
    }
}
