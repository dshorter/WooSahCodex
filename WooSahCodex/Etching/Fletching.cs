namespace WooSahCodex.Etching
{
    public class Fletching : WooSahProperty, IEtching
    {
        public Fletching()
        {
            
        }
        public Fletching(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}