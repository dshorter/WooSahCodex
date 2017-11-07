using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using WooSahCodex.Color;
using WooSahCodex.Etching;
using WooSahCodex.Finish;
using WooSahCodex.Material;
using WooSahCodex.Model;

namespace WooSahCodex
{
    public class WooSah
    {
        public bool isValid;

        public IModel Model { get; set; }
        public IMaterial Material { get; set; }
        public IFinish Finish { get; set; }
        public IColor Color { get; set; }
        public IEtching Etching { get; set; }


        public bool Validate()
        {
            WooSahProperty model = Model as WooSahProperty;

            if (model.Validate())
            {

            }

            return true;    

        }

        public WooSah()
        {



        }
    }
}