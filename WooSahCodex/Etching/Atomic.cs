namespace WooSahCodex.Etching
{
    public class Atomic  : WooSahProperty, IEtching
    {
        public Atomic()
        {

        }
        public Atomic(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}