using System;
using System.Collections.Generic;
using System.Text;
using WooSahCodex.Model;

namespace WooSahCodex
{
    public class WooSahProperty
    {

        public WooSah wooSah;
        public HashSet<string> ExcludeHashSet = new HashSet<string>();

        public WooSahProperty()
        {
            

            
        }

        public WooSahProperty(WooSah wooSah, HashSet<string> ExcludeHashSet)
        {
            this.ExcludeHashSet = ExcludeHashSet;

        }

        public bool Validate()
        {
            if (wooSah.Model is Chakra)
            {
                
            }
            if (ExcludeHashSet.Contains(wooSah.Material.ToString()) ||
                ExcludeHashSet.Contains(wooSah.Model.ToString()) ||
                ExcludeHashSet.Contains(wooSah.Color.ToString()) ||
                ExcludeHashSet.Contains(wooSah.Etching.ToString()) ||
                ExcludeHashSet.Contains(wooSah.Finish.ToString()))
            {
                return false;
            }

            return true;
        }
    }
}
