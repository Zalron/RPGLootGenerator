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
            string ItemRequirementsString = null;
            requirements = (Requirements)Random.Range(1, System.Enum.GetValues(typeof(Requirements)).Length);
            switch (requirements)
            {
                case Requirements.Lvl_1:
                    ItemRequirementsString = "Level 1";
                    return ItemRequirementsString;
                case Requirements.Lvl_2:
                    ItemRequirementsString = "Level 2";
                    return ItemRequirementsString;
                case Requirements.Lvl_3:
                    ItemRequirementsString = "Level 3";
                    return ItemRequirementsString;
                case Requirements.Lvl_4:
                    ItemRequirementsString = "Level 4";
                    return ItemRequirementsString;
                case Requirements.Lvl_5:
                    ItemRequirementsString = "Level 5";
                    return ItemRequirementsString;
                case Requirements.Lvl_6:
                    ItemRequirementsString = "Level 6";
                    return ItemRequirementsString;
                case Requirements.Lvl_7:
                    ItemRequirementsString = "Level 7";
                    return ItemRequirementsString;
                case Requirements.Lvl_8:
                    ItemRequirementsString = "Level 8";
                    return ItemRequirementsString;
                case Requirements.Lvl_9:
                    ItemRequirementsString = "Level 9";
                    return ItemRequirementsString;
                case Requirements.Lvl_10:
                    ItemRequirementsString = "Level 10";
                    return ItemRequirementsString;
                case Requirements.Lvl_11:
                    ItemRequirementsString = "Level 11";
                    return ItemRequirementsString;
                case Requirements.Lvl_12:
                    ItemRequirementsString = "Level 12";
                    return ItemRequirementsString;
                case Requirements.Lvl_13:
                    ItemRequirementsString = "Level 13";
                    return ItemRequirementsString;
                case Requirements.Lvl_14:
                    ItemRequirementsString = "Level 14";
                    return ItemRequirementsString;
                case Requirements.Lvl_15:
                    ItemRequirementsString = "Level 15";
                    return ItemRequirementsString;
                case Requirements.Lvl_16:
                    ItemRequirementsString = "Level 16";
                    return ItemRequirementsString;
                case Requirements.Lvl_17:
                    ItemRequirementsString = "Level 17";
                    return ItemRequirementsString;
                case Requirements.Lvl_18:
                    ItemRequirementsString = "Level 18";
                    return ItemRequirementsString;
                case Requirements.Lvl_19:
                    ItemRequirementsString = "Level 19";
                    return ItemRequirementsString;
                case Requirements.Lvl_20:
                    ItemRequirementsString = "Level 20";
                    return ItemRequirementsString;
                case Requirements.Lvl_21:
                    ItemRequirementsString = "Level 21";
                    return ItemRequirementsString;
                case Requirements.Lvl_22:
                    ItemRequirementsString = "Level 22";
                    return ItemRequirementsString;
                case Requirements.Lvl_23:
                    ItemRequirementsString = "Level 23";
                    return ItemRequirementsString;
                case Requirements.Lvl_24:
                    ItemRequirementsString = "Level 24";
                    return ItemRequirementsString;
                case Requirements.Lvl_25:
                    ItemRequirementsString = "Level 25";
                    return ItemRequirementsString;
                case Requirements.Lvl_26:
                    ItemRequirementsString = "Level 26";
                    return ItemRequirementsString;
                case Requirements.Lvl_27:
                    ItemRequirementsString = "Level 27";
                    return ItemRequirementsString;
                case Requirements.Lvl_28:
                    ItemRequirementsString = "Level 28";
                    return ItemRequirementsString;
                case Requirements.Lvl_29:
                    ItemRequirementsString = "Level 29";
                    return ItemRequirementsString;
                case Requirements.Lvl_30:
                    ItemRequirementsString = "Level 30";
                    return ItemRequirementsString;
                case Requirements.Lvl_31:
                    ItemRequirementsString = "Level 31";
                    return ItemRequirementsString;
                case Requirements.Lvl_32:
                    ItemRequirementsString = "Level 32";
                    return ItemRequirementsString;
                case Requirements.Lvl_33:
                    ItemRequirementsString = "Level 33";
                    return ItemRequirementsString;
                case Requirements.Lvl_34:
                    ItemRequirementsString = "Level 34";
                    return ItemRequirementsString;
                case Requirements.Lvl_35:
                    ItemRequirementsString = "Level 35";
                    return ItemRequirementsString;
                case Requirements.Lvl_36:
                    ItemRequirementsString = "Level 36";
                    return ItemRequirementsString;
                case Requirements.Lvl_37:
                    ItemRequirementsString = "Level 37";
                    return ItemRequirementsString;
                case Requirements.Lvl_38:
                    ItemRequirementsString = "Level 38";
                    return ItemRequirementsString;
                case Requirements.Lvl_39:
                    ItemRequirementsString = "Level 39";
                    return ItemRequirementsString;
                case Requirements.Lvl_40:
                    ItemRequirementsString = "Level 40";
                    return ItemRequirementsString;
                case Requirements.Lvl_41:
                    ItemRequirementsString = "Level 41";
                    return ItemRequirementsString;
                case Requirements.Lvl_42:
                    ItemRequirementsString = "Level 42";
                    return ItemRequirementsString;
                case Requirements.Lvl_43:
                    ItemRequirementsString = "Level 43";
                    return ItemRequirementsString;
                case Requirements.Lvl_44:
                    ItemRequirementsString = "Level 44";
                    return ItemRequirementsString;
                case Requirements.Lvl_45:
                    ItemRequirementsString = "Level 45";
                    return ItemRequirementsString;
                case Requirements.Lvl_46:
                    ItemRequirementsString = "Level 46";
                    return ItemRequirementsString;
                case Requirements.Lvl_47:
                    ItemRequirementsString = "Level 47";
                    return ItemRequirementsString;
                case Requirements.Lvl_48:
                    ItemRequirementsString = "Level 48";
                    return ItemRequirementsString;
                case Requirements.Lvl_49:
                    ItemRequirementsString = "Level 49";
                    return ItemRequirementsString;
                case Requirements.Lvl_50:
                    ItemRequirementsString = "Level 50";
                    return ItemRequirementsString;
                case Requirements.Lvl_51:
                    ItemRequirementsString = "Level 51";
                    return ItemRequirementsString;
                case Requirements.Lvl_52:
                    ItemRequirementsString = "Level 52";
                    return ItemRequirementsString;
                case Requirements.Lvl_53:
                    ItemRequirementsString = "Level 53";
                    return ItemRequirementsString;
                case Requirements.Lvl_54:
                    ItemRequirementsString = "Level 54";
                    return ItemRequirementsString;
                case Requirements.Lvl_55:
                    ItemRequirementsString = "Level 55";
                    return ItemRequirementsString;
                case Requirements.Lvl_56:
                    ItemRequirementsString = "Level 56";
                    return ItemRequirementsString;
                case Requirements.Lvl_57:
                    ItemRequirementsString = "Level 57";
                    return ItemRequirementsString;
                case Requirements.Lvl_58:
                    ItemRequirementsString = "Level 58";
                    return ItemRequirementsString;
                case Requirements.Lvl_59:
                    ItemRequirementsString = "Level 59";
                    return ItemRequirementsString;
                case Requirements.Lvl_60:
                    ItemRequirementsString = "Level 60";
                    return ItemRequirementsString;
                case Requirements.Lvl_61:
                    ItemRequirementsString = "Level 61";
                    return ItemRequirementsString;
                case Requirements.Lvl_62:
                    ItemRequirementsString = "Level 62";
                    return ItemRequirementsString;
                case Requirements.Lvl_63:
                    ItemRequirementsString = "Level 63";
                    return ItemRequirementsString;
                case Requirements.Lvl_64:
                    ItemRequirementsString = "Level 64";
                    return ItemRequirementsString;
                case Requirements.Lvl_65:
                    ItemRequirementsString = "Level 65";
                    return ItemRequirementsString;
                case Requirements.Lvl_66:
                    ItemRequirementsString = "Level 66";
                    return ItemRequirementsString;
                case Requirements.Lvl_67:
                    ItemRequirementsString = "Level 67";
                    return ItemRequirementsString;
                case Requirements.Lvl_68:
                    ItemRequirementsString = "Level 68";
                    return ItemRequirementsString;
                case Requirements.Lvl_69:
                    ItemRequirementsString = "Level 69";
                    return ItemRequirementsString;
                case Requirements.Lvl_70:
                    ItemRequirementsString = "Level 70";
                    return ItemRequirementsString;
                case Requirements.Lvl_71:
                    ItemRequirementsString = "Level 71";
                    return ItemRequirementsString;
                case Requirements.Lvl_72:
                    ItemRequirementsString = "Level 72";
                    return ItemRequirementsString;
                case Requirements.Lvl_73:
                    ItemRequirementsString = "Level 73";
                    return ItemRequirementsString;
                case Requirements.Lvl_74:
                    ItemRequirementsString = "Level 74";
                    return ItemRequirementsString;
                case Requirements.Lvl_75:
                    ItemRequirementsString = "Level 75";
                    return ItemRequirementsString;
                case Requirements.Lvl_76:
                    ItemRequirementsString = "Level 76";
                    return ItemRequirementsString;
                case Requirements.Lvl_77:
                    ItemRequirementsString = "Level 77";
                    return ItemRequirementsString;
                case Requirements.Lvl_78:
                    ItemRequirementsString = "Level 78";
                    return ItemRequirementsString;
                case Requirements.Lvl_79:
                    ItemRequirementsString = "Level 79";
                    return ItemRequirementsString;
                case Requirements.Lvl_80:
                    ItemRequirementsString = "Level 80";
                    return ItemRequirementsString;
                case Requirements.Lvl_81:
                    ItemRequirementsString = "Level 81";
                    return ItemRequirementsString;
                case Requirements.Lvl_82:
                    ItemRequirementsString = "Level 82";
                    return ItemRequirementsString;
                case Requirements.Lvl_83:
                    ItemRequirementsString = "Level 83";
                    return ItemRequirementsString;
                case Requirements.Lvl_84:
                    ItemRequirementsString = "Level 84";
                    return ItemRequirementsString;
                case Requirements.Lvl_85:
                    ItemRequirementsString = "Level 85";
                    return ItemRequirementsString;
                case Requirements.Lvl_86:
                    ItemRequirementsString = "Level 86";
                    return ItemRequirementsString;
                case Requirements.Lvl_87:
                    ItemRequirementsString = "Level 87";
                    return ItemRequirementsString;
                case Requirements.Lvl_88:
                    ItemRequirementsString = "Level 88";
                    return ItemRequirementsString;
                case Requirements.Lvl_89:
                    ItemRequirementsString = "Level 89";
                    return ItemRequirementsString;
                case Requirements.Lvl_90:
                    ItemRequirementsString = "Level 90";
                    return ItemRequirementsString;
                case Requirements.Lvl_91:
                    ItemRequirementsString = "Level 91";
                    return ItemRequirementsString;
                case Requirements.Lvl_92:
                    ItemRequirementsString = "Level 92";
                    return ItemRequirementsString;
                case Requirements.Lvl_93:
                    ItemRequirementsString = "Level 93";
                    return ItemRequirementsString;
                case Requirements.Lvl_94:
                    ItemRequirementsString = "Level 94";
                    return ItemRequirementsString;
                case Requirements.Lvl_95:
                    ItemRequirementsString = "Level 95";
                    return ItemRequirementsString;
                case Requirements.Lvl_96:
                    ItemRequirementsString = "Level 96";
                    return ItemRequirementsString;
                case Requirements.Lvl_97:
                    ItemRequirementsString = "Level 97";
                    return ItemRequirementsString;
                case Requirements.Lvl_98:
                    ItemRequirementsString = "Level 98";
                    return ItemRequirementsString;
                case Requirements.Lvl_99:
                    ItemRequirementsString = "Level 99";
                    return ItemRequirementsString;
                case Requirements.Lvl_100:
                    ItemRequirementsString = "Level 100";
                    return ItemRequirementsString;
                default:
                    ItemRequirementsString = "ERROR";
                    return ItemRequirementsString;
            }
        }
    }
}
