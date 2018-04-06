namespace WooSahCodex.Model
{
    public class ChakraMini : WooSahProperty, IModel
    {

        public ChakraMini()
        {

        }
        public ChakraMini(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }

    }
}