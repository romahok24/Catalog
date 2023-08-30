using ProductCatalog.Domain.Models;
using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;

namespace ProductCatalog.Utils.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<User, RegistrationModelDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}