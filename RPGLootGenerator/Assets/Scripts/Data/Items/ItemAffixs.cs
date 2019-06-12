using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemAffix
    {
        Preffix,
        Suffix
    }
    [CreateAssetMenu(fileName = "Item Stats", menuName = "Item", order = 2)]
    public class ItemAffixs : ScriptableObject
    {
        public ItemAffix itemAffixType;
        public ItemStats itemStatModifing;
        public string itemAffixString;
        public int itemAffixIntModifier;
        public bool isSpecialModifier;
    }
}
