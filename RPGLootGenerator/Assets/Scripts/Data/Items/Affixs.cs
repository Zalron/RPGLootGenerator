using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Affixs
    {
        public enum Prefixs
        {
            Upper,
            Clothed,
            Rusted,
            Kings,
            Jesters,
            Marked,
        }
        public enum Suffixs
        {
            OfRetarding,
            OfFrost,
            OfAccelerating,
            OfDestruction,
            OfCursing,
        }
        static Prefixs prefixs;
        static Suffixs suffixs;
        public static string GeneratePrefixs()
        {
            string PrefixsString = null;
            prefixs = (Prefixs)Random.Range(0, System.Enum.GetValues(typeof(Prefixs)).Length);
            switch (prefixs)
            {
                case Prefixs.Clothed:
                    PrefixsString = "Clothed";
                    return PrefixsString;
                case Prefixs.Jesters:
                    PrefixsString = "Jesters";
                    return PrefixsString;
                case Prefixs.Kings:
                    PrefixsString = "Kings";
                    return PrefixsString;
                case Prefixs.Marked:
                    PrefixsString = "Marked";
                    return PrefixsString;
                case Prefixs.Rusted:
                    PrefixsString = "Rusted";
                    return PrefixsString;
                case Prefixs.Upper:
                    PrefixsString = "Upper";
                    return PrefixsString;
                default:
                    return "ERROR";
            }
        }
        public static string GenerateSuffixs()
        {
            string SuffixsString = null;
            suffixs = (Suffixs)Random.Range(0, System.Enum.GetValues(typeof(Suffixs)).Length);
            switch (suffixs)
            {
                case Suffixs.OfAccelerating:
                    SuffixsString = "Of Accelerating";
                    return SuffixsString;
                case Suffixs.OfCursing:
                    SuffixsString = "Of Cursing";
                    return SuffixsString;
                case Suffixs.OfDestruction:
                    SuffixsString = "Of Destruction";
                    return SuffixsString;
                case Suffixs.OfFrost:
                    SuffixsString = "Of Frost";
                    return SuffixsString;
                case Suffixs.OfRetarding:
                    SuffixsString = "Of Retarding";
                    return SuffixsString;
                default:
                    return "ERROR";
            }
        }
    }
}
