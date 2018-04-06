namespace WooSahCodex.Model
{
    public class CosmoMini : WooSahProperty, IModel
    {

        public CosmoMini()
        {

        }
        public CosmoMini(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }

    }
}