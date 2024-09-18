namespace CobolParser.Domain.Core
{
    public class ValueObjects<T>
    {
        protected readonly T value;

        internal ValueObjects(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
