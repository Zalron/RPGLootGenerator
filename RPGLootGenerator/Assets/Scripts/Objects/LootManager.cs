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
        public TextMeshProUGUI LootMods;

        public List<Item> items = new List<Item>();
        void Start() // Start is called before the first frame update
        {

        }
        void Update() // Update is called once per frame
        {

        }
        public void GenerateRawLoot()
        {
            Item i = new Item(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
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
