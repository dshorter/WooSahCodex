namespace WooSahCodex.Codex.Properties
{
    public struct Finish
    {
        [WooSah(new string[] { Material.Aluminum }, true)]
        public const string Anodized = "Anodized";
        [WooSah(new string[] { Material.Aluminum }, false)]
        public const string Polished = "Polished";
        [WooSah(new string[] { Material.Aluminum }, false)]
        public const string Brushed = "Brushed";    
    }
}