namespace WooSahCodex.Etching
{
    public class Amaze : WooSahProperty, IEtching
    {
        public Amaze()
        {

        }
        public Amaze(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}