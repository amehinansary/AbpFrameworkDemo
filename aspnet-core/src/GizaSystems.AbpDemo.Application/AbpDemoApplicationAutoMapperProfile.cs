using AutoMapper;
using GizaSystems.AbpDemo.Authors;
using GizaSystems.AbpDemo.Authors.Dtos;
using GizaSystems.AbpDemo.Books;
using GizaSystems.AbpDemo.Books.Dtos;

namespace GizaSystems.AbpDemo;

public class AbpDemoApplicationAutoMapperProfile : Profile
{
    public AbpDemoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        /* Books */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* Authors */
        CreateMap<Author, AuthorDto>();
        CreateMap<CreateAuthorDto, Author>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
