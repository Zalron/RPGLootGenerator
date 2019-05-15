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
        static ItemPrefixs prefixs;
        static ItemSuffixs suffixs;
        public static ItemPrefixs GeneratePrefixs()
        {
            prefixs = (ItemPrefixs)Random.Range((int)ItemPrefixs.COUNTSTART, (int)ItemPrefixs.COUNTEND);
            return prefixs;
        }
        public static ItemSuffixs GenerateSuffixs()
        {
            suffixs = (ItemSuffixs)Random.Range(0, System.Enum.GetValues(typeof(ItemSuffixs)).Length);
            return suffixs;
        }
       
    }
}
