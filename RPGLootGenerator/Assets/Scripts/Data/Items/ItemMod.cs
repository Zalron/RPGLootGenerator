using UnityEngine;
using System.Collections;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item Stats", menuName = "Item", order = 2)]
    public class ItemMod : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public int itemModIntModifier;
        public ItemAffix itemAffixType;
        public ItemAffixs itemAffix;
    }
}
