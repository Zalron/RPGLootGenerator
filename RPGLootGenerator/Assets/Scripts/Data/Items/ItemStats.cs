using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{

    [CreateAssetMenu(fileName = "Item", menuName = "Item Stats", order = 1)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
        public string itemStatOnItemString;
    }
    public static class ItemStatGenerator
    {
        public static int ItemStatGenerators(ItemRarities itemRarities, ItemName itemName)
        {
            int ItemStatInt = 0;
            ItemStatInt += itemName.itemNameIntModifier;
            ItemStatInt += itemRarities.rarityIntModifier;
            //ItemStatInt += 
            return ItemStatInt;
        }
    }
}
