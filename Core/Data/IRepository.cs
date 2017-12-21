namespace Core.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the base contract for implementing a repository.
    /// </summary>
    /// <typeparam name="TKey">The underlying key type.</typeparam>
    /// <typeparam name="TModel">The underlying model type.</typeparam>
    public interface IRepository<TKey, TModel> where TModel : class
    {
        /// <summary>
        /// Finds an item in the repository using the provided key.
        /// </summary>
        /// <param name="id">The key for which to get an item from the repository.</param>
        /// <returns>At item whose key matches the given key.</returns>
        TModel FindById(TKey id);

        /// <summary>
        /// Gets all items from the repository.
        /// </summary>
        /// <returns>All items from the repository.</returns>
        IEnumerable<TModel> GetAll();

        /// <summary>
        /// Adds an item to the repository.
        /// </summary>
        /// <param name="item">The item to add to the repository.</param>
        void Add(TModel item);

        /// <summary>
        /// Adds a collection of items to the repository.
        /// </summary>
        /// <param name="items">The collection of items to add to the repository.</param>
        void AddRange(IEnumerable<TModel> items);

        /// <summary>
        /// Removes an item from the repository.
        /// </summary>
        /// <param name="item">The item to remove from the repository.</param>
        void Remove(TModel item);

        /// <summary>
        /// Removes a collection of items from the repository.
        /// </summary>
        /// <param name="items">The collection of items to remove from the repository.</param>
        void RemoveRange(IEnumerable<TModel> items);
    }
}
