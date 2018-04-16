namespace WooSahCodex.Model
{
    public class TheBoss : WooSahProperty, IModel
    {

        public TheBoss()
        {
            
        }
        public TheBoss(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            // todo:  if no alum rule is added here the count should not
            // change due to the alum rule at the nase class     
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}