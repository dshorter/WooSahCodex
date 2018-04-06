namespace WooSahCodex.Etching
{
    public class Slots : WooSahProperty, IEtching
    {
        public Slots()
        {

        }
        public Slots(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}