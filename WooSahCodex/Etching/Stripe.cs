namespace WooSahCodex.Etching
{
    public class Stripe : WooSahProperty, IEtching
    {
        public Stripe()
        {
            
        }
        public Stripe(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}