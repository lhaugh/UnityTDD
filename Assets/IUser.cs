
namespace Project.Feature
{
    /// <summary>
    /// Defines the details held for each registered account.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// A unique identifier for this account.
        /// </summary>
        /// <value></value>
        int Id { get; }
    }
}