using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WooSahCodex
{
    public class WooSahStats
    {
        private List<WooSah> _wooSahList;

        public WooSahStats(List<WooSah> wooSahList)
        {
            _wooSahList = wooSahList;
        }

        public int PassCount()
        {
            var pass = _wooSahList.Count(w => w.IsValid == true);
            var pass1  = _wooSahList.Where(w => w.IsValid == true).Count();
            return pass;
        }

        public int FalseCount()
        {
            var falses = _wooSahList.Where(w => w.IsValid == false).Count();
            return falses;
        }    



    }        

}
