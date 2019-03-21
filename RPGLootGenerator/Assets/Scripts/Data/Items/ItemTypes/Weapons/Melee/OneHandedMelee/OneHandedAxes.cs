using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class OneHandedAxes
    {
        public enum OneHandedAxesPrefixs
        {
            Upper,
            Clothed,
            Rusted,
            Kings,
            Jesters,
            Marked,
        }
        public enum OneHandedAxesNames
        {
            VikingAxe,
            BoneHachet,
            WoodedAxe,
            BloodCleaver,
        }
        public enum OneHandedAxesSuffixs
        {
            OfRetarding,
            OfFrost,
            OfAccelerating,
            OfDestruction,
            OfCursing,
        }
        static OneHandedAxesPrefixs oneHandedAxesPrefixs;
        static OneHandedAxesNames oneHandedAxesNames;
        static OneHandedAxesSuffixs oneHandedAxesSuffixs;
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
                    return "ERROR";
            }
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
                case OneHandedAxesPrefixs.Kings:
                    OneHandedAxesPrefixsString = "Kings";
                    return OneHandedAxesPrefixsString;
                case OneHandedAxesPrefixs.Marked:
                    OneHandedAxesPrefixsString = "Marked";
                    return OneHandedAxesPrefixsString;
                case OneHandedAxesPrefixs.Rusted:
                    OneHandedAxesPrefixsString = "Rusted";
                    return OneHandedAxesPrefixsString;
                case OneHandedAxesPrefixs.Upper:
                    OneHandedAxesPrefixsString = "Upper";
                    return OneHandedAxesPrefixsString;
                default:
                    return "ERROR"; 
            }
        }
        public static string GenerateOneHandedAxesSuffixs()
        {
            string OneHandedAxesSuffixsString = null;
            oneHandedAxesSuffixs = (OneHandedAxesSuffixs)Random.Range(0, System.Enum.GetValues(typeof(OneHandedAxesSuffixs)).Length);
            switch (oneHandedAxesSuffixs)
            {
                case OneHandedAxesSuffixs.OfAccelerating:
                    OneHandedAxesSuffixsString = "Of Accelerating";
                    return OneHandedAxesSuffixsString;
                case OneHandedAxesSuffixs.OfCursing:
                    OneHandedAxesSuffixsString = "Of Cursing";
                    return OneHandedAxesSuffixsString;
                case OneHandedAxesSuffixs.OfDestruction:
                    OneHandedAxesSuffixsString = "Of Destruction";
                    return OneHandedAxesSuffixsString;
                case OneHandedAxesSuffixs.OfFrost:
                    OneHandedAxesSuffixsString = "Of Frost";
                    return OneHandedAxesSuffixsString;
                case OneHandedAxesSuffixs.OfRetarding:
                    OneHandedAxesSuffixsString = "Of Retarding";
                    return OneHandedAxesSuffixsString;
                default:
                    return "ERROR";
            }
        }
    }
}
