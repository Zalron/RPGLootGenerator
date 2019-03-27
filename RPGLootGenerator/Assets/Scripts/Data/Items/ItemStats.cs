using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ItemStats
    {
        //public enum ItemStatsNames 
        //{
        //    AttackSpeed,
        //    CriticalChance,
        //    PhysicalDamage,
        //    MagicalDamage,
        //}
        public static string AttackSpeedGenerator(string itemRarity) 
        {
            int AttackSpeedMin;
            string AttackSpeedString;
            if (itemRarity == "Common") 
            {
                AttackSpeedMin = Random.Range(10, 13);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Uncommon")
            {
                AttackSpeedMin = Random.Range(8, 11);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                AttackSpeedMin = Random.Range(6, 9);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Masterwork")
            {
                AttackSpeedMin = Random.Range(8, 5);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Legendary")
            {
                AttackSpeedMin = Random.Range(5, 3);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Unqiue")
            {
                AttackSpeedMin = Random.Range(3, 13);
                AttackSpeedString = "Attack Speed " + AttackSpeedMin;
                return AttackSpeedString;
            }
            return "ERROR";
        }
        public static string CriticalChanceGenerator(string itemRarity) 
        {
            int CriticalChance;
            string CriticalChanceString;
            if (itemRarity == "Common")
            {
                CriticalChance = Random.Range(10, 13);
                CriticalChanceString = "Critical Chance " + CriticalChance + "%";
                return CriticalChanceString;
            }
            if (itemRarity == "Uncommon")
            {
                CriticalChance = Random.Range(8, 11);
                CriticalChanceString = "Critical Chance " + CriticalChance;
                return CriticalChanceString;
            }
            if (itemRarity == "Rare")
            {
                CriticalChance = Random.Range(6, 9);
                CriticalChanceString = "Critical Chance " + CriticalChance;
                return CriticalChanceString;
            }
            if (itemRarity == "Masterwork")
            {
                CriticalChance = Random.Range(2, 5);
                CriticalChanceString = "Critical Chance " + CriticalChance;
                return CriticalChanceString;
            }
            if (itemRarity == "Legendary")
            {
                CriticalChance = Random.Range(1, 3);
                CriticalChanceString = "Critical Chance " + CriticalChance;
                return CriticalChanceString;
            }
            if (itemRarity == "Unqiue")
            {
                CriticalChance = Random.Range(1, 13);
                CriticalChanceString = "Critical Chance " + CriticalChance;
                return CriticalChanceString;
            }
            return "ERROR";
        }
        public static string PhysicalDamageGenerator(string itemRarity)
        {
            int PhysicalDamageMin;
            int PhysicalDamageMax;
            string PhysicalDamageString;
            if (itemRarity == "Common")
            {
                PhysicalDamageMin = Random.Range(1, 21);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 36);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            if (itemRarity == "Uncommon")
            {
                PhysicalDamageMin = Random.Range(15, 36);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 46);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            if (itemRarity == "Rare")
            {
                PhysicalDamageMin = Random.Range(30, 51);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 71);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            if (itemRarity == "Masterwork")
            {
                PhysicalDamageMin = Random.Range(100, 201);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 501);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            if (itemRarity == "Legendary")
            {
                PhysicalDamageMin = Random.Range(500, 1000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 5001);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            if (itemRarity == "Unqiue")
            {
                PhysicalDamageMin = Random.Range(1, 1000000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, PhysicalDamageMin + 1000000);
                PhysicalDamageString = "Physical Damage " + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return PhysicalDamageString;
            }
            return "ERROR";
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
                MagicalDamageMax = Random.Range(MagicalDamageMin + 1, MagicalDamageMin + 1000000);
                MagicalDamageString = "Magical Damage " + MagicalDamageMin + " to " + MagicalDamageMax;
                return MagicalDamageString;
            }
            return "ERROR";
        }
    }
}
