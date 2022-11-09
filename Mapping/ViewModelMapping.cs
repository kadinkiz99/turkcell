using AutoMapper;
using turkcell.Models;
using turkcell.ViewModels;

namespace turkcell.Mapping
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
