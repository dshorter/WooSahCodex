namespace WooSahCodex.Etching
{
    public class Ambassador : WooSahProperty, IEtching
    {
        public Ambassador()
        {

        }
        public Ambassador(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}