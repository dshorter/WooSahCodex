namespace WooSahCodex.Model
{
    public class DH : WooSahProperty, IModel
    {

        public DH()
        {
            
        }
        public DH(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}