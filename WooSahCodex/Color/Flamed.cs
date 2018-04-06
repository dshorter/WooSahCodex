using WooSahCodex.Etching;
using WooSahCodex.Model;

namespace WooSahCodex.Color
{
    public class Flamed : WooSahProperty, IColor
    {
        public Flamed()
        {

        }
        public Flamed(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;    

            if (WooSah.Model is DhJr && WooSah.Etching is ZaftigEnso)
                myResult = true;
            else if (WooSah.Model is Ohana)
                myResult = true;
            else
                myResult = false;    

            return myResult && base.Validate();
        }
    }
}