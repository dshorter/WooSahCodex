namespace WooSahCodex.Etching
{
    public class Noble   : WooSahProperty, IEtching
    {
        public Noble()
        {

        }
        public Noble(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}