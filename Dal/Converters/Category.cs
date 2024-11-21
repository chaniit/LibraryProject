using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public partial class Category
    {
        public CategoryDto ConvertToDto(Category category)
        {
            CategoryDto categoryDto = new CategoryDto();
            categoryDto.Id = category.Id;
            categoryDto.name_category = category.name_category;         
            return categoryDto;
        }
        public static Category ConvertToDal(CategoryDto categoryDto)
        {
            Category category = new Category();
            category.Id = categoryDto.Id;
            category.name_category = categoryDto.name_category;
            return category;
        }
    }
}
