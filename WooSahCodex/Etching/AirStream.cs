namespace WooSahCodex.Etching
{
    public class AirStream : WooSahProperty, IEtching
    {
        public AirStream()
        {

        }
        public AirStream(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}