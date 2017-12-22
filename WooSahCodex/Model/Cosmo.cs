namespace WooSahCodex.Model
{
    public class Cosmo : WooSahProperty, IModel
    {

        public Cosmo()
        {
            
        }
        public Cosmo(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}