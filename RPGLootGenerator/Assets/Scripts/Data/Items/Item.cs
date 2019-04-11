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
        public string itemName;
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
        public Item(string itemName, string itemPrefix, string itemSuffix, string itemRarity, string itemType, string itemRequirements)
        {
            itemName = this.itemName;
            itemPrefix = this.itemPrefix1;
            //prefix = itemSuffix;
            itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
        }
        public void ItemGenerator()
        {
            itemType = ItemTypes.ItemTypeGenerator();
            if (itemType == "One Handed Axe")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemCombinedName = itemName;
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemPrefix1 = Affixs.GeneratePrefixs();
                    itemSuffix1 = Affixs.GenerateSuffixs();
                    itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemName, itemSuffix1);
                }
                itemRequirements = ItemRequirements.RequirementsGenerator();
                itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
            }
            else if (itemType == "One Handed Mace")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedMaces.GenerateOneHandedMacesNames();
                    itemCombinedName = itemName;
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedMaces.GenerateOneHandedMacesNames();
                    itemPrefix1 = Affixs.GeneratePrefixs();
                    itemSuffix1 = Affixs.GenerateSuffixs();
                    itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemName, itemSuffix1);
                }
                itemRequirements = ItemRequirements.RequirementsGenerator();
                itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
            }
            else if (itemType == "Short Sword")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = ShortSwords.GenerateShortSwordNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = ShortSwords.GenerateShortSwordNames();
                    itemPrefix1 = Affixs.GeneratePrefixs();
                    itemSuffix1 = Affixs.GenerateSuffixs();
                    itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemName, itemSuffix1);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
            }
            else if (itemType == "Two Handed Axes")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = TwoHandedAxes.GenerateTwoHandedAxesNames();
                    itemCombinedName = itemName;
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = TwoHandedAxes.GenerateTwoHandedAxesNames();
                    itemPrefix1 = Affixs.GeneratePrefixs();
                    itemSuffix1 = Affixs.GenerateSuffixs();
                    itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemName, itemSuffix1);
                }
                itemRequirements = ItemRequirements.RequirementsGenerator();
                itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
            }
            else if (itemType == "One Handed Warhammer")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedWarhammers.GenerateOneHandedWarhammerNames(); ;
                    itemCombinedName = itemName;
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedWarhammers.GenerateOneHandedWarhammerNames();
                    itemPrefix1 = Affixs.GeneratePrefixs();
                    itemSuffix1 = Affixs.GenerateSuffixs();
                    itemCombinedName = ConvertString.CombineNameString(itemPrefix1, itemName, itemSuffix1);
                }
                itemRequirements = ItemRequirements.RequirementsGenerator();
                itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
            }
            else
            {
                itemType = "";
                itemName = "";
                itemCombinedName = "";
                itemRarity = "";
                itemRequirements = "";
                itemStats1 = "";
                itemStats2 = "";
                itemStats3 = "";
                itemStats4 = "";
                itemStats5 = "";
                itemStats6 = "";
            }
        }
    }
}
