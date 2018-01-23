using System;
using System.Collections.Generic;
using System.Text;
using WooSahCodex.Model;

namespace WooSahCodex
{
    public abstract class WooSahProperty
    {

        protected WooSah _wooSah;

        public WooSahProperty()
        {


        }


        public WooSahProperty(WooSah wooSah)
        {

            WooSah = wooSah;

        }

        protected internal WooSah WooSah
        {
            get { return _wooSah; }
            set { _wooSah = value; }
        }


        public virtual bool Validate()
        {

            if (WooSah.Model is Chakra)
            {
                if (WooSah.Material is Material.Aluminum)
                {
                    return false;
                }
            }

            //if (WooSah.Material is Material.SS && !(WooSah.Color is Color.None))
            //    return false;
            //if (WooSah.Material is Material.Copper && !(WooSah.Color is Color.None))
            //    return false;
            if (!(WooSah.Material is Material.Aluminum) && !(WooSah.Color is Color.None))
                return false;


            return true;
        }

        public void SetWooSah(WooSah wooSah)
        {

            this.WooSah = wooSah;

        }
    }
}




