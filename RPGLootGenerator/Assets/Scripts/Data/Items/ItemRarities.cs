using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemRarity
    {
        COUNTSTART,
        COMMON,
        UNCOMMON,
        RARE,
        MASTERWORK,
        EXOTIC,
        LEGENDARY,
        ANCIENT,
        UNQIUE,
        COUNTEND,
    }
    public class ItemRarities
    {
        public static ItemRarity RarityGenerator()
        {
            ItemRarity rarity;
            rarity = (ItemRarity)Random.Range((int)ItemRarity.COUNTSTART + 1, 7);
            return rarity;
        }
    }
}
