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
    public partial class BillerPayee : IEquatable<BillerPayee>
    { 
        /// <summary>
        /// BPay Biller Code of the Biller
        /// </summary>
        /// <value>BPay Biller Code of the Biller</value>
        [Required]
        [DataMember(Name="billerCode")]
        public string BillerCode { get; set; }

        /// <summary>
        /// BPay CRN of the Biller. If the contents of the CRN match the format of a Credit Card PAN then it should be masked using the rules applicable for the MaskedPANString common type
        /// </summary>
        /// <value>BPay CRN of the Biller. If the contents of the CRN match the format of a Credit Card PAN then it should be masked using the rules applicable for the MaskedPANString common type</value>
        [DataMember(Name="crn")]
        public string Crn { get; set; }

        /// <summary>
        /// Name of the Biller
        /// </summary>
        /// <value>Name of the Biller</value>
        [Required]
        [DataMember(Name="billerName")]
        public string BillerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillerPayee {\n");
            sb.Append("  BillerCode: ").Append(BillerCode).Append("\n");
            sb.Append("  Crn: ").Append(Crn).Append("\n");
            sb.Append("  BillerName: ").Append(BillerName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BillerPayee)obj);
        }

        /// <summary>
        /// Returns true if BillerPayee instances are equal
        /// </summary>
        /// <param name="other">Instance of BillerPayee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillerPayee other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BillerCode == other.BillerCode ||
                    BillerCode != null &&
                    BillerCode.Equals(other.BillerCode)
                ) && 
                (
                    Crn == other.Crn ||
                    Crn != null &&
                    Crn.Equals(other.Crn)
                ) && 
                (
                    BillerName == other.BillerName ||
                    BillerName != null &&
                    BillerName.Equals(other.BillerName)
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
                    if (BillerCode != null)
                    hashCode = hashCode * 59 + BillerCode.GetHashCode();
                    if (Crn != null)
                    hashCode = hashCode * 59 + Crn.GetHashCode();
                    if (BillerName != null)
                    hashCode = hashCode * 59 + BillerName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BillerPayee left, BillerPayee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BillerPayee left, BillerPayee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
