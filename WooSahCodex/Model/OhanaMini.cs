namespace WooSahCodex.Model
{
    public class OhanaMini : WooSahProperty, IModel
    {

        public OhanaMini()
        {

        }
        public OhanaMini(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }

    }
}