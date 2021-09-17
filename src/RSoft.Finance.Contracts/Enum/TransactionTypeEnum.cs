using System.ComponentModel;

namespace RSoft.Finance.Contracts.Enum
{

    /// <summary>
    /// Transaction type enumeration
    /// </summary>
    public enum TransactionTypeEnum
    {

        /// <summary>
        /// Indicates credit operations where amounts are received
        /// </summary>
        [Description("Credit (Revenue from values)")]
        Credit = 1,

        /// <summary>
        /// Indicates debit transactions where amounts are paid
        /// </summary>
        [Description("Debit (Payment of amounts))")]
        Debt = 2

    }
}
