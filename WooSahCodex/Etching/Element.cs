namespace WooSahCodex.Etching
{
    public class Element : WooSahProperty, IEtching
    {
        public Element()
        {

        }
        public Element(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}