using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobolParser.Domain.Core
{
    public class FileStreamReaderUUID
    {
        public int Id { get; set; }

        protected FileStreamReaderUUID(int id)
        {
            this.Id = id;
        }

        public static FileStreamReaderUUID Create(int id)
        {
            // invariant startwith('@')...

            return new FileStreamReaderUUID(id);
        }
    }
}
