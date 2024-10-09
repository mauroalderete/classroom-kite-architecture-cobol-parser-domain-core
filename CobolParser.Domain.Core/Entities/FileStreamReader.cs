using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CobolParser.Domain.Core.Entities
{
    public class FileStreamReader
    {
        // string @username
        // PK... oculto??? cambiar email.... / cambiar username

        public FileStreamReaderUUID id { get; set; }
        private StreamReader _reader { get; set; }
        private Range Range { get; set; }

        protected FileStreamReader(FileStreamReaderUUID id, StreamReader reader)
        {
            this.id = id;
        }

        // Guid temp = Guid.NewGuid();
        public static FileStreamReader Create(FileStreamReaderUUID id, StreamReader reader)
        {
            if (reader == null) throw new ArgumentNullException(nameof(reader));

            return new FileStreamReader(id, reader);
        }

        public void ReadLine()
        {
            // podemos modificar el estado
            if (_reader.EndOfStream) throw new InvalidOperationException("End of stream reached");

            // modificamos
            var temp = _reader.ReadLine();

            // notifcar el cambio de estado
            // si hay un error??
        }

        public String GetLastContent()
        {
            return "";
        }
    }
}
