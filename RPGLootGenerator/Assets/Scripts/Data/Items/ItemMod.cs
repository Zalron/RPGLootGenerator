using UnityEngine;
using System.Collections;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item Mod", order = 1)]
    public class ItemMod : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public int itemModIntModifier;
        public ItemAffix itemAffixType;
        public ItemStats itemStatModifiying;
    }
}
