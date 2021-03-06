/*
 * Consumer Data Standards
 *
 * API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OpenBanking.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class LendingBalance : IEquatable<LendingBalance>
    { 
        /// <summary>
        /// Gets or Sets AccountBalance
        /// </summary>
        [Required]
        [DataMember(Name="accountBalance")]
        public CurrencyAmount AccountBalance { get; set; }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        [Required]
        [DataMember(Name="availableBalance")]
        public CurrencyAmount AvailableBalance { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [Required]
        [DataMember(Name="creditLimit")]
        public CurrencyAmount CreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets AmortisedLimit
        /// </summary>
        [DataMember(Name="amortisedLimit")]
        public CurrencyAmount AmortisedLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LendingBalance {\n");
            sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  AmortisedLimit: ").Append(AmortisedLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((LendingBalance)obj);
        }

        /// <summary>
        /// Returns true if LendingBalance instances are equal
        /// </summary>
        /// <param name="other">Instance of LendingBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LendingBalance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccountBalance == other.AccountBalance ||
                    AccountBalance != null &&
                    AccountBalance.Equals(other.AccountBalance)
                ) && 
                (
                    AvailableBalance == other.AvailableBalance ||
                    AvailableBalance != null &&
                    AvailableBalance.Equals(other.AvailableBalance)
                ) && 
                (
                    CreditLimit == other.CreditLimit ||
                    CreditLimit != null &&
                    CreditLimit.Equals(other.CreditLimit)
                ) && 
                (
                    AmortisedLimit == other.AmortisedLimit ||
                    AmortisedLimit != null &&
                    AmortisedLimit.Equals(other.AmortisedLimit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AccountBalance != null)
                    hashCode = hashCode * 59 + AccountBalance.GetHashCode();
                    if (AvailableBalance != null)
                    hashCode = hashCode * 59 + AvailableBalance.GetHashCode();
                    if (CreditLimit != null)
                    hashCode = hashCode * 59 + CreditLimit.GetHashCode();
                    if (AmortisedLimit != null)
                    hashCode = hashCode * 59 + AmortisedLimit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LendingBalance left, LendingBalance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LendingBalance left, LendingBalance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
