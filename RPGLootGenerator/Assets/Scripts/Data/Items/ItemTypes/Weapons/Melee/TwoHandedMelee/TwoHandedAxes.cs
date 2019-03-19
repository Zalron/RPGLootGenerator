using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class TwoHandedAxes
    {
        public enum TwoHandedAxesNames
        {
            BattleAxe,
            LandHowiter,
            GoldenReaver,
            DemonsMalice,
        }
        static TwoHandedAxesNames oneHandedAxesNames;
        public static void GenerateOneHandedAxesNames(string AxeName)
        {
            oneHandedAxesNames = (TwoHandedAxesNames)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedAxesNames)).Length);
            switch (oneHandedAxesNames)
            {
                case TwoHandedAxesNames.DemonsMalice:
                    AxeName = "Demons Malice";
                    break;
                case TwoHandedAxesNames.LandHowiter:
                    AxeName = "LandHowiter";
                    break;
                case TwoHandedAxesNames.BattleAxe:
                    AxeName = "Battle Axe";
                    break;
                case TwoHandedAxesNames.GoldenReaver:
                    AxeName = "Golden Reaver";
                    break;
                default:
                    break;
            }
        }
    }
}
