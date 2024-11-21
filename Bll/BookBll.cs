using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bll
{
    public class BookBll
    {
        public static List<BooksDto> GetAllBooks()
        {
            return BookDal.GetAllBooks();
        }
        public static List<BooksDto> GetByCategory(int id)
        {
            return BookDal.GetByCategory(id);
        }

        public static List<BooksDto> GetByDate(DateTime date)
        {
            return BookDal.GetByDate(date);
        }

        public static List<BooksDto> GetByParametrs(int age, string kind)
        {
            return BookDal.GetByParametrs(age, kind);
        }
    }
}
