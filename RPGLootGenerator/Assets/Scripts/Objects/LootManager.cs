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
            items.Add(i);
            LootNames.text = i.itemCombinedNameString;
            LootRarity.text = i.itemRarityString;
            LootTypes.text = i.itemTypeString;
            LootRequirements.text = i.itemRequirementsString;
            LootStats1.text = i.itemStats1String;
            LootStats2.text = i.itemStats2String;
            LootStats3.text = i.itemStats3String;
            LootStats4.text = i.itemStats4String;
            LootStats5.text = i.itemStats5String;
            LootStats6.text = i.itemStats6String;
        }
    }
}
