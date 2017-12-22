namespace WooSahCodex.Model
{
    public class MiniChakra : WooSahProperty, IModel
    {

        public MiniChakra()
        {

        }
        public MiniChakra(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
   
    }
}