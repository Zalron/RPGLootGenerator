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
        public string itemStatOnItemString;
    }
    public static class ItemStatGenerator
    {
        public static int ItemStatGenerators(ItemRarities itemRarities, ItemName itemName, ItemRequirement itemRequirements)
        {
            int ItemStatInt = 0;
            ItemStatInt += itemName.itemNameIntModifier;
            ItemStatInt += itemRarities.rarityIntModifier;
            //ItemStatInt += 
            return ItemStatInt;
        }
    }
}
