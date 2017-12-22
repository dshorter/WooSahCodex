namespace WooSahCodex.Etching
{
    public class Prism : WooSahProperty, IEtching
    {
        public Prism()
        {
            
        }
        public Prism(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}