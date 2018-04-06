namespace WooSahCodex.Material
{
    public class AluminumNickelBronze : WooSahProperty, IMaterial
    {
        public AluminumNickelBronze()
        {
            
        }
        public AluminumNickelBronze(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}