namespace ReportsAPI.Models
{
    public class Warranty
    {
        public string WarrantyID { get; set; }
        public string AssetID { get; set; }
        public double PriceOfWarranty { get; set; }
        public string Duration { get; set; }
        public bool PossibilityToExtend { get; set; }
    }
}
