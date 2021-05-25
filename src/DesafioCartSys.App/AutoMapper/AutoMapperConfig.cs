using AutoMapper;
using DesafioCartSys.App.ViewModels;
using DesafioCartSys.Business.Models;

namespace DesafioCartSys.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            
        }
    }
}
