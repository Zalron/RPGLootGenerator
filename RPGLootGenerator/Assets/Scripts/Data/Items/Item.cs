using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class Item
    {
        public static string itemCombinedName;
        public static string itemPrefix;
        public static string itemName;
        public static string itemSuffix;
        public static string itemRarity;
        public static string itemType;
        public static string itemRequirements;
        public static string itemStats1;
        public static string itemStats2;
        public static string itemStats3;
        public static string itemStats4;
        public static string itemStats5;
        public static string itemStats6;
        public static string itemImplisits;
        public static string itemExplisits;
        //public Item(string itemName, string itemPrefix, string itemSuffix, string itemRarity, string itemType, string itemRequirements)
        //{
        //    itemName = name;
        //    itemPrefix =
        //    prefix = itemSuffix;
        //    string combineditemName = itemPrefix + " " + itemName + " " + itemSuffix;
        //}

        public static void ItemGenerator()
        {
            itemType = "";
            itemName = "";
            itemRarity = "";
            itemRequirements = "";
            itemCombinedName = "";
            itemType = ItemTypes.ItemTypeGenerator();
            if (itemType == "One Handed Axe")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemPrefix = Affixs.GeneratePrefixs();
                    itemSuffix = Affixs.GenerateSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
            }
            else if (itemType == "One Handed Mace")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedMaces.GenerateOneHandedMacesNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedMaces.GenerateOneHandedMacesNames();
                    itemPrefix = Affixs.GeneratePrefixs();
                    itemSuffix = Affixs.GenerateSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
            }
            else if (itemType == "Short Sword")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = ShortSword.GenerateShortSwordNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = ShortSword.GenerateShortSwordNames();
                    itemPrefix = Affixs.GeneratePrefixs();
                    itemSuffix = Affixs.GenerateSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
            }
            else if (itemType == "Two Handed Axes")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = TwoHandedAxes.GenerateTwoHandedAxesNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = TwoHandedAxes.GenerateTwoHandedAxesNames();
                    itemPrefix = Affixs.GeneratePrefixs();
                    itemSuffix = Affixs.GenerateSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
            }
            else if (itemType == "One Handed Warhammer")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedWarhammers.GenerateOneHandedWarhammerNames(); ;
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedWarhammers.GenerateOneHandedWarhammerNames();
                    itemPrefix = Affixs.GeneratePrefixs();
                    itemSuffix = Affixs.GenerateSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                    itemStats1 = ItemStats.AttackSpeedGenerator(itemRarity);
                    itemStats2 = ItemStats.CriticalChanceGenerator(itemRarity);
                    itemStats3 = ItemStats.MagicalDamageGenerator(itemRarity);
                    itemStats4 = ItemStats.PhysicalDamageGenerator(itemRarity);
                }
            }
            else
            {
                itemType = "Not Done Yet";
                itemName = "Not Done Yet";
                itemRarity = "Not Done Yet";
                itemRequirements = "Not Done Yet";
            }
        }
    }
}
