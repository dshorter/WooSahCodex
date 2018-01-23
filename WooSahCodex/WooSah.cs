using WooSahCodex.Color;
using WooSahCodex.Etching;
using WooSahCodex.Finish;
using WooSahCodex.Material;
using WooSahCodex.Model;

namespace WooSahCodex
{
    public class WooSahPOCO
    {
        public string DocumentId;
        public string _rev;

        public bool isValid;

        public string Model { get; set; }
        public string Material { get; set; }
        public string Finish { get; set; }
        public string Color { get; set; }
        public string Etching { get; set; }

    }

    public class WooSah
    {

        public WooSahPOCO wooSahPoco;

        public string DocumentId;
        public string _rev;

        private bool _isValid;

        public IModel Model { get; set; }
        public IMaterial Material { get; set; }
        public IFinish Finish { get; set; }
        public IColor Color { get; set; }
        public IEtching Etching { get; set; }
        public bool IsValid { get => _isValid; set => _isValid = value; }

        public WooSah() { }

        public void CreatePoco()
        {
            wooSahPoco = new WooSahPOCO()
            {
                isValid = IsValid,
                Model = Model.GetType().Name,
                Color = Color.GetType().Name,
                Material = Material.GetType().Name,
                Finish = Finish.GetType().Name,
                Etching = Etching.GetType().Name
            };
        }

        public void ValidateMe()
        {
            WooSahProperty model = Model as WooSahProperty;
            model.WooSah = this;

            _isValid = model.Validate();
        }

    }
}