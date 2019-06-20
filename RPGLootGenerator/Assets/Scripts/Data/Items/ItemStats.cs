using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{

    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
        public int itemStatInt;
        public string itemStatOnItemString;
        public bool isPercentage;
        public static int ItemStatGenerators(ItemRarities itemRarities, ItemName itemName, ItemMod itemMod, ItemRequirements itemRequirement)
        {
            int ItemStatInt = 0;
            ItemStatInt += itemName.itemNameIntModifier;
            ItemStatInt += itemRarities.rarityIntModifier;
            ItemStatInt += itemRequirement.ItemLevelModifier;
            ItemStatInt += itemMod.itemModIntModifier;
            return ItemStatInt;
        }
    }
}
