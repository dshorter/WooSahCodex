namespace WooSahCodex.Etching
{
    public class Diffuse : WooSahProperty, IEtching
    {
        public Diffuse()
        {

        }
        public Diffuse(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}