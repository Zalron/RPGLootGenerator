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
        static OneHandedAxesNames oneHandedAxesNames;
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
        public static void GenerateOneHandedAxesStats()
        {
            string OneHandedAxesStats1;
            
        }
    }
}
