namespace WooSahCodex.Etching
{
    public class Flux : WooSahProperty, IEtching
    {
        public Flux()
        {
            
        }
        public Flux(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}