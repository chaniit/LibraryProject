using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public class WriteDal
    {
        public static List<WriterDto> GetAllWriters()
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {
                    List<Writer> writers = db.Writers.ToList();
                    return writers.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<WriterDto> GetByWriterId(int id)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {

                    List<Writer> writerList = db.Writers.ToList().Where(x => x.Id == id).ToList();
                    return writerList.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
