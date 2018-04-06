namespace WooSahCodex.Model
{
    public class AtaraxisMini : WooSahProperty, IModel
    {

        public AtaraxisMini()
        {

        }
        public AtaraxisMini(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }

    }
}