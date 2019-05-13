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
        UNQIUE,
        MASTERWORK,
        EXOTIC,
        LEGENDARY,
        COUNTEND,
    }
    public static class ItemRarities
    {
        public static ItemRarity RarityGenerator()
        {
            ItemRarity rarity;
            rarity = (ItemRarity)Random.Range((int)ItemRarity.COUNTSTART + 1, (int)ItemRarity.COUNTEND);
            return rarity;
        }
    }
}
