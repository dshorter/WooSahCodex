using WooSahCodex.Model;

namespace WooSahCodex.Etching
{
    public class Vector : WooSahProperty, IEtching
    {
        public Vector()
        {

        }
        public Vector(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            bool myResult = WooSah.Model is Ohana;

            return myResult && base.Validate();
        }
    }
}