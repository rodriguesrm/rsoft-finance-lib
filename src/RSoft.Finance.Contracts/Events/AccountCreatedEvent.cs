using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new account is changed.
    /// </summary>
    public class AccountChangedEvent : IMessageEvent
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
