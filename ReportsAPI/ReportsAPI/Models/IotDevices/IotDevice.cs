namespace ReportsAPI.Models
{
    public class IotDevice
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Body { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }

        public IotDevice()
        {
        }
    }
}
