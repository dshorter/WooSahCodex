namespace WooSahCodex.Model
{
    public class DhJr : WooSahProperty, IModel
    {

        public DhJr()
        {
            
        }
        public DhJr(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}