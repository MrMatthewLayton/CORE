namespace Core.Validation
{
    public abstract class Validator<T>
    {
        public abstract bool IsValid(T value);
    }
}
