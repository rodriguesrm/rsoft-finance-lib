using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new category is changed.
    /// </summary>
    public class CategoryChangedEvent : IMessageEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">Category id</param>
        /// <param name="name">Category name</param>
        public CategoryChangedEvent(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Category id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; private set; }

        #endregion

    }
}
