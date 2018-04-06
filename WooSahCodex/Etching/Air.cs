namespace WooSahCodex.Etching
{
    public class Air : WooSahProperty, IEtching
    {
        public Air()
        {

        }
        public Air(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}