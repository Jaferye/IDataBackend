namespace Entities.Model.Constants
{
    /// <summary>
    /// IEntity.
    /// </summary>
    /// <typeparam name="TPrimaryKey">The type of the primary key.</typeparam>
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        TPrimaryKey Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}
