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
    public partial class TermDepositAccount : IEquatable<TermDepositAccount>
    { 
        /// <summary>
        /// The lodgement date of the original deposit
        /// </summary>
        /// <value>The lodgement date of the original deposit</value>
        [Required]
        [DataMember(Name="lodgementDate")]
        public string LodgementDate { get; set; }

        /// <summary>
        /// Maturity date for the term deposit
        /// </summary>
        /// <value>Maturity date for the term deposit</value>
        [Required]
        [DataMember(Name="maturityDate")]
        public string MaturityDate { get; set; }

        /// <summary>
        /// Amount to be paid upon maturity. If absent it implies the amount to paid is variable and cannot currently be calculated
        /// </summary>
        /// <value>Amount to be paid upon maturity. If absent it implies the amount to paid is variable and cannot currently be calculated</value>
        [DataMember(Name="maturityAmount")]
        public string MaturityAmount { get; set; }

        /// <summary>
        /// If absent assumes AUD
        /// </summary>
        /// <value>If absent assumes AUD</value>
        [DataMember(Name="maturityCurrency")]
        public string MaturityCurrency { get; set; }

        /// <summary>
        /// Current instructions on action to be taken at maturity
        /// </summary>
        /// <value>Current instructions on action to be taken at maturity</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MaturityInstructionsEnum
        {
            /// <summary>
            /// Enum ROLLEDOVEREnum for ROLLED_OVER
            /// </summary>
            [EnumMember(Value = "ROLLED_OVER")]
            ROLLEDOVEREnum = 1,            /// <summary>
            /// Enum PAIDOUTATMATURITYEnum for PAID_OUT_AT_MATURITY
            /// </summary>
            [EnumMember(Value = "PAID_OUT_AT_MATURITY")]
            PAIDOUTATMATURITYEnum = 2
        }

        /// <summary>
        /// Current instructions on action to be taken at maturity
        /// </summary>
        /// <value>Current instructions on action to be taken at maturity</value>
        [Required]
        [DataMember(Name="maturityInstructions")]
        public MaturityInstructionsEnum? MaturityInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermDepositAccount {\n");
            sb.Append("  LodgementDate: ").Append(LodgementDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  MaturityAmount: ").Append(MaturityAmount).Append("\n");
            sb.Append("  MaturityCurrency: ").Append(MaturityCurrency).Append("\n");
            sb.Append("  MaturityInstructions: ").Append(MaturityInstructions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TermDepositAccount)obj);
        }

        /// <summary>
        /// Returns true if TermDepositAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of TermDepositAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermDepositAccount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LodgementDate == other.LodgementDate ||
                    LodgementDate != null &&
                    LodgementDate.Equals(other.LodgementDate)
                ) && 
                (
                    MaturityDate == other.MaturityDate ||
                    MaturityDate != null &&
                    MaturityDate.Equals(other.MaturityDate)
                ) && 
                (
                    MaturityAmount == other.MaturityAmount ||
                    MaturityAmount != null &&
                    MaturityAmount.Equals(other.MaturityAmount)
                ) && 
                (
                    MaturityCurrency == other.MaturityCurrency ||
                    MaturityCurrency != null &&
                    MaturityCurrency.Equals(other.MaturityCurrency)
                ) && 
                (
                    MaturityInstructions == other.MaturityInstructions ||
                    MaturityInstructions != null &&
                    MaturityInstructions.Equals(other.MaturityInstructions)
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
                    if (LodgementDate != null)
                    hashCode = hashCode * 59 + LodgementDate.GetHashCode();
                    if (MaturityDate != null)
                    hashCode = hashCode * 59 + MaturityDate.GetHashCode();
                    if (MaturityAmount != null)
                    hashCode = hashCode * 59 + MaturityAmount.GetHashCode();
                    if (MaturityCurrency != null)
                    hashCode = hashCode * 59 + MaturityCurrency.GetHashCode();
                    if (MaturityInstructions != null)
                    hashCode = hashCode * 59 + MaturityInstructions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TermDepositAccount left, TermDepositAccount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TermDepositAccount left, TermDepositAccount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
