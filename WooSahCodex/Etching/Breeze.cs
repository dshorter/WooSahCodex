namespace WooSahCodex.Etching
{
    public class Breeze :   WooSahProperty, IEtching 
    {
        public Breeze()
        {
            
        }
        public Breeze (WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}