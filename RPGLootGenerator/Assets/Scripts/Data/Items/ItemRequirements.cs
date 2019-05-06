using UnityEngine;
namespace RPGLootGenerator
{
    public enum Requirements
    {
        Lvl_1 = 1, Lvl_2 = 2, Lvl_3 = 3, Lvl_4 = 4, Lvl_5 = 5, Lvl_6 = 6, Lvl_7 = 7, Lvl_8 = 8, Lvl_9 = 9,
        Lvl_10 = 10, Lvl_11 = 11, Lvl_12 = 12, Lvl_13 = 13, Lvl_14 = 14, Lvl_15 = 15, Lvl_16 = 16, Lvl_17 = 17, Lvl_18 = 18, Lvl_19 = 19,
        Lvl_20 = 20, Lvl_21 = 21, Lvl_22 = 22, Lvl_23 = 23, Lvl_24 = 24, Lvl_25 = 25, Lvl_26 = 26, Lvl_27 = 27, Lvl_28 = 28, Lvl_29 = 29,
        Lvl_30 = 30, Lvl_31 = 31, Lvl_32 = 32, Lvl_33 = 33, Lvl_34 = 34, Lvl_35 = 35, Lvl_36 = 36, Lvl_37 = 37, Lvl_38 = 38, Lvl_39 = 39,
        Lvl_40 = 40, Lvl_41 = 41, Lvl_42 = 42, Lvl_43 = 43, Lvl_44 = 44, Lvl_45 = 45, Lvl_46 = 46, Lvl_47 = 47, Lvl_48 = 48, Lvl_49 = 49,
        Lvl_50 = 50, Lvl_51 = 51, Lvl_52 = 52, Lvl_53 = 53, Lvl_54 = 54, Lvl_55 = 55, Lvl_56 = 56, Lvl_57 = 57, Lvl_58 = 58, Lvl_59 = 59,
        Lvl_60 = 60, Lvl_61 = 61, Lvl_62 = 62, Lvl_63 = 63, Lvl_64 = 64, Lvl_65 = 65, Lvl_66 = 66, Lvl_67 = 67, Lvl_68 = 68, Lvl_69 = 69,
        Lvl_70 = 70, Lvl_71 = 71, Lvl_72 = 72, Lvl_73 = 73, Lvl_74 = 74, Lvl_75 = 75, Lvl_76 = 76, Lvl_77 = 77, Lvl_78 = 78, Lvl_79 = 79,
        Lvl_80 = 80, Lvl_81 = 81, Lvl_82 = 82, Lvl_83 = 83, Lvl_84 = 84, Lvl_85 = 85, Lvl_86 = 86, Lvl_87 = 87, Lvl_88 = 88, Lvl_89 = 89,
        Lvl_90 = 90, Lvl_91 = 91, Lvl_92 = 92, Lvl_93 = 93, Lvl_94 = 94, Lvl_95 = 95, Lvl_96 = 96, Lvl_97 = 97, Lvl_98 = 98, Lvl_99 = 99,
        Lvl_100 = 100,
    }
    public static class ItemRequirements
    {
        static Requirements requirements;
        public static string RequirementsGenerator()
        {
            requirements = (Requirements)Random.Range(1, System.Enum.GetValues(typeof(Requirements)).Length);
        }
    }
}
