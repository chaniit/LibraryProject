using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public class WriteBll
    {
        public static List<WriterDto> GetAllWriters()
        {
            return WriteDal.GetAllWriters();
        }

        public static List<WriterDto> GetByWriterId(int id)
        {
            return WriteDal.GetByWriterId(id);
        }
    }
}
