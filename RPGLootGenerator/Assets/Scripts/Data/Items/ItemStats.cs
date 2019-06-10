using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemStatType
    {
        CountStart,
        AttackSpeed,
        CriticalChance,
        PhysicalDamage,
        MagicalDamage,
        Armour,
        BlockChance,
        MagicGeneration,
        MovementSpeed,
        Evasion,
        ReloadSpeed,
        MagazineSize,
        CountEnd,
    }
    [CreateAssetMenu(fileName = "Item Stats", menuName = "Item", order = 2)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
    }
    public static class ItemStatGenerator
    {
        public static int ItemStatGenerators(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
        {
            int ItemStatInt;
            //ItemStatInt +=
            return ItemStatInt;
        }
    }
}
