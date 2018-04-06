namespace WooSahCodex.Etching
{
    public class Zaftig : WooSahProperty, IEtching
    {
        public Zaftig()
        {

        }
        public Zaftig(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}