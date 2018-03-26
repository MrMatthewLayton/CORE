namespace Core.Data
{
    using System.Linq;

    /// <summary>
    /// Represents the base class for encapsulating eager loading logic.
    /// </summary>
    /// <typeparam name="TModel">The underlying model type.</typeparam>
    public abstract class LoadingConfiguration<TModel> where TModel : class
    {
        /// <summary>
        /// Configures the eager loading logic for the model.
        /// </summary>
        /// <param name="queryable">The model upon which to perform eager loading.</param>
        /// <returns>The model with the eager loading configuration applied.</returns>
        public virtual IQueryable<TModel> Configure(IQueryable<TModel> queryable)
        {
            return queryable;
        }
    }
}
