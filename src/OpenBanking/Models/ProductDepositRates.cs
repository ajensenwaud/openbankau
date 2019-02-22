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
    public partial class ProductDepositRates : IEquatable<ProductDepositRates>
    { 
        /// <summary>
        /// The type of rate (base, bonus, etc). See the next section for an overview of valid values and their meaning
        /// </summary>
        /// <value>The type of rate (base, bonus, etc). See the next section for an overview of valid values and their meaning</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DepositRateTypeEnum
        {
            /// <summary>
            /// Enum FIXEDEnum for FIXED
            /// </summary>
            [EnumMember(Value = "FIXED")]
            FIXEDEnum = 1,            /// <summary>
            /// Enum BONUSEnum for BONUS
            /// </summary>
            [EnumMember(Value = "BONUS")]
            BONUSEnum = 2,            /// <summary>
            /// Enum BUNDLEBONUSEnum for BUNDLE_BONUS
            /// </summary>
            [EnumMember(Value = "BUNDLE_BONUS")]
            BUNDLEBONUSEnum = 3,            /// <summary>
            /// Enum VARIABLEEnum for VARIABLE
            /// </summary>
            [EnumMember(Value = "VARIABLE")]
            VARIABLEEnum = 4,            /// <summary>
            /// Enum INTRODUCTORYEnum for INTRODUCTORY
            /// </summary>
            [EnumMember(Value = "INTRODUCTORY")]
            INTRODUCTORYEnum = 5
        }

        /// <summary>
        /// The type of rate (base, bonus, etc). See the next section for an overview of valid values and their meaning
        /// </summary>
        /// <value>The type of rate (base, bonus, etc). See the next section for an overview of valid values and their meaning</value>
        [Required]
        [DataMember(Name="depositRateType")]
        public DepositRateTypeEnum? DepositRateType { get; set; }

        /// <summary>
        /// The rate to be applied
        /// </summary>
        /// <value>The rate to be applied</value>
        [Required]
        [DataMember(Name="rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Generic field containing additional information relevant to the depositRateType specified. Whether mandatory or not is dependent on the value of depositRateType
        /// </summary>
        /// <value>Generic field containing additional information relevant to the depositRateType specified. Whether mandatory or not is dependent on the value of depositRateType</value>
        [DataMember(Name="additionalValue")]
        public string AdditionalValue { get; set; }

        /// <summary>
        /// Display text providing more information on the fee
        /// </summary>
        /// <value>Display text providing more information on the fee</value>
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Link to a web page with more information on this fee
        /// </summary>
        /// <value>Link to a web page with more information on this fee</value>
        [DataMember(Name="additionalInfoUri")]
        public string AdditionalInfoUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDepositRates {\n");
            sb.Append("  DepositRateType: ").Append(DepositRateType).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  AdditionalValue: ").Append(AdditionalValue).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  AdditionalInfoUri: ").Append(AdditionalInfoUri).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductDepositRates)obj);
        }

        /// <summary>
        /// Returns true if ProductDepositRates instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductDepositRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDepositRates other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DepositRateType == other.DepositRateType ||
                    DepositRateType != null &&
                    DepositRateType.Equals(other.DepositRateType)
                ) && 
                (
                    Rate == other.Rate ||
                    Rate != null &&
                    Rate.Equals(other.Rate)
                ) && 
                (
                    AdditionalValue == other.AdditionalValue ||
                    AdditionalValue != null &&
                    AdditionalValue.Equals(other.AdditionalValue)
                ) && 
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
                ) && 
                (
                    AdditionalInfoUri == other.AdditionalInfoUri ||
                    AdditionalInfoUri != null &&
                    AdditionalInfoUri.Equals(other.AdditionalInfoUri)
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
                    if (DepositRateType != null)
                    hashCode = hashCode * 59 + DepositRateType.GetHashCode();
                    if (Rate != null)
                    hashCode = hashCode * 59 + Rate.GetHashCode();
                    if (AdditionalValue != null)
                    hashCode = hashCode * 59 + AdditionalValue.GetHashCode();
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                    if (AdditionalInfoUri != null)
                    hashCode = hashCode * 59 + AdditionalInfoUri.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductDepositRates left, ProductDepositRates right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductDepositRates left, ProductDepositRates right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
