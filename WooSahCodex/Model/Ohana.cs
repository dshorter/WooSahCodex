using WooSahCodex.Material;

namespace WooSahCodex.Model
{
    public class Ohana : WooSahProperty, IModel
    {

        public Ohana()
        {

        }
        public Ohana(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = false;

            if (WooSah.Material is SS || WooSah.Material is Copper)
                myResult = true;

            return myResult && base.Validate();
        }

    }   
}