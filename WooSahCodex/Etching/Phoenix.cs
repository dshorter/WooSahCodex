namespace WooSahCodex.Etching
{
    public class Phoenix : WooSahProperty, IEtching
    {
        public Phoenix()
        {
            
        }
        public Phoenix(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;     

            return myResult && base.Validate();
        }
    }
}




