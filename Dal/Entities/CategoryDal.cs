using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoryDal
    {
        public static List<CategoryDto> GetAllCategory()
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {
                    List<Category> category = db.Categories.ToList();
                    return category.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}
