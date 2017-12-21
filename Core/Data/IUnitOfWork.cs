namespace Core.Data
{
    /// <summary>
    /// Represents the base contract for implementing the unit of work pattern.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits a unit of work.
        /// </summary>
        /// <returns>The number of changes that were successfully committed in the unit of work.</returns>
        int SaveChanges();
    }
}
