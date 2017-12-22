namespace WooSahCodex.Model
{
    public class Ataraxis : WooSahProperty, IModel
    {
        public Ataraxis()
        {
            
        }
        public Ataraxis(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}