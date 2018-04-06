namespace WooSahCodex.Etching
{
    public class Ripple : WooSahProperty, IEtching
    {
        public Ripple()
        {

        }
        public Ripple(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}