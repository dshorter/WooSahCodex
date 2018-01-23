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

            if (!(_wooSah.Etching is Etching.Domed))
                myResult = false;

            return myResult && base.Validate();
        }
    }
}