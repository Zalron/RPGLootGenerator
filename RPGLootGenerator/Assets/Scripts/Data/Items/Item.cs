using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item", order = 1)]
    public class Item : ScriptableObject
    {
        #region Item Variables
        public ItemName itemName;
        public ItemTypes itemType;
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
        public Item ItemGenerator(ItemName[] itemNameDropTable, ItemAffixs[] itemPrefixDropTable, ItemAffixs[] itemSuffixDropTable, ItemStats[] itemStatDropTable, ItemRarities[] itemRarityDropTable, ItemRequirements[] itemRequirementsDropTable, ItemMod[] itemModDropTable)
        {
            Item i = null;
            if (itemNameDropTable == null || itemPrefixDropTable == null || itemSuffixDropTable == null || itemStatDropTable == null || itemRarityDropTable == null || itemRequirementsDropTable == null || itemModDropTable == null)
            {
                Debug.Log("A table doesn't have anything in it");
            }
            int itemNameDropTableNumber = Random.Range(0,itemNameDropTable.Length);
            i.itemName = itemNameDropTable[itemNameDropTableNumber];
            i.itemType = i.itemName.itemType;
            int itemRarityDropTableNumber = Random.Range(0,itemRarityDropTable.Length);
            i.itemRarity = itemRarityDropTable[itemRarityDropTableNumber];
            i = itemRarity.RarityAffixGenerator(i, itemPrefixDropTable, itemSuffixDropTable);
            int itemRequirementsDropTableNumber = Random.Range(0,itemRequirementsDropTable.Length);
            i.itemRequirements = itemRequirementsDropTable[itemRequirementsDropTableNumber];
            i.itemMod1 = i.itemPrefixs1.itemMod;
            i.itemMod2 = i.itemSuffixs1.itemMod;
            i.itemMod3 = i.itemPrefixs2.itemMod;
            i.itemMod4 = i.itemSuffixs2.itemMod;
            i.itemMod5 = i.itemPrefixs3.itemMod;
            i.itemMod6 = i.itemSuffixs3.itemMod;
            i.itemStat1 = itemStatDropTable[0];
            i.itemStat2 = itemStatDropTable[1];
            i.itemStat3 = itemStatDropTable[2];
            i.itemStat4 = itemStatDropTable[3];
            i = itemStat1.ItemModStatGenerator(i, i.itemStat1, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i = itemStat2.ItemModStatGenerator(i, i.itemStat2, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i = itemStat3.ItemModStatGenerator(i, i.itemStat3, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i = itemStat4.ItemModStatGenerator(i, i.itemStat4, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            return i;
            
        }
       
        
    }
}
