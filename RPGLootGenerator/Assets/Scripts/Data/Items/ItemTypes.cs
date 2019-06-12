using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemSubType
    {
        Weapon_Melee_OneHanded,
        Weapon_Melee_TwoHanded,
        Weapon_Ranged_OneHanded,
        Weapon_Ranged_TwoHanded,
        Armour_PowerArmour,
        Armour_NonPowerArmour,
        Currency,
        Equipment,
        Spells,
    }
    [CreateAssetMenu(fileName = "Item Stats", menuName = "Item", order = 2)]
    public class ItemTypes : ScriptableObject
    {
        public string ItemTypeName;
        public int ItemTypeIntModifier;
        public ItemSubType itemSubType;
    }
}
