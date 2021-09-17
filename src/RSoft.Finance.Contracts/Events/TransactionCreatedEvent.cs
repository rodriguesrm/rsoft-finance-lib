using RSoft.Finance.Contracts.Enum;
using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new Transaction is changed.
    /// </summary>
    public class TransactionCreatedEvent : IMessageEvent
    {

        #region Constructors

        /// <summary>
        /// Create a new event instance
        /// </summary>
        /// <param name="id">Transaction id</param>
        /// <param name="year">Year of register</param>
        /// <param name="month">Month of register</param>
        /// <param name="date">Date of register</param>
        /// <param name="transactionType">Transaction type number (code of enum)</param>
        /// <param name="amount">Transaction amount</param>
        /// <param name="accountId">Account id</param>
        /// <param name="paymentMethodId">Payment method id</param>
        public TransactionCreatedEvent(Guid id, int year, int month, DateTime date, TransactionTypeEnum transactionType, float amount, Guid accountId, Guid paymentMethodId)
        {
            Id = id;
            Year = year;
            Month = month;
            Date = date;
            TransactionType = transactionType;
            Amount = amount;
            AccountId = accountId;
            PaymentMethodId = paymentMethodId;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Category id value
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Transaction year
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// Transaction month
        /// </summary>
        public int Month { get; private set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        public TransactionTypeEnum TransactionType { get; private set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public float Amount { get; private set; }

        /// <summary>
        /// Account id
        /// </summary>
        public Guid AccountId { get; private set; }

        /// <summary>
        /// Payment method id
        /// </summary>
        public Guid PaymentMethodId { get; private set; }

        #endregion

    }
}