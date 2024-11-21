using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class BooksDto
    {
        public int Id { get; set; }
        public string Name_book { get; set; }
        public int Category_id { get; set; }
        public int Writer_id { get; set; }
        public int For_age { get; set; }
        public string Kind { get; set; }
        public string Symbol_shelf { get; set; }
        public string Status { get; set; }
        public int Location { get; set; }

    }
}
