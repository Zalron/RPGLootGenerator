﻿using System.Collections;
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
        public static string itemStats;
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
            itemType = ItemTypes.ItemTypeGenerator();
            if (itemType == "One Handed Axe")
            {
                itemRarity = ItemRarity.RarityGenerator();
                if (itemRarity == "Common")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemCombinedName = itemName;
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
                if (itemRarity == "Uncommon" || itemRarity == "Rare" || itemRarity == "Masterwork" || itemRarity == "Legendary" || itemRarity == "Unqiue")
                {
                    itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                    itemPrefix = OneHandedAxes.GenerateOneHandedAxesPrefixs();
                    itemSuffix = OneHandedAxes.GenerateOneHandedAxesSuffixs();
                    itemCombinedName = Name.CombineNameString(itemPrefix, itemName, itemSuffix);
                    itemRequirements = ItemRequirements.RequirementsGenerator();
                }
            }
            //else if (itemType == "One Handed Mace")
            //{
            //    itemName = OneHandedMaces.GenerateOneHandedMacesNames();
            //    itemRarity = ItemRarity.RarityGenerator();
            //    itemRequirements = ItemRequirements.RequirementsGenerator();
            //}
            //else if (itemType == "Short Sword")
            //{
            //    itemName = ShortSword.GenerateShortSwordNames();
            //    itemRarity = ItemRarity.RarityGenerator();
            //    itemRequirements = ItemRequirements.RequirementsGenerator();
            //}
            //else if (itemType == "Two Handed Axes")
            //{
            //    itemName = TwoHandedAxes.GenerateTwoHandedAxesNames();
            //    itemRarity = ItemRarity.RarityGenerator();
            //    itemRequirements = ItemRequirements.RequirementsGenerator();
            //}
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
