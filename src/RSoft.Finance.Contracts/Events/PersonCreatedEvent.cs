using RSoft.Lib.Common.Contracts.Entities;
using RSoft.Lib.Common.ValueObjects;
using RSoft.Lib.Messaging.Contracts;
using System;

namespace RSoft.Finance.Contracts.Events
{

    /// <summary>
    /// Occurs when a new person is created.
    /// </summary>
    public class PersonCreatedEvent : IMessageEvent, IAddress
    {

        #region Properties

        /// <summary>
        /// Person id key
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Person full name
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Street name
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Address number
        /// </summary>
        public string AddressNumber { get; set; }

        /// <summary>
        /// A secondary address like 'Apt. 2' or 'Suite 321'.
        /// </summary>
        public string SecondaryAddress { get; set; }

        /// <summary>
        /// District name
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// City data
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State data
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip Code
        /// </summary>
        public string ZipCode { get; set; }

        #endregion

    }
}
