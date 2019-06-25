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
        public Item ItemModStatGenerator(Item i, ItemStats itemStat, ItemMod itemMod1, ItemMod itemMod2, ItemMod itemMod3, ItemMod itemMod4, ItemMod itemMod5, ItemMod itemMod6)
        {
            if (itemMod1.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod1);
            }
            else if (itemMod2.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod2);
            }
            else if (itemMod3.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod3);
            }
            else if (itemMod4.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod4);
            }
            else if (itemMod5.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod5);
            }
            else if (itemMod6.itemStatModifiying == itemStat)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod6);
            }
            return i;
        }
        public static int ItemStatGenerators( ItemName itemName, ItemTypes itemType, ItemRarities itemRarities, ItemRequirements itemRequirement, ItemMod itemMod)
        {
            int ItemStatInt = 0;
            ItemStatInt += itemName.itemNameIntModifier;
            ItemStatInt += itemType.itemTypeIntModifier;
            ItemStatInt += itemRarities.rarityIntModifier;
            ItemStatInt += itemRequirement.ItemLevelModifier;
            ItemStatInt += itemMod.itemModIntModifier;
            return ItemStatInt;
        }

    }
}
