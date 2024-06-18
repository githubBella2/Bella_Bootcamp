using AutoMapper;
using New.DTOS;
using New.Models;

namespace New.Mappers;

public class MyMapper : Profile
{
     public MyMapper()
    {
        CreateMap<CategoryDTO, Category>().ReverseMap(); //bolak balik
    }
}
