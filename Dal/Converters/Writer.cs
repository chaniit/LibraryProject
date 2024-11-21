using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public partial class Writer
    {
        public WriterDto ConvertToDto(Writer writer)
        {
            WriterDto writerDto = new WriterDto();
            writerDto.Id = writer.Id;
            writerDto.Name_writer = writer.Name_writer;
            return writerDto;
        }
        public static Writer ConvertToDal(WriterDto writerDto)
        {
            Writer writer = new Writer();
            writer.Id = writerDto.Id;
            writer.Name_writer = writerDto.Name_writer;
            return writer;
        }
    }
}
