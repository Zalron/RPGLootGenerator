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

        // ItemType Variables
        static readonly int OneHandedAxeAttackSpeed = 8;
        static readonly int OneHandedMaceAttackSpeed = 7;
        static readonly int OneHandedWarhammerAttackSpeed = 6;
        static readonly int OneHandedSwordAttackSpeed = 10;

        // ItemRarity variables
        static readonly int AttackSpeedCommonInt = 4;
        static readonly int AttackSpeedUncommonInt = 7;
        static readonly int AttackSpeedRareInt = 10;
        static readonly int AttackSpeedUnqiueInt = 14;
        static readonly int AttackSpeedMasterworkInt = 19;
        static readonly int AttackSpeedExoticInt = 25;
        static readonly int AttackSpeedLegendaryInt = 32;

        // Item variables
        #endregion

        #region ItemStatCriticalChanceVariables
        static readonly int CriticalChanceCommonInt = 1;
        static readonly int CriticalChanceUncommonInt = 2;
        static readonly int CriticalChanceRareInt = 3;
        static readonly int CriticalChanceUniqueInt = 4;
        static readonly int CriticalChanceMasterworkInt = 5;
        static readonly int CriticalChanceExoticInt = 6;
        static readonly int CriticalChanceLegendaryInt = 7;
        #endregion

        #region
        static readonly int OneHandedAxeCriticalChance = 2;
        static readonly int OneHandedMaceCriticalChance = 3;
        static readonly int OneHandedWarhammerCriticalChance = 4;
        static readonly int OneHandedSwordCriticalChance = 2;
        #endregion

        #endregion

        #region ItemAttackSpeedFunctions
        public static int AttackSpeedGenerator(Rarity itemRarity, ItemType itemType, Requirements itemRequirements)
        {
            int AttackSpeedInt = 1;
            
            AttackSpeedItemTypeGenerator(AttackSpeedInt, itemType);
            AttackSpeedRarityGenerator(AttackSpeedInt, itemRarity);
            return AttackSpeedInt;
        }
        public static int AttackSpeedItemTypeGenerator(int AttackSpeedInt, ItemType itemType)
        {
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
            {
                AttackSpeedInt += OneHandedAxeAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
            {
                AttackSpeedInt += OneHandedMaceAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
            {
                AttackSpeedInt += OneHandedWarhammerAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
            {
                AttackSpeedInt += OneHandedSwordAttackSpeed;
                return AttackSpeedInt;
            }
            return AttackSpeedInt;
        }
        public static int AttackSpeedRarityGenerator(int AttackSpeedInt, Rarity itemRarity) 
        {
           
            if (itemRarity == Rarity.COMMON) 
            {
                AttackSpeedInt += AttackSpeedCommonInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                AttackSpeedInt += AttackSpeedUncommonInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.RARE)
            {
                AttackSpeedInt += AttackSpeedRareInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                AttackSpeedInt += AttackSpeedUnqiueInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                AttackSpeedInt += AttackSpeedMasterworkInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                AttackSpeedInt += AttackSpeedExoticInt;
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.LEGENDARY)
            {
                AttackSpeedInt += AttackSpeedLegendaryInt;
                return AttackSpeedInt;
            }
            return 0;
        }
        public static int ItemTypeAttackSpeedRequirementGenerator(int AttackSpeedInt, Requirements itemRequirements)
        {
            for (int i = 1; i < (int)itemRequirements; i++)
            {
                AttackSpeedInt += (int)itemRequirements;
            }
            return AttackSpeedInt;
        }
        #endregion
        public static int CriticalChanceGenerator(Rarity itemRarity, ItemType itemType, Requirements itemRequirements)
        {
            int CriticalChanceInt = 1;

            CriticalChanceItemTypeGenerator(CriticalChanceInt, itemType);
            CriticalChanceRarityGenerator(CriticalChanceInt, itemRarity);
            return CriticalChanceInt;
        }
        public static int CriticalChanceRarityGenerator(int CriticalChanceInt, Rarity itemRarity) 
        {
            if (itemRarity == Rarity.COMMON)
            {
                CriticalChanceInt += CriticalChanceCommonInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                CriticalChanceInt = CriticalChanceUncommonInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.RARE)
            {
                CriticalChanceInt = CriticalChanceRareInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                CriticalChanceInt = CriticalChanceUniqueInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                CriticalChanceInt = CriticalChanceMasterworkInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                CriticalChanceInt = CriticalChanceExoticInt;
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.LEGENDARY)
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
                AttackSpeedInt += OneHandedAxeAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
            {
                AttackSpeedInt += OneHandedMaceAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
            {
                AttackSpeedInt += OneHandedWarhammerAttackSpeed;
                return AttackSpeedInt;
            }
            if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
            {
                AttackSpeedInt += OneHandedSwordAttackSpeed;
                return AttackSpeedInt;
            }
            return AttackSpeedInt;
        }
    }
        public static int PhysicalDamageGenerator(Rarity itemRarity)
        {
            int PhysicalDamageMin;
            int PhysicalDamageMax;
            if (itemRarity == Rarity.COMMON)
            {
                PhysicalDamageMin = Random.Range(1, 20 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 30 + 1);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                
                PhysicalDamageMin = Random.Range(15, 35 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 45 + 1);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.RARE)
            {
                PhysicalDamageMin = Random.Range(30, 50 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 75 + 1);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                PhysicalDamageMin = Random.Range(100, 500 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 500 + 1);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                PhysicalDamageMin = Random.Range(500, 1000 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 5000 + 1);

                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                PhysicalDamageMin = Random.Range(1000, 10000 + 1);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 100000 + 1);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.LEGENDARY)
            {
                PhysicalDamageMin = Random.Range(10000, 100000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 1000000 + 1);
                return PhysicalDamageMin;
            }
            return 0;
        }
        public static string MagicalDamageGenerator(string itemRarity) 
        {
            int MagicalDamageMin;
            int MagicalDamageMax;
            string MagicalDamageString;
            if (itemRarity == "Common")
            {
                MagicalDamageMin = Random.Range(1, 21);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 36);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            if (itemRarity == "Uncommon")
            {
                MagicalDamageMin = Random.Range(15, 36);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 46);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            if (itemRarity == "Rare")
            {
                MagicalDamageMin = Random.Range(30, 51);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 71);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            if (itemRarity == "Masterwork")
            {
                MagicalDamageMin = Random.Range(100, 201);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 501);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            if (itemRarity == "Legendary")
            {
                MagicalDamageMin = Random.Range(500, 1000);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 5001);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            if (itemRarity == "Unqiue")
            {
                MagicalDamageMin = Random.Range(1, 1000000);
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, 1000000);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            return "ERROR";
        }

    }
}
