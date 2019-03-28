using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ShortSwordNames
    {
        BronzeKopis,
        TutonicSword,
        DustKhopesh,
        SteelGladius,
        ObsidianMaquahuitl,
    }
    public static class ShortSwords
    {
        static ShortSwordNames shortSwordNames;
        public static string GenerateShortSwordNames()
        {
            string ShortSwordNamesString = null;
            shortSwordNames = (ShortSwordNames)Random.Range(0, System.Enum.GetValues(typeof(ShortSwordNames)).Length);
            switch (shortSwordNames)
            {
                case ShortSwordNames.BronzeKopis:
                    ShortSwordNamesString = "Bronze Kopis";
                    return ShortSwordNamesString;
                case ShortSwordNames.DustKhopesh:
                    ShortSwordNamesString = "Dust Khopesh";
                    return ShortSwordNamesString;
                case ShortSwordNames.ObsidianMaquahuitl:
                    ShortSwordNamesString = "Obsidian Maquahuitl";
                    return ShortSwordNamesString;
                case ShortSwordNames.SteelGladius:
                    ShortSwordNamesString = "Steel Gladius";
                    return ShortSwordNamesString;
                default:
                    return "ERROR";
            }
        }

    }
}
