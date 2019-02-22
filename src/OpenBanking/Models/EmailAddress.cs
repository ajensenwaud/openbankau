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
    public partial class EmailAddress : IEquatable<EmailAddress>
    { 
        /// <summary>
        /// Required for one and only one email record in the collection. Denotes the default email address
        /// </summary>
        /// <value>Required for one and only one email record in the collection. Denotes the default email address</value>
        [Required]
        [DataMember(Name="isPreferred")]
        public bool? IsPreferred { get; set; }

        /// <summary>
        /// The purpose for the email, as specified by the customer (Enumeration)
        /// </summary>
        /// <value>The purpose for the email, as specified by the customer (Enumeration)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Enum WORKEnum for WORK
            /// </summary>
            [EnumMember(Value = "WORK")]
            WORKEnum = 1,            /// <summary>
            /// Enum HOMEEnum for HOME
            /// </summary>
            [EnumMember(Value = "HOME")]
            HOMEEnum = 2,            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 3,            /// <summary>
            /// Enum UNSPECIFIEDEnum for UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "UNSPECIFIED")]
            UNSPECIFIEDEnum = 4
        }

        /// <summary>
        /// The purpose for the email, as specified by the customer (Enumeration)
        /// </summary>
        /// <value>The purpose for the email, as specified by the customer (Enumeration)</value>
        [Required]
        [DataMember(Name="purpose")]
        public PurposeEnum? Purpose { get; set; }

        /// <summary>
        /// A correctly formatted email address, as defined by the addr_spec format in RFC_5322
        /// </summary>
        /// <value>A correctly formatted email address, as defined by the addr_spec format in RFC_5322</value>
        [Required]
        [DataMember(Name="address")]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailAddress {\n");
            sb.Append("  IsPreferred: ").Append(IsPreferred).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EmailAddress)obj);
        }

        /// <summary>
        /// Returns true if EmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAddress other)
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
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
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
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmailAddress left, EmailAddress right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmailAddress left, EmailAddress right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
