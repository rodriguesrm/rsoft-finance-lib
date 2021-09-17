using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when account status changed (enable or disable)
    /// </summary>
    public class AccountStatusChangedEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">Account id</param>
        /// <param name="isActive">Status active flag</param>
        public AccountStatusChangedEvent(Guid id, bool isActive)
        {
            Id = id;
            IsActive = isActive;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Account id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Active sttus flag
        /// </summary>
        public bool IsActive { get; private set; }

        #endregion

    }
}
