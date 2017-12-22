namespace WooSahCodex.Etching
{
    public class Premiere : WooSahProperty, IEtching
    {
        public Premiere()
        {
            
        }
        public Premiere(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}