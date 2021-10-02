using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new entry is created.
    /// </summary>
    public class EntryCreatedEvent : IMessageEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">Entry id</param>
        /// <param name="name">Entry name</param>
        /// <param name="categoryId">Category id</param>
        public EntryCreatedEvent(Guid id, string name, Guid categoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
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

        /// <summary>
        /// Category data
        /// </summary>
        public Guid CategoryId { get; private set; }

        #endregion

    }
}
