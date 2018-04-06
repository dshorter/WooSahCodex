namespace WooSahCodex.Etching
{
    public class Arrow : WooSahProperty, IEtching
    {
        public Arrow()
        {

        }
        public Arrow(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}