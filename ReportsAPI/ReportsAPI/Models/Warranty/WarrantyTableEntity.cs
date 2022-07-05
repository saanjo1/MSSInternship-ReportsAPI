using Microsoft.Azure.Cosmos.Table;

namespace ReportsAPI.Models
{
    public class WarrantyTableEntity : TableEntity
    {

        public WarrantyTableEntity()
        {

        }
        public WarrantyTableEntity(string RowKey, string PartKey)
        {
            this.RowKey = RowKey.ToString();
            this.PartitionKey = PartKey;
        }
        

        public string WarrantyID { get; set; }    
        public string AssetID { get; set; }
        public double PriceOfWarranty { get; set; }
        public string Duration { get; set; }
        public bool PossibilityToExtend { get; set; }
    }
}