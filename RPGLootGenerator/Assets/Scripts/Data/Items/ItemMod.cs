using UnityEngine;
using System.Collections;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Mod", order = 1)]
    public class ItemMod : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public string itemModOnItemString;
        public int itemModIntModifier;
        public ItemStats itemStatModifiying;
        public Item SetItemMods(Item i, ItemAffixs itemAffix)
        {
            if (i.itemMod1 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else if (i.itemMod2 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else if (i.itemMod3 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else if (i.itemMod4 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else if (i.itemMod5 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else if (i.itemMod6 = itemAffix.itemMod)
            {
                itemAffix.itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemAffix.itemMod.itemModIntModifier, itemAffix.itemMod.itemModDescriptionString);
                return i;
            }
            else
            {
                return i;
            }
        }
    }
    
}
