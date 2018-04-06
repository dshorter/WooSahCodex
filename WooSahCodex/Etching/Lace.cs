namespace WooSahCodex.Etching
{
    public class Lace : WooSahProperty, IEtching
    {
        public Lace()
        {

        }
        public Lace(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}