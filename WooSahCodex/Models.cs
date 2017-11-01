namespace WooSahCodex.Codex.Properties
{
    public struct Model
    {
        [WooSah(new string[] { Material.SS }, true)]
        public const string TheBoss = "TheBoss";

        [WooSah(new string[] { Material.SS, Material.Copper,
                               Finish.Polished, Finish.Brushed }, 
                               true)]
        public const string Chakra = "Chakra";
        public const string Namaste = "Namaste";
        public const string Cosmo = "Cosmo";

        [WooSah(new string[] { Material.SS, Material.Aluminum, 
                Finish.Polished, Finish.Brushed, Finish.Anodized },
                true)]
        public const string DH = "DH";

        [WooSah(new string[] { Material.SS, Material.Aluminum,
                Finish.Polished, Finish.Brushed, Finish.Anodized },
            true)]
        public const string DHJr = "DHJr";

        [WooSah(new string[] { Material.SS }, true)]
        public const string AtaraXis = "AtaraXis";

    }
}

