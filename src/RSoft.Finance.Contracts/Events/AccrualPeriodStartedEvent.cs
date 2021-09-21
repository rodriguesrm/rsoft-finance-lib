using RSoft.Lib.Messaging.Contracts;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when an accrual period is started.
    /// </summary>
    public class AccrualPeriodStartedEvent : IMessageEvent
    {

        #region Constructors

        /// <summary>
        /// Create event instance
        /// </summary>
        /// <param name="year">Accrual period year</param>
        /// <param name="month">Accrual period month</param>
        public AccrualPeriodStartedEvent(int year, int month)
        {
            Year = year;
            Month = month;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Accrual period year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Acrrual period month
        /// </summary>
        public int Month { get; set; }

        #endregion

    }
}
