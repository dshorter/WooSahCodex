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
}