namespace WooSahCodex.Etching
{
    public class Caliber : WooSahProperty, IEtching
    {
        public Caliber()
        {
            
        }
        public Caliber(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}