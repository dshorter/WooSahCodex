﻿namespace WooSahCodex.Model
{
    public class Namaste : WooSahProperty, IModel
    {

        public Namaste()
        {
            
        }
        public Namaste(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            var myResult = true;

            var x = WooSah;

            return myResult && base.Validate();
        }
    }
}