using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace RPGLootGenerator
{
    public static class ConvertString
    {
        public static string ItemStatGenerator(int ItenStatInt, string ItenStatString)
        {
            string ItenStatStringComplete = ItenStatString + ": " + ItenStatInt;
            return ItenStatStringComplete;
        }
    }
}
