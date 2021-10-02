using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when entry status changed (enable or disable)
    /// </summary>
    public class EntryStatusChangedEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">Entry id</param>
        /// <param name="isActive">Status active flag</param>
        public EntryStatusChangedEvent(Guid id, bool isActive)
        {
            Id = id;
            IsActive = isActive;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Entry id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Active sttus flag
        /// </summary>
        public bool IsActive { get; private set; }

        #endregion

    }
}
