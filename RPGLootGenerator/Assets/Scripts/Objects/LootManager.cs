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

            Item.ItemGenerator();
            LootTypes.text = Item.itemType;
            LootRarity.text = Item.itemRarity;
            LootNames.text = Item.itemCombinedName;
            LootRequirements.text = Item.itemRequirements;
            LootStats1.text = Item.itemStats1;
            LootStats2.text = Item.itemStats2;
            LootStats3.text = Item.itemStats3;
            LootStats4.text = Item.itemStats4;
            LootStats5.text = Item.itemStats5;
            LootStats6.text = Item.itemStats6;
        }
    }
}
