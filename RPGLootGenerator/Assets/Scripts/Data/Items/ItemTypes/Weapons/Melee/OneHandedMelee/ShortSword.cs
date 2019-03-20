using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ShortSword
    {
        public enum ShortSwordNames
        {
            BronzeKopis,
            TutonicSword,
            DustKhopesh,
            SteelGladius,
            ObsidianMaquahuitl,
        }
        static ShortSwordNames shortSwordNames;
        public static string GenerateShortSwordNames()
        {
            string ShortSwordNamesString = null;
            shortSwordNames = (ShortSwordNames)Random.Range(0, System.Enum.GetValues(typeof(ShortSwordNames)).Length);
            switch (shortSwordNames)
            {
                case ShortSwordNames.BronzeKopis:
                    ShortSwordNamesString = "Demons Malice";
                    return ShortSwordNamesString;
                case ShortSwordNames.DustKhopesh:
                    ShortSwordNamesString = "LandHowiter";
                    return ShortSwordNamesString;
                case ShortSwordNames.ObsidianMaquahuitl:
                    ShortSwordNamesString = "Battle Axe";
                    return ShortSwordNamesString;
                case ShortSwordNames.SteelGladius:
                    ShortSwordNamesString = "Golden Reaver";
                    return ShortSwordNamesString;
                default:
                    return "ERROR";
            }
        }

    }
}
