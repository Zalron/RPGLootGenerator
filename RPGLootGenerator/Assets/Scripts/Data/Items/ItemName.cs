using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
   
    [CreateAssetMenu(fileName = "Individual Item", menuName = "Item", order = 1)]
    public class ItemName : ScriptableObject
    {
        public string ItemNameString;
        public int itemNameIntModifier;
        public ItemTypes itemType;
    }
}
