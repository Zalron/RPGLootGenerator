using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class OneHandedMaces
    {
        public enum OneHandedMacesNames
        {
            MorningStar,
            BlackJack,
            IronTeeth,
            EnergyCorrector,
            BedeckedJaws,
        }
        static OneHandedMacesNames oneHandedMacesNames;
        public static string GenerateOneHandedMacesNames()
        {
            string OneHandedMacesNamesString = null;
            oneHandedMacesNames = (OneHandedMacesNames)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMacesNames)).Length);
            switch (oneHandedMacesNames)
            {
                case OneHandedMacesNames.EnergyCorrector:
                    OneHandedMacesNamesString = "Energy Corrector";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.BlackJack:
                    OneHandedMacesNamesString = "Black Jack";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.MorningStar:
                    OneHandedMacesNamesString = "Morning Star";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.IronTeeth:
                    OneHandedMacesNamesString = "Iron Teeth";
                    return OneHandedMacesNamesString;
                case OneHandedMacesNames.BedeckedJaws:
                    OneHandedMacesNamesString = "Bedecked Jaws";
                    return OneHandedMacesNamesString;
                default:
                    return null;
            }
            return null;
        }
    }
}