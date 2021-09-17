using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when category status is changed (enable or disable)
    /// </summary>
    public class CategoryStatusChangedEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">Category id</param>
        /// <param name="isActive">Status active flag</param>
        public CategoryStatusChangedEvent(Guid id, bool isActive)
        {
            Id = id;
            IsActive = isActive;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Category id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Active sttus flag
        /// </summary>
        public bool IsActive { get; private set; }

        #endregion

    }
}
