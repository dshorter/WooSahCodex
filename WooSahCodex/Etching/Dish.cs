namespace WooSahCodex.Etching
{
    public class Dish : WooSahProperty, IEtching
    {
        public Dish()
        {

        }
        public Dish(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}