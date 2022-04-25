using System.ComponentModel;

namespace RSoft.Finance.Contracts.Enum
{

    /// <summary>
    /// Person type enum
    /// </summary>
    public enum PersonTypeEnum
    {
        /// <summary>
        /// Customer person
        /// </summary>
        [Description("The one who consumes the products and/or services")]
        Customer = 1,

        /// <summary>
        /// Supplier person
        /// </summary>
        [Description("The one who provides the products and/or services")]
        Supplier = 2,

        /// <summary>
        /// Employer person
        /// </summary>
        [Description("The one who employs or contracts professional services")]
        Employer = 3

    }

}