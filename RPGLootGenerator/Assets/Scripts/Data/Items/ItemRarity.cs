using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum Rarity
    {
        COUNTSTART,
        COMMON,
        UNCOMMON,
        RARE,
        UNQIUE,
        MASTERWORK,
        EXOTIC,
        LEGENDARY,
        COUNTEND,
    }
    public static class ItemRarity
    {
        public static Rarity RarityGenerator()
        {
            Rarity rarity;
            rarity = (Rarity)Random.Range((int)Rarity.COUNTSTART + 1, (int)Rarity.COUNTEND);
            return rarity;
        }
        public static int ItemRarityAttackSpeedGenerator() 
        {
             
        }
    }
}
