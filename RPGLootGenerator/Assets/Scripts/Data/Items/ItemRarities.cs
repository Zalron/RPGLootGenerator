using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{

    [CreateAssetMenu(fileName =  "Item", menuName = "Item/Item Rarity", order = 1)]
    public class ItemRarities : ScriptableObject
    {
        public string rarityName;
        public int rarityIntModifier;
        public int rarityIntAffixsAllowed;
        public Item RarityAffixGenerator(Item i, ItemAffixs[] itemPrefixDropTable, ItemAffixs[] itemSuffixDropTable)
        {
            int itemAffixSort;
            int itemPrefixDropTableNumber1;
            int itemPrefixDropTableNumber2;
            int itemPrefixDropTableNumber3;
            int itemSuffixDropTableNumber1;
            int itemSuffixDropTableNumber2;
            int itemSuffixDropTableNumber3;
            switch (i.itemRarity.rarityIntAffixsAllowed)
            {
                case 0:
                    i.itemPrefixs1 = null;
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemSuffixs1 = null;
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    return i;
                case 1:
                    itemAffixSort = Random.Range(1, 2);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                        i.itemSuffixs1 = null;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs1 = null;
                        i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    }
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    return i;
                case 2:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    return i;
                case 3:
                    itemAffixSort = Random.Range(1, 2);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                        i.itemSuffixs2 = null;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs2 = null;
                        i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemPrefixs3 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemSuffixs2 = null;
                    return i;
                case 4:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemPrefixs3 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemSuffixs3 = null;
                    return i;
                case 5:
                    itemAffixSort = Random.Range(1, 2);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                        i.itemSuffixs3 = null;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs3 = null;
                        i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    return i;
                case 6:
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    return i;
                default:
                    return null;
            }
        }
    }
}
