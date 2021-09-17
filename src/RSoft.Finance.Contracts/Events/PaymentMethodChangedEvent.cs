using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new PaymentMethod is Changed.
    /// </summary>
    public class PaymentMethodChangedEvent : IMessageEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="id">PaymentMethod id</param>
        /// <param name="name">PaymentMethod name</param>
        /// <param name="paymentType">Payment type data</param>
        public PaymentMethodChangedEvent(Guid id, string name, int paymentType)
        {
            Id = id;
            Name = name;
            PaymentType = paymentType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// PaymentMethod id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// PaymentMethod name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Payment type data
        /// </summary>
        public int PaymentType { get; private set; }

        #endregion

    }
}
