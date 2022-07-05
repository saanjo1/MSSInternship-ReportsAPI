using ReportsAPI.Models;
using AutoMapper;

namespace ReportsAPI.MappingProfiles
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<Asset, AssetTableEntity>().ReverseMap();
        }
    }
}
