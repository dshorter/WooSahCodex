namespace WooSahCodex.Etching
{
    public class Snowflake : WooSahProperty, IEtching
    {
        public Snowflake()
        {

        }
        public Snowflake(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            return myResult && base.Validate();
        }
    }
}