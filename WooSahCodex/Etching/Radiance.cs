﻿namespace WooSahCodex.Etching
{
    public class Radiance : WooSahProperty, IEtching
    {
        public Radiance()
        {
            
        }
        public Radiance(WooSah wooSah) : base(wooSah) { }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}