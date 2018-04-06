using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using WooSahCodex.Model;

namespace WooSahCodex.Etching
{
    public class ZaftigEnso : WooSahProperty, IEtching
    {
        public ZaftigEnso()
        {

        }
        public ZaftigEnso(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            if (WooSah.Model is DhJr  )         
                myResult = true;
            else
                myResult = false;
             
            return myResult && base.Validate();
        }
    }
}