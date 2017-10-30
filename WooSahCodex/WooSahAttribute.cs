using System;
using System.Collections.Generic;
using System.Text;

namespace WooSahCodex.Codex
{
    [AttributeUsage(AttributeTargets.All)]
    public class WooSahAttribute : Attribute
    {
        //  private List<string> includeList = new List<string>();
        //  private List<string> compareList = new List<string>();
        public string[] compareList;

        public bool allows { get; set; }

        public WooSahAttribute(string[] CompareList, bool Allows)
        {
            compareList = CompareList;
            allows = Allows;
        }
    }

}


