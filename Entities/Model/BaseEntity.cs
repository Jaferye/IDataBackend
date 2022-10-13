namespace Entities.Model
{
    using Entities.Model.Constants;

    /// <summary>
    /// Implements IEntity.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <seealso cref="Model" />
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        /// <inheritdoc />
        public TKey Id { get; set; }

        /// <inheritdoc />
        public bool IsActive { get; set; }
    }
}
