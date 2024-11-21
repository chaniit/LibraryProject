using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class GraphDal
    {
        public static int findRouteByBookId(int id)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {
                     Book book = db.Books.ToList().Where(x => x.Id == id).FirstOrDefault();
                     if (book != null)
                     {
                        return book.Location;
                     }
                     return 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
