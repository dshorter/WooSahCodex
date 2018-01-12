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

