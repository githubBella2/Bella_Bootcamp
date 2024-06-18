using AutoMapper;
using MyWebAPI.DTOS;
using MyWebAPI.Models;

namespace MyWebAPI.MyMappers;

public class MyMapper : Profile
{
    public MyMapper()
    {
        CreateMap<CategoryDTO, Category>().ReverseMap(); //bolak balik
        // ctgry ke ctgr dto
        // CreateMap<Category,CategoryDTO>(); 
    }

}
