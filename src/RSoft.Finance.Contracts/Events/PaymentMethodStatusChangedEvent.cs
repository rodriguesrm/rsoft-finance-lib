using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when paymement method status is changed (enable or disable)
    /// </summary>
    public class PaymentMethodStatusChangedEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">PaymentMethod id</param>
        /// <param name="isActive">Status active flag</param>
        public PaymentMethodStatusChangedEvent(Guid id, bool isActive)
        {
            Id = id;
            IsActive = isActive;
        }

        #endregion

        #region Properties

        /// <summary>
        /// PaymentMethod id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Active sttus flag
        /// </summary>
        public bool IsActive { get; private set; }

        #endregion

    }
}
