using AutoMapper;
using CleanArcMvc.Application.DTOs;
using CleanArcMvc.Domain.Entities;

namespace CleanArcMvc.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
