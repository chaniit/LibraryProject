using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll
{
    public class CategoryBll
    {
        public static List<CategoryDto> GetAllCategory()
        {
            return CategoryDal.GetAllCategory();
        }

    
    }
}
