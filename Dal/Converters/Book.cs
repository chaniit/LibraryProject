using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public partial class Book
    {
        public BooksDto ConvertToDto(Book book)
        {
            BooksDto bookDto = new BooksDto();
            bookDto.Id = book.Id;
            bookDto.Name_book = book.Name_book;
            bookDto.Kind = book.Kind;
            bookDto.Status = book.Status;
            bookDto.Category_id = book.Category_id;
            bookDto.Writer_id = book.Writer_id;
            bookDto.Symbol_shelf = book.Symbol_shelf;
            bookDto.For_age = book.For_age;
            bookDto.Location = book.Location;
            return bookDto;
        }

        public static Book ConvertToDal(BooksDto bookDto)
        {
            Book book = new Book();
            book.Id = bookDto.Id;
            book.Name_book = bookDto.Name_book;
            book.Kind = bookDto.Kind;
            book.Status = bookDto.Status;
            book.Category_id = bookDto.Category_id;
            book.Writer_id = bookDto.Writer_id;
            book.Symbol_shelf = bookDto.Symbol_shelf;
            book.For_age = bookDto.For_age;
            book.Location = bookDto.Location;
            return book;
        }
    }
}
