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
        RateOfFire,
        ReloadSpeed,
        MagazineSize,
        CountEnd,
    }
    public static class ItemStats
    {
        static readonly int AttackSpeedCommonInt = 4;
        static readonly int AttackSpeedUncommonInt = 7;
        static readonly int AttackSpeedRareInt = 10;
        static readonly int AttackSpeedUnqiueInt = 14;
        static readonly int AttackSpeedMasterworkInt = 19;
        static readonly int AttackSpeedExoticInt = 25;
        static readonly int AttackSpeedLegendaryInt = 32;
        static readonly int CriticalChanceCommonInt = 4;
        static readonly int CriticalChanceUncommonInt = 8;
        static readonly int CriticalChanceRareInt = 12;
        static readonly int CriticalChanceUniqueInt = 16;
        static readonly int CriticalChanceMasterworkInt = 20;
        static readonly int CriticalChanceExoticInt = 26;
        static readonly int CriticalChanceLegendaryInt = 37;
        public static int AttackSpeedGenerator(Rarity itemRarity, ItemType itemType, Requirements itemRequirements) 
        {
            
            int AttackSpeedInt;
            if (itemRarity == Rarity.COMMON) 
            {
                AttackSpeedInt = Random.Range(1, AttackSpeedCommonInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                AttackSpeedInt = Random.Range(AttackSpeedCommonInt, AttackSpeedUncommonInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.RARE)
            {
                AttackSpeedInt = Random.Range(AttackSpeedUncommonInt, AttackSpeedRareInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                AttackSpeedInt = Random.Range(AttackSpeedRareInt, AttackSpeedUnqiueInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                AttackSpeedInt = Random.Range(AttackSpeedUnqiueInt, AttackSpeedMasterworkInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                AttackSpeedInt = Random.Range(AttackSpeedMasterworkInt, AttackSpeedExoticInt);
                return AttackSpeedInt;
            }
            if (itemRarity == Rarity.LEGENDARY)
            {
                AttackSpeedInt = Random.Range(AttackSpeedExoticInt, AttackSpeedLegendaryInt);
                return AttackSpeedInt;
            }
            return 0;
        }
        public static int CriticalChanceGenerator(Rarity itemRarity) 
        {
            int CriticalChanceInt;
            if (itemRarity == Rarity.COMMON)
            {
                CriticalChanceInt = Random.Range(1, CriticalChanceCommonInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                CriticalChanceInt = Random.Range(CriticalChanceCommonInt, CriticalChanceUncommonInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.RARE)
            {
                CriticalChanceInt = Random.Range(CriticalChanceUncommonInt, CriticalChanceRareInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                CriticalChanceInt = Random.Range(CriticalChanceRareInt, CriticalChanceUniqueInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                CriticalChanceInt = Random.Range(CriticalChanceUniqueInt, CriticalChanceMasterworkInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                CriticalChanceInt = Random.Range(CriticalChanceMasterworkInt, CriticalChanceExoticInt);
                return CriticalChanceInt;
            }
            if (itemRarity == Rarity.LEGENDARY)
            {
                CriticalChanceInt = Random.Range(CriticalChanceMasterworkInt, CriticalChanceLegendaryInt);
                return CriticalChanceInt;
            }
            return 0;
        }
        public static int PhysicalDamageGeneratorMin(Rarity itemRarity)
        {
            int PhysicalDamageMin;
            if (itemRarity == Rarity.COMMON)
            {
                PhysicalDamageMin = Random.Range(1, 21);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                PhysicalDamageMin = Random.Range(15, 36);
                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.RARE)
            {
                PhysicalDamageMin = Random.Range(30, 51);

                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                PhysicalDamageMin = Random.Range(100, 201);

                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                PhysicalDamageMin = Random.Range(500, 1000);

                return PhysicalDamageMin;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                PhysicalDamageMin = Random.Range(1, 1000000);

                return PhysicalDamageMin;
            }
            return 0;
        }
        public static int PhysicalDamageGeneratorMax(Rarity itemRarity, int PhysicalDamageMin) 
        {
            int PhysicalDamageMax;
            if (itemRarity == Rarity.COMMON)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 36);
                return PhysicalDamageMax;
            }
            if (itemRarity == Rarity.UNCOMMON)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 46);
                return PhysicalDamageMax;
            }
            if (itemRarity == Rarity.RARE)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 71);
                return PhysicalDamageMax;
            }
            if (itemRarity == Rarity.UNQIUE)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 501);
                return PhysicalDamageMax;
            }
            if (itemRarity == Rarity.MASTERWORK)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 5001);
                return PhysicalDamageMax;
            }
            if (itemRarity == Rarity.EXOTIC)
            {
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, PhysicalDamageMin + 1000000);
                return PhysicalDamageMax;
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
