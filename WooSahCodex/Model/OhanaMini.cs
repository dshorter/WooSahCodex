using WooSahCodex.Material;

namespace WooSahCodex.Model
{
    public class OhanaMini : WooSahProperty, IModel
    {

        public OhanaMini()
        {

        }
        public OhanaMini(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = false;

            if (WooSah.Material is SS || WooSah.Material is Copper)
                myResult = true;

            return myResult && base.Validate();
        }

    }
}