using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new category is created.
    /// </summary>
    public class CategoryCreatedEvent : IMessageEvent
    {

        #region Properties

        /// <summary>
        /// Category id value
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }

        #endregion

    }
}
