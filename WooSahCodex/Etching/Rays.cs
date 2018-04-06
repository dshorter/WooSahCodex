namespace WooSahCodex.Etching
{
    public class Rays : WooSahProperty, IEtching
    {
        public Rays()
        {

        }
        public Rays(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}