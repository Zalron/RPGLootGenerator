using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class Item : ScriptableObject
    {
        #region Item Variables
        public ItemName itemName;
        public string itemCombinedNameString;
        public ItemRarities itemRarity;
        public ItemRequirements itemRequirements;
        public ItemStats itemStat1;
        public ItemStats itemStat2;
        public ItemStats itemStat3;
        public ItemStats itemStat4;
        public ItemStats itemStat5;
        public ItemStats itemStat6;
        public ItemAffixs itemPrefixs1;
        public ItemAffixs itemPrefixs2;
        public ItemAffixs itemPrefixs3;
        public ItemAffixs itemSuffixs1;
        public ItemAffixs itemSuffixs2;
        public ItemAffixs itemSuffixs3;
        public ItemMod itemMod1;
        public ItemMod itemMod2;
        public ItemMod itemMod3;
        public ItemMod itemMod4;
        public ItemMod itemMod5;
        public ItemMod itemMod6;
        #endregion
        public Item ItemGenerator(ItemName[] itemNameDropTable, ItemAffixs[] itemAffixsDropTable, ItemStats[] itemStatDropTable, ItemRarities[] itemRarityDropTable, ItemRequirements[] itemRequirements, ItemMod[] itemModDropTable)
        {
            Item i = null;
            int itemNameDropTableNumber = Random.Range(0,itemNameDropTable.Length);
            i.itemName = itemNameDropTable[itemNameDropTableNumber];
            int itemRarityDropTableNumber = Random.Range(0,itemRarityDropTable.Length);
            i.itemRarity = itemRarityDropTable[itemRarityDropTableNumber];
            if(i.itemRarity.rarityIntAffixsAllowed == 0)
            {
                i.itemPrefixs1 = null;
                i.itemPrefixs2 = null;
                i.itemPrefixs3 = null;
                i.itemSuffixs1 = null;
                i.itemSuffixs2 = null;
                i.itemSuffixs3 = null;
                i.itemCombinedNameString = CombineNameString(itemPrefixs1.itemAffixString, itemName.ItemNameString, itemSuffixs1.itemAffixString);
            }
            int itemRequirementsDropTableNumber = Random.Range(0,itemRequirementsDropTable.Length);
            i.itemRequirements = itemRequirementsDropTable[itemRequirementsDropTableNumber];
            return i;
            
        }
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
        
    }
}
