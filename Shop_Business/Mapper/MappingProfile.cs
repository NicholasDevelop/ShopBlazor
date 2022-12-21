using AutoMapper;
using Shop_DataAccess;
using Shop_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            //CreateMap<CategoryDTO, Category>();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
