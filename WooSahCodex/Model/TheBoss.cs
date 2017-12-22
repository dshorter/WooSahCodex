namespace WooSahCodex.Model
{
    public class TheBoss : WooSahProperty, IModel
    {

        public TheBoss()
        {
            
        }
        public TheBoss(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}