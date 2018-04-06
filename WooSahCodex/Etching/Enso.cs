namespace WooSahCodex.Etching
{
    public class Enso : WooSahProperty, IEtching
    {
        public Enso()
        {

        }
        public Enso(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}