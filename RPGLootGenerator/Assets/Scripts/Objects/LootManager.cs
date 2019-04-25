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
        public Item item;
        void Start() // Start is called before the first frame update
        {

        }
        void Update() // Update is called once per frame
        {

        }
        public void GenerateLoot()
        {
            //LootRarity.text = ItemRarity.RarityGenerator();
            //LootTypes.text = ItemTypes.ItemTypeGenerator();

            item.ItemGenerator();
            LootTypes.text = item.itemTypeString;
            LootRarity.text = item.itemRarityString;
            LootNames.text = item.itemCombinedName;
            LootRequirements.text = item.itemRequirements;
            LootStats1.text = item.itemStats1;
            LootStats2.text = item.itemStats2;
            LootStats3.text = item.itemStats3;
            LootStats4.text = item.itemStats4;
            LootStats5.text = item.itemStats5;
            LootStats6.text = item.itemStats6;
        }
    }
}
