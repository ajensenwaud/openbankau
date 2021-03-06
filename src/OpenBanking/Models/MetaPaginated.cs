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
    public partial class MetaPaginated : IEquatable<MetaPaginated>
    { 
        /// <summary>
        /// The total number of records in the full set
        /// </summary>
        /// <value>The total number of records in the full set</value>
        [DataMember(Name="totalRecords")]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// The total number of pages in the full set
        /// </summary>
        /// <value>The total number of pages in the full set</value>
        [DataMember(Name="totalPages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaPaginated {\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MetaPaginated)obj);
        }

        /// <summary>
        /// Returns true if MetaPaginated instances are equal
        /// </summary>
        /// <param name="other">Instance of MetaPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaPaginated other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TotalRecords == other.TotalRecords ||
                    TotalRecords != null &&
                    TotalRecords.Equals(other.TotalRecords)
                ) && 
                (
                    TotalPages == other.TotalPages ||
                    TotalPages != null &&
                    TotalPages.Equals(other.TotalPages)
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
                    if (TotalRecords != null)
                    hashCode = hashCode * 59 + TotalRecords.GetHashCode();
                    if (TotalPages != null)
                    hashCode = hashCode * 59 + TotalPages.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MetaPaginated left, MetaPaginated right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MetaPaginated left, MetaPaginated right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
