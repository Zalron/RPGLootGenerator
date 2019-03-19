using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
       
        public string itemPrefix;
        public string itemName;
        public string itemSuffix;
        public string itemRarity;
        public string itemType;
        public string itemRequirements;
        public string itemStats;
        public string itemImplisits;
        public string itemExplisits;
        //public Item(string itemName, string itemPrefix, string itemSuffix, string itemRarity, string itemType, string itemRequirements)
        //{
        //    itemName = name;
        //    itemPrefix =
        //    prefix = itemSuffix;
        //    string combineditemName = itemPrefix + " " + itemName + " " + itemSuffix;
        //}

        public void ItemGenerator()
        {


            itemType = ItemTypes.ItemTypeGenerator();

            if(itemType == "One Handed Axes")
            {
                itemName = OneHandedAxes.GenerateOneHandedAxesNames();
                itemRarity = ItemRarity.RarityGenerate();
            }
            else if (itemType == "") 
            {

            }
        }
    }
}
