using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{

    [CreateAssetMenu(fileName =  "Item", menuName = "Item Rarity", order = 1)]
    public class ItemRarities : ScriptableObject
    {
        public string rarityName;
        public int rarityIntModifier;
    }
}
