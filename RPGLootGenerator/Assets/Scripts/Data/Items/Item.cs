using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public class Item
    {
        public string prefix;
        public string name;
        public string suffix;
        public string rarity;
        public string type;
        public string requirements;

        //public Item(string itemName, string itemPrefix, string itemSuffix, string itemRarity, string itemType, string itemRequirements)
        //{
        //    itemName = name;
        //    itemPrefix =
        //    prefix = itemSuffix;
        //    string combineditemName = itemPrefix + " " + itemName + " " + itemSuffix;
        //}

        public void ItemTypeGenerator()
        {
            
            
            switch ()
            { 
                case 1:
                    type = "";
                    break;
                default:
                    type = "error";
                    break;
            }
            
        }
    }
}
