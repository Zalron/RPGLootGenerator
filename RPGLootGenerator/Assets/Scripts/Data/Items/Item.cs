using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item : MonoBehaviour
    {
        public string itemCombinedName;
        public string itemPrefix1;
        public string itemPrefix2;
        public string itemPrefix3;
        public ItemTypeName itemName;
        public string itemSuffix1;
        public string itemSuffix2;
        public string itemSuffix3;
        public string itemRarity;
        public string itemType;
        public string itemRequirements;
        public string itemStats1;
        public string itemStats2;
        public string itemStats3;
        public string itemStats4;
        public string itemStats5;
        public string itemStats6;
        public string itemImplisits;
        public string itemExplisits;
        public Item(ItemTypeName itemName, 
                    string itemPrefix1, 
                    string itemSuffix1,
                    string itemCombinedName,
                    string itemRarity, 
                    string itemType, 
                    string itemRequirements)
        {
            this.itemName = itemName;
            this.itemPrefix1 = itemPrefix1;
            this.itemSuffix1 = itemSuffix1;
            this.itemRarity = itemRarity;
            this.itemType = itemType;
            this.itemRequirements = itemRequirements;
            this.itemCombinedName = itemCombinedName;
        }
        public void ItemGenerator()
        {
            itemName = ItemName.GenerateOneHandedAxesNames();
            string itemNameString = ConvertString.ItemTypeGenerator(itemName);
            itemRarity = ItemRarity.RarityGenerator();
            if (itemRarity == "Common")
            {

                itemCombinedName = itemNameString;
            }
            if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
            {
                itemPrefix1 = Affixs.GeneratePrefixs();
                itemSuffix1 = Affixs.GenerateSuffixs();
                itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemNameString, itemSuffix1);
            }
            itemRequirements = ItemRequirements.RequirementsGenerator();
            itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
            itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
            itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
            itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);

        }
    }
}
