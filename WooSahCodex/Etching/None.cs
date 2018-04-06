namespace WooSahCodex.Etching
{
    public class None : WooSahProperty, IEtching
    {
        public None()
        {

        }
        public None(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}