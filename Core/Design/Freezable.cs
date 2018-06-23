namespace Core.Design
{
    /// <summary>
    /// Represents a generic implementation of the Freezable pattern.
    /// </summary>
    /// <typeparam name="T">The underlying type of the freezable object.</typeparam>
    public sealed class Freezable<T>
    {
        /// <summary>
        /// The freezable value.
        /// </summary>
        private T value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Freezable{T}"/> class.
        /// </summary>
        public Freezable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Freezable{T}"/> class.
        /// </summary>
        /// <param name="value">An initialization value.</param>
        public Freezable(T value) => this.value = value;

        /// <summary>
        /// Gets or sets the freezable value.
        /// </summary>
        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                if (!IsFrozen)
                {
                    this.value = value;
                }
            }
        }

        /// <summary>
        /// Gets a value to determine whether the object is frozen.
        /// </summary>
        public bool IsFrozen { get; private set; }

        /// <summary>
        /// Freezes the object's value.
        /// </summary>
        public void Freeze() => IsFrozen = true;
    }
}
