using Cedeira.Essentials.NET.Diagnostics.Invariants;

namespace CobolParser.Domain.Core
{
    public class Filename : ValueObjects<string>
    {
        public string Name => value;

        protected Filename(string name) : base(name)
        {
        }

        public static Filename Create(string name)
        {
            Invariants.For(name).IsNotNullOrEmpty();

            return new Filename(name);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
