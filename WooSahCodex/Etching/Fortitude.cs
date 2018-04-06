namespace WooSahCodex.Etching
{
    public class Fortitude : WooSahProperty, IEtching
    {
        public Fortitude()
        {

        }
        public Fortitude(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}