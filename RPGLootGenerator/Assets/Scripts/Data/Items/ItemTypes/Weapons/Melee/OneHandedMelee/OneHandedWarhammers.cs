using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum OneHandedWarhammersNames
    {
        ClawedPick,
        SkullSinger,
        DoubleHeader,
        StoneBreaker,
    }
    public static class OneHandedWarhammers
    {
        static OneHandedWarhammersNames oneHandedWarhammersNames;
        public static string GenerateOneHandedWarhammerNames()
        {
            string OneHandedWarhammersNamesString = null;
            oneHandedWarhammersNames = (OneHandedWarhammersNames)Random.Range(0, System.Enum.GetValues(typeof(OneHandedWarhammersNames)).Length);
            switch (oneHandedWarhammersNames)
            {
                case OneHandedWarhammersNames.ClawedPick:
                    OneHandedWarhammersNamesString = "Clawed Pick";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.DoubleHeader:
                    OneHandedWarhammersNamesString = "Double Header";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.SkullSinger:
                    OneHandedWarhammersNamesString = "Skull Singer";
                    return OneHandedWarhammersNamesString;
                case OneHandedWarhammersNames.StoneBreaker:
                    OneHandedWarhammersNamesString = "Stone Breaker";
                    return OneHandedWarhammersNamesString;
                default:
                    return "ERROR";
            }
        }
    }
}
