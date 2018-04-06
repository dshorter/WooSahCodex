namespace WooSahCodex.Model
{
    public class Chakra : WooSahProperty, IModel
    {

        public Chakra()
        {
            
        }
        public Chakra(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }    

    }
}


