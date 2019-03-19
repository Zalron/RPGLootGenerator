using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class OneHandedAxes
    {
        public enum OneHandedAxesNames
        {
            VikingAxe,
            BoneHachet,
            WoodedAxe,
            BloodCleaver,
        }
        public enum OneHandedAxesPrefixs 
        {
            Upper,
            Clothed,
            Rusted,
            Kings,
            Jesters,
            Marked,
        }
        static OneHandedAxesNames oneHandedAxesNames;
        static OneHandedAxesPrefixs oneHandedAxesPrefixs;
        public static string GenerateOneHandedAxesNames()
        {
            string OneHandedAxesNamesString = null;
            oneHandedAxesNames = (OneHandedAxesNames)Random.Range(0, System.Enum.GetValues(typeof(OneHandedAxesNames)).Length);
            switch (oneHandedAxesNames)
            {
                case OneHandedAxesNames.BloodCleaver:
                    OneHandedAxesNamesString = "Blood Cleaver";
                    return OneHandedAxesNamesString;
                case OneHandedAxesNames.BoneHachet:
                    OneHandedAxesNamesString = "Bone Hachet";
                    return OneHandedAxesNamesString;
                case OneHandedAxesNames.VikingAxe:
                    OneHandedAxesNamesString = "Viking Axe";
                    return OneHandedAxesNamesString;
                case OneHandedAxesNames.WoodedAxe:
                    OneHandedAxesNamesString = "Wooded Axe";
                    return OneHandedAxesNamesString;
                default:
                    break;
            }
            return null;
        }
        public static string GenerateOneHandedAxesPrefixs()
        {
            string OneHandedAxesPrefixsString = null;
            oneHandedAxesPrefixs = (OneHandedAxesPrefixs)Random.Range(0, System.Enum.GetValues(typeof(OneHandedAxesPrefixs)).Length);
            switch (oneHandedAxesPrefixs) 
            {
                case OneHandedAxesPrefixs.Clothed:
                    OneHandedAxesPrefixsString = "Clothed";
                    return OneHandedAxesPrefixsString;
                case OneHandedAxesPrefixs.Jesters:
                    OneHandedAxesPrefixsString = "Jesters";
                    return OneHandedAxesPrefixsString;
                default:
                    return null; 
            }

        }
    }
}
