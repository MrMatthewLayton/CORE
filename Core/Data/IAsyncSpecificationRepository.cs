namespace Core.Data
{
    using Core.Design;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the base contract for asynchronous repositories that are able to query a data source by specification.
    /// </summary>
    /// <typeparam name="TModel">The underlying model type.</typeparam>
    public interface IAsyncSpecificationRepository<TModel> where TModel : class
    {
        /// <summary>
        /// Finds a single item in the data source by specification.
        /// </summary>
        /// <param name="specification">The specification for the item to find in the data source.</param>
        /// <param name="loader">Provides any eager loading include logic that should be applied to the query.</param>
        /// <returns>A single item from the data source that matches the specification.</returns>
        Task<TModel> FindSingleBySpecificationAsync(Specification<TModel> specification, LoadingConfiguration<TModel> loader = null);

        /// <summary>
        /// Finds all items in the data source by specification.
        /// </summary>
        /// <param name="specification">The specification for the items to find in the data source.</param>
        /// <param name="loader">Provides any eager loading include logic that should be applied to the query.</param>
        /// <returns>All items from the data source that match the specification.</returns>
        Task<IEnumerable<TModel>> FindAllBySpecificationAsync(Specification<TModel> specification, LoadingConfiguration<TModel> loader = null);
    }
}
