using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum OneHandedAxesNames
    {
        VikingAxe,
        BoneHachet,
        WoodedAxe,
        BloodCleaver,
    }
    public static class OneHandedAxes
    {
        static OneHandedAxesNames oneHandedAxesNames;
        public static void GenerateOneHandedAxesNames(string AxeName)
        {
            oneHandedAxesNames = (OneHandedAxesNames)Random.Range(0, System.Enum.GetValues(typeof(OneHandedAxesNames)).Length);
            switch (oneHandedAxesNames)
            {
                case OneHandedAxesNames.BloodCleaver:
                    AxeName = "BloodCleaver";
                    break;
                case OneHandedAxesNames.BoneHachet:
                    AxeName = "BoneHachet";
                    break;
                case OneHandedAxesNames.VikingAxe:
                    AxeName = "BoneHachet";
                    break;
                case OneHandedAxesNames.WoodedAxe:
                    AxeName = "BoneHachet";
                    break;
                default:
                    break;
            }
        }
    }
}
