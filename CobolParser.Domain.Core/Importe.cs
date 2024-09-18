using Cedeira.Essentials.NET.Diagnostics.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobolParser.Domain.Core
{
    public class Importe : ValueObjects<decimal>
    {
        protected Importe(decimal importe) : base(importe)
        {
        }

        public static Importe Create(decimal importe)
        {
            Invariants.For(importe.ToString()).MatchesRegex(@"\d+\.\d{2}");

            return new Importe(importe);
        }

        public override string ToString()
        {
            return value.ToString("0.00");
        }
    }
}
