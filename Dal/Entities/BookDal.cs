using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public class BookDal
    {
        public static List<BooksDto> GetAllBooks()
        {
            try
            {
                using(LibraryProjectEntities db=new LibraryProjectEntities())
                {
                    List<Book> books = db.Books.ToList();
                    return books.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<BooksDto> GetByDate(DateTime date)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {

                    List<Book> booksList = db.Books.ToList().Where(x => x.Date_bringing >= date).ToList();
                    //List<Writer> writersList = db.Writers.ToList();
                    return booksList.Select(x => x.ConvertToDto(x)).ToList();
                    //var q = from b in booksList join w in writersList on b.Writer_id equals w.Id
                    //        select new {BookName=b.Name_book, WriterName=w.Name_writer };
                    //return (List<BooksDto>)q;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BooksDto> GetByParametrs(int age, string kind)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {

                    List<Book> booksList = db.Books.ToList().Where(x => age>=x.For_age && x.Kind==kind).ToList();

                    return booksList.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BooksDto> GetByCategory(int id)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {

                    List<Book> booksList = db.Books.ToList().Where(x => x.Category_id == id).ToList();
                    return booksList.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
