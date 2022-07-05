using Azure;
using Azure.Data.Tables;

namespace ReportsAPI.Models
{
    public class IotDeviceTableEntity : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public ETag ETag { get; set; } = new ETag("*");
        public string DeviceName { get; set; }
        public string Body { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.Now;
        public IotDeviceTableEntity() { }

       
    }
   
}
