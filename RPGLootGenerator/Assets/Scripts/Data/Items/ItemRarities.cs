using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{

    [CreateAssetMenu(fileName = "Individual Item", menuName = "Item", order = 1)]
    public class ItemRarities : ScriptableObject
    {
        public string rarityName;
        public int rarityIntModifier;
    }
}
