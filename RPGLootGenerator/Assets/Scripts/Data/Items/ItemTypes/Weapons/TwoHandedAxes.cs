using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TwoHandedAxesNames
{
    VikingAxe,
    BoneHachet,
    WoodedAxe,
    BloodCleaver,
}
public static class TwoHandedAxes
{
    static TwoHandedAxesNames oneHandedAxesNames;
    public static void GenerateOneHandedAxesNames(string AxeName)
    {
        oneHandedAxesNames = (TwoHandedAxesNames)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedAxesNames)).Length);
        switch (oneHandedAxesNames)
        {
            case TwoHandedAxesNames.BloodCleaver:
                AxeName = "BloodCleaver";
                break;
            case TwoHandedAxesNames.BoneHachet:
                AxeName = "BoneHachet";
                break;
            case TwoHandedAxesNames.VikingAxe:
                AxeName = "BoneHachet";
                break;
            case TwoHandedAxesNames.WoodedAxe:
                AxeName = "BoneHachet";
                break;
            default:
                break;
        }
    }
}
