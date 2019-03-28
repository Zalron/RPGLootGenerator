using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum TwoHandedAxesNames
    {
        BattleAxe,
        LandHowiter,
        GoldenReaver,
        DemonsMalice,
        SeaOmega,
    }
    public static class TwoHandedAxes
    {
        static TwoHandedAxesNames twoHandedAxesNames;
        public static string GenerateTwoHandedAxesNames()
        {
            string TwoHandedAxesNamesString = null;
            twoHandedAxesNames = (TwoHandedAxesNames)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedAxesNames)).Length);
            switch (twoHandedAxesNames)
            {
                case TwoHandedAxesNames.DemonsMalice:
                    TwoHandedAxesNamesString = "Demons Malice";
                    return TwoHandedAxesNamesString;
                case TwoHandedAxesNames.LandHowiter:
                    TwoHandedAxesNamesString = "LandHowiter";
                    return TwoHandedAxesNamesString;
                case TwoHandedAxesNames.BattleAxe:
                    TwoHandedAxesNamesString = "BattleAxe";
                    return TwoHandedAxesNamesString;
                case TwoHandedAxesNames.GoldenReaver:
                    TwoHandedAxesNamesString = "Golden Reaver";
                    return TwoHandedAxesNamesString;
                case TwoHandedAxesNames.SeaOmega:
                    TwoHandedAxesNamesString = "SeaOmega";
                    return TwoHandedAxesNamesString;
                default:
                    return "ERROR";
            }
        }
    }
}
