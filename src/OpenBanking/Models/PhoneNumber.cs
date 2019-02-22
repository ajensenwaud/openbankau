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
    public partial class PhoneNumber : IEquatable<PhoneNumber>
    { 
        /// <summary>
        /// Required to be true for one and only one entry to indicate the preferred phone number.  Assumed to be &#39;false&#39; if not present
        /// </summary>
        /// <value>Required to be true for one and only one entry to indicate the preferred phone number.  Assumed to be &#39;false&#39; if not present</value>
        [DataMember(Name="isPreferred")]
        public bool? IsPreferred { get; set; }

        /// <summary>
        /// The purpose of the number as specified by the customer
        /// </summary>
        /// <value>The purpose of the number as specified by the customer</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Enum MOBILEEnum for MOBILE
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            MOBILEEnum = 1,            /// <summary>
            /// Enum HOMEEnum for HOME
            /// </summary>
            [EnumMember(Value = "HOME")]
            HOMEEnum = 2,            /// <summary>
            /// Enum WORKEnum for WORK
            /// </summary>
            [EnumMember(Value = "WORK")]
            WORKEnum = 3,            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 4,            /// <summary>
            /// Enum INTERNATIONALEnum for INTERNATIONAL
            /// </summary>
            [EnumMember(Value = "INTERNATIONAL")]
            INTERNATIONALEnum = 5,            /// <summary>
            /// Enum UNSPECIFIEDEnum for UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "UNSPECIFIED")]
            UNSPECIFIEDEnum = 6
        }

        /// <summary>
        /// The purpose of the number as specified by the customer
        /// </summary>
        /// <value>The purpose of the number as specified by the customer</value>
        [Required]
        [DataMember(Name="purpose")]
        public PurposeEnum? Purpose { get; set; }

        /// <summary>
        /// If absent, assumed to be Australia (+61). The + should be included
        /// </summary>
        /// <value>If absent, assumed to be Australia (+61). The + should be included</value>
        [DataMember(Name="countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Required for non Mobile Phones, if field is present and refers to Australian code - the leading 0 should be omitted.
        /// </summary>
        /// <value>Required for non Mobile Phones, if field is present and refers to Australian code - the leading 0 should be omitted.</value>
        [DataMember(Name="areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// The actual phone number, with leading zeros as appropriate
        /// </summary>
        /// <value>The actual phone number, with leading zeros as appropriate</value>
        [Required]
        [DataMember(Name="number")]
        public string Number { get; set; }

        /// <summary>
        /// An extension number (if applicable)
        /// </summary>
        /// <value>An extension number (if applicable)</value>
        [DataMember(Name="extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of RFC 3966
        /// </summary>
        /// <value>Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of RFC 3966</value>
        [Required]
        [DataMember(Name="fullNumber")]
        public string FullNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  IsPreferred: ").Append(IsPreferred).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  FullNumber: ").Append(FullNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PhoneNumber)obj);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsPreferred == other.IsPreferred ||
                    IsPreferred != null &&
                    IsPreferred.Equals(other.IsPreferred)
                ) && 
                (
                    Purpose == other.Purpose ||
                    Purpose != null &&
                    Purpose.Equals(other.Purpose)
                ) && 
                (
                    CountryCode == other.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    AreaCode == other.AreaCode ||
                    AreaCode != null &&
                    AreaCode.Equals(other.AreaCode)
                ) && 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    Extension == other.Extension ||
                    Extension != null &&
                    Extension.Equals(other.Extension)
                ) && 
                (
                    FullNumber == other.FullNumber ||
                    FullNumber != null &&
                    FullNumber.Equals(other.FullNumber)
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
                    if (IsPreferred != null)
                    hashCode = hashCode * 59 + IsPreferred.GetHashCode();
                    if (Purpose != null)
                    hashCode = hashCode * 59 + Purpose.GetHashCode();
                    if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                    if (AreaCode != null)
                    hashCode = hashCode * 59 + AreaCode.GetHashCode();
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (Extension != null)
                    hashCode = hashCode * 59 + Extension.GetHashCode();
                    if (FullNumber != null)
                    hashCode = hashCode * 59 + FullNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PhoneNumber left, PhoneNumber right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PhoneNumber left, PhoneNumber right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}