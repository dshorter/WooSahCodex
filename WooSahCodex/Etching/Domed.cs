namespace WooSahCodex.Etching
{
    public class Domed : WooSahProperty, IEtching
    {
        public Domed()
        {

        }
        public Domed(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}