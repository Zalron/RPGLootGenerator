using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemPrefixs
    {
        COUNTSTART,
        Upper,
        Clothed,
        Rusted,
        Kings,
        Jesters,
        Marked,
        COUNTEND
    }
    public enum ItemSuffixs
    {
        COUNTSTART,
        OfRetarding,
        OfFrost,
        OfAccelerating,
        OfDestruction,
        OfCursing,
        COUNTEND
    }
    public class ItemAffixs
    {
        public static ItemPrefixs GeneratePrefixs()
        {
            ItemPrefixs prefixs;
            prefixs = (ItemPrefixs)Random.Range((int)ItemPrefixs.COUNTSTART + 1, (int)ItemPrefixs.COUNTEND);
            return prefixs;
        }
        public static ItemSuffixs GenerateSuffixs()
        {
            ItemSuffixs suffixs;
            suffixs = (ItemSuffixs)Random.Range((int)ItemSuffixs.COUNTSTART + 1, (int)ItemSuffixs.COUNTEND);
            return suffixs;
        }
    }
}
