using Cedeira.Essentials.NET.Diagnostics.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobolParser.Domain.Core
{
    public class FilenameBinary : Filename
    {
        //Factory Method Pattern
        private FilenameBinary(string name) : base(name)
        {

        }

        public static FilenameBinary Create(string name)
        {
            Invariants.For(name).IsNotNullOrEmpty();

            // regla regexp para validar la extension del archivo como .bin
            Invariants.For(name).MatchesRegex(@"\w+\.bin");

            return new FilenameBinary(name);
        }
    }
}
