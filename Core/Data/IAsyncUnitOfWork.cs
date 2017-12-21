namespace Core.Data
{
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the base contract for implementing the unit of work pattern using async/await.
    /// </summary>
    public interface IAsyncUnitOfWork
    {
        /// <summary>
        /// Commits a unit of work.
        /// </summary>
        /// <returns>The number of changes that were successfully committed in the unit of work.</returns>
        Task<int> SaveChangesAsync();
    }
}
