using System.ComponentModel;

namespace RSoft.Finance.Contracts.Enum
{

    /// <summary>
    /// Payment type enum
    /// </summary>
    public enum PaymentTypeEnum
    {
        /// <summary>
        /// Payment with money
        /// </summary>
        [Description("Money")]
        Money = 1,

        /// <summary>
        /// Payment with debit card
        /// </summary>
        [Description("Bebit to bank account")]
        BankDebit = 2,

        /// <summary>
        /// Payment with TEF/DOC/PIX
        /// </summary>
        [Description("Bank Transfer (DOC, TED, PIX)")]
        BankTransaction = 3,

        /// <summary>
        /// Payment with Credit card
        /// </summary>
        [Description("Credit Card (Visa, Master, Amex, Elo, etc)")]
        CreditCard = 4,

        /// <summary>
        /// Payment with food voucher (benefit card)
        /// </summary>
        [Description("Food stamp (Supermarket)")]
        FoodStamps = 5,

        /// <summary>
        /// Payment with meal ticket (benefit card)
        /// </summary>
        [Description("Food meal/ticket (Restaurant)")]
        MealTicket = 6

    }

}