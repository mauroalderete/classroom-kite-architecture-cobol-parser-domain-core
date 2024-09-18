using Cedeira.Essentials.NET.Diagnostics.Invariants;

namespace CobolParser.Domain.Core
{
    public class ImporteOrigenPreciso
    {
        public readonly decimal value;

        protected ImporteOrigenPreciso(decimal importe)
        {
            value = importe;
        }

        public static ImporteOrigenPreciso Create(decimal importe)
        {
            Invariants.For(importe.ToString()).MatchesRegex(@"\d+\.\d{4}");

            return new ImporteOrigenPreciso(importe);
        }

        public override string ToString()
        {
            return value.ToString("0.0000");
        }
    }
}
