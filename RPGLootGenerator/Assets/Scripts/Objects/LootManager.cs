using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace RPGLootGenerator
{
    public class LootManager : MonoBehaviour
    {
        public TextMeshProUGUI LootNames;
        public TextMeshProUGUI LootRarity;
        public TextMeshProUGUI LootTypes;
        public TextMeshProUGUI LootRequirements;
        public TextMeshProUGUI LootStats1;
        public TextMeshProUGUI LootStats2;
        public TextMeshProUGUI LootStats3;
        public TextMeshProUGUI LootStats4;
        public TextMeshProUGUI LootStats5;
        public TextMeshProUGUI LootStats6;
        public TextMeshProUGUI LootMods1;
        public TextMeshProUGUI LootMods2;
        public TextMeshProUGUI LootMods3;
        public TextMeshProUGUI LootMods4;
        public TextMeshProUGUI LootMods5;
        public TextMeshProUGUI LootMods6;

        public ItemMod[] itemModDropTable;
        public ItemRequirements[] itemRequirements;
        public ItemRarities[] itemRarityDropTable;
        public ItemName[] itemNameDropTable;
        public ItemAffixs[] itemAffixsDropTable;
        public ItemStats[] itemStatDropTable;

        public List<Item> items = new List<Item>();
        void Start() // Start is called before the first frame update
        {

        }
        void Update() // Update is called once per frame
        {

        }
        public void GenerateRawLoot()
        {

            Item i = new Item();
            i = i.ItemGenerator(itemNameDropTable, itemAffixsDropTable, itemStatDropTable, itemRarityDropTable, itemRequirements, itemModDropTable);
            items.Add(i);
            LootNames.text = i.itemCombinedNameString;
            LootRarity.text = i.itemRarity.rarityName;
            LootTypes.text = i.itemName.itemType.ItemTypeName;
            LootRequirements.text = i.itemRequirements.ItemLevelString;
            LootStats1.text = i.itemStat1.itemStatOnItemString;
            LootStats2.text = i.itemStat2.itemStatOnItemString;
            LootStats3.text = i.itemStat3.itemStatOnItemString;
            LootStats4.text = i.itemStat4.itemStatOnItemString;
            LootStats5.text = i.itemStat5.itemStatOnItemString;
            LootStats6.text = i.itemStat6.itemStatOnItemString;
            LootMods1.text = i.itemMod1.itemModDescriptionString;
            LootMods2.text = i.itemMod2.itemModDescriptionString;
            LootMods3.text = i.itemMod3.itemModDescriptionString;
            LootMods4.text = i.itemMod4.itemModDescriptionString;
            LootMods5.text = i.itemMod5.itemModDescriptionString;
            LootMods6.text = i.itemMod6.itemModDescriptionString;

        }
    }
}
