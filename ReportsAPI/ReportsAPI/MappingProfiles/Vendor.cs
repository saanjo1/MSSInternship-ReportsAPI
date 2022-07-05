using AutoMapper;
using ReportsAPI.Models;

namespace ReportsAPI.MappingProfiles
{
    public class VendorProfile : Profile
    {
        public VendorProfile()
        {
            CreateMap<Vendor, VendorTableEntity>().ReverseMap();
        }
    }
}
