namespace WooSahCodex.Model
{
    public class Ohana : WooSahProperty, IModel
    {

        public Ohana()
        {

        }
        public Ohana(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }

    }
}