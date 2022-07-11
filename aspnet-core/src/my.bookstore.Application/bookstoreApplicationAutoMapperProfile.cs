using AutoMapper;
using my.bookstore.Books;

namespace my.bookstore
{
    public class bookstoreApplicationAutoMapperProfile : Profile
    {
        public bookstoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
