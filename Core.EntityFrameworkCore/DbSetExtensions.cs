namespace Core.EntityFrameworkCore
{
    using Core.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    /// <summary>
    /// Represents <see cref="DbSet{TEntity}"/> extension methods defined by the CORE library.
    /// </summary>
    public static class DbSetExtensions
    {
        /// <summary>
        /// Applies an loading configuration to the <see cref="DbSet{TEntity}"/>.
        /// </summary>
        /// <typeparam name="TModel">The underlying model type.</typeparam>
        /// <param name="set">The <see cref="DbSet{TEntity}"/> where the loading configuration will be applied.</param>
        /// <param name="loader">The loading configuration to apply</param>
        /// <returns>The <see cref="DbSet{TEntity}"/> with the loading configuration applied.</returns>
        public static IQueryable<TModel> WithLoadingConfiguration<TModel>(
            this DbSet<TModel> set,
            LoadingConfiguration<TModel> loader) where TModel : class
        {
            return loader.Configure(set);
        }
    }
}
