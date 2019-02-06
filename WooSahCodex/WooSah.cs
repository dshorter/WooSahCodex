using System;
using WooSahCodex.Color;
using WooSahCodex.Etching;
using WooSahCodex.Finish;
using WooSahCodex.Material;
using WooSahCodex.Model;


namespace WooSahCodex
{
    public class WooSah
    {

        public WooSahPOCO wooSahPoco;
        public EF.WooSah wooSahEF;

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

            _isValid = false;

            WooSahProperty model = Model as WooSahProperty;
            model.WooSah = this;

            WooSahProperty material = Material as WooSahProperty;
            material.WooSah = this;

            WooSahProperty finish = Finish as WooSahProperty;
            finish.WooSah = this;

            WooSahProperty color = Color as WooSahProperty;
            color.WooSah = this;

            WooSahProperty etching = Etching as WooSahProperty;
            etching.WooSah = this;


            if (model.Validate() && material.Validate() && finish.Validate() && color.Validate() && etching.Validate())
            {
                _isValid = true;
            }
        }

        public void CreateEF()
        {
            wooSahEF = new EF.WooSah()
            {
                Model = Model.GetType().Name,
                Color = Color.GetType().Name,
                Material = Material.GetType().Name,
                Finish = Finish.GetType().Name,
                Etching = Etching.GetType().Name
            };
        }
    }
}