namespace WooSahCodex.Model
{
    public class NamasteMini : WooSahProperty, IModel
    {

        public NamasteMini()
        {

        }

        public NamasteMini(WooSah wooSah) : base(wooSah)
        {
        }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}