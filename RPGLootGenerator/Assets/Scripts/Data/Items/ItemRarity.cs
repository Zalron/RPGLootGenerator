using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ItemRarity
    {
        enum Rarities
        {
            COMMON, 
            UNCOMMON,
            RARE,
            MASTERWORK,
            LEGENDARY,
            UNQIUE,
        }
        public static string RarityGenerate(/*string ItemRarity*/)
        {
            string ItemRarityString = null;
            Rarities rarity;
            rarity = (Rarities)Random.Range(0, System.Enum.GetValues(typeof(Rarities)).Length);
            switch (rarity)
            {
                case Rarities.COMMON:
                    ItemRarityString = "Common";
                    return ItemRarityString;
                case Rarities.UNCOMMON:
                    ItemRarityString = "Uncommon";
                    return ItemRarityString;
                case Rarities.RARE:
                    ItemRarityString = "Rare";
                    return ItemRarityString;
                case Rarities.MASTERWORK:
                    ItemRarityString = "Masterwork";
                    return ItemRarityString;
                case Rarities.LEGENDARY:
                    ItemRarityString = "Legendary";
                    return ItemRarityString;
                case Rarities.UNQIUE:
                    ItemRarityString = "Unqiue";
                    return ItemRarityString;
                default:
                    ItemRarityString = "ERROR";
                    return ItemRarityString;
            }
        }
    }
}
