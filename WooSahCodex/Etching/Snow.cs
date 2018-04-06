namespace WooSahCodex.Etching
{
    public class Snow : WooSahProperty, IEtching
    {
        public Snow()
        {

        }
        public Snow(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}