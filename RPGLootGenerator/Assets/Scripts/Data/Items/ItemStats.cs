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
            float AttackSpeedMin;
            string AttackSpeedString;
            if (itemRarity == "Common") 
            {
                AttackSpeedMin = Random.Range(12, 10.5f);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Uncommon")
            {
                AttackSpeedMin = Random.Range(15, 36);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                AttackSpeedMin = Random.Range(30, 51);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                AttackSpeedMin = Random.Range(50, 101);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Masterwork")
            {
                AttackSpeedMin = Random.Range(100, 201);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Legendary")
            {
                AttackSpeedMin = Random.Range(500, 1000);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            if (itemRarity == "Unqiue")
            {
                AttackSpeedMin = Random.Range(1, 1000000);
                AttackSpeedString = "Attack Speed" + AttackSpeedMin;
                return AttackSpeedString;
            }
            return "ERROR";
        }
        public static void CriticalChanceGenerator() 
        {

        }
        public static string PhysicalDamageGenerator(string itemRarity)
        {
            int PhysicalDamageMin;
            int PhysicalDamageMax;
            string AttackSpeedString;
            if (itemRarity == "Common")
            {
                PhysicalDamageMin = Random.Range(1, 21);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 36);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Uncommon")
            {
                PhysicalDamageMin = Random.Range(15, 36);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 46);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                PhysicalDamageMin = Random.Range(30, 51);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 71);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                PhysicalDamageMin = Random.Range(50, 101);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 201);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Masterwork")
            {
                PhysicalDamageMin = Random.Range(100, 201);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 501);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Legendary")
            {
                PhysicalDamageMin = Random.Range(500, 1000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 5001);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Unqiue")
            {
                PhysicalDamageMin = Random.Range(1, 1000000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, PhysicalDamageMin + 1000000);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            return "ERROR";
        }
        public static string MagicalDamageGenerator() 
        {
            int PhysicalDamageMin;
            int PhysicalDamageMax;
            string AttackSpeedString;
            if (itemRarity == "Common")
            {
                PhysicalDamageMin = Random.Range(1, 21);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 36);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Uncommon")
            {
                PhysicalDamageMin = Random.Range(15, 36);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 46);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                PhysicalDamageMin = Random.Range(30, 51);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 71);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Rare")
            {
                PhysicalDamageMin = Random.Range(50, 101);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 201);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Masterwork")
            {
                PhysicalDamageMin = Random.Range(100, 201);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 501);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Legendary")
            {
                PhysicalDamageMin = Random.Range(500, 1000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, 5001);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            if (itemRarity == "Unqiue")
            {
                PhysicalDamageMin = Random.Range(1, 1000000);
                PhysicalDamageMax = Random.Range(PhysicalDamageMin + 1, PhysicalDamageMin + 1000000);
                AttackSpeedString = "Attack Speed" + PhysicalDamageMin + " to " + PhysicalDamageMax;
                return AttackSpeedString;
            }
            return "ERROR";
        }
    }
}
