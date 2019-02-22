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
    public partial class DomesticPayeePayId : IEquatable<DomesticPayeePayId>
    { 
        /// <summary>
        /// The name assigned to the PayID by the owner of the PayID
        /// </summary>
        /// <value>The name assigned to the PayID by the owner of the PayID</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The identifier of the PayID (dependent on type)
        /// </summary>
        /// <value>The identifier of the PayID (dependent on type)</value>
        [Required]
        [DataMember(Name="identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The type of the PayID
        /// </summary>
        /// <value>The type of the PayID</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum EMAILEnum for EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAILEnum = 1,            /// <summary>
            /// Enum MOBILEEnum for MOBILE
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            MOBILEEnum = 2,            /// <summary>
            /// Enum ORGNUMBEREnum for ORG_NUMBER
            /// </summary>
            [EnumMember(Value = "ORG_NUMBER")]
            ORGNUMBEREnum = 3,            /// <summary>
            /// Enum ORGNAMEEnum for ORG_NAME
            /// </summary>
            [EnumMember(Value = "ORG_NAME")]
            ORGNAMEEnum = 4
        }

        /// <summary>
        /// The type of the PayID
        /// </summary>
        /// <value>The type of the PayID</value>
        [Required]
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomesticPayeePayId {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DomesticPayeePayId)obj);
        }

        /// <summary>
        /// Returns true if DomesticPayeePayId instances are equal
        /// </summary>
        /// <param name="other">Instance of DomesticPayeePayId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomesticPayeePayId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Identifier == other.Identifier ||
                    Identifier != null &&
                    Identifier.Equals(other.Identifier)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Identifier != null)
                    hashCode = hashCode * 59 + Identifier.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DomesticPayeePayId left, DomesticPayeePayId right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DomesticPayeePayId left, DomesticPayeePayId right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}