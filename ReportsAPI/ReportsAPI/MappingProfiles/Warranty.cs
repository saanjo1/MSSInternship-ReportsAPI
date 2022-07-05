using AutoMapper;
using ReportsAPI.Models;
namespace ReportsAPI.MappingProfiles
{
    public class WarrantyProfile : Profile
    {
        public WarrantyProfile()
        {
            CreateMap<Warranty, WarrantyTableEntity>().ReverseMap();
        }
    }
}
