namespace WooSahCodex.Etching
{
    public class Imperial : WooSahProperty, IEtching
    {
        public Imperial()
        {
            
        }
        public Imperial(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}