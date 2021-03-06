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
    public partial class Product : IEquatable<Product>
    { 
        /// <summary>
        /// A provider specific unique identifier for this product. This identifier must be unique to a product but does not otherwise need to adhere to ID permanence guidelines.
        /// </summary>
        /// <value>A provider specific unique identifier for this product. This identifier must be unique to a product but does not otherwise need to adhere to ID permanence guidelines.</value>
        [Required]
        [DataMember(Name="productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// The date and time from which this product is effective (ie. is available for origination).  Used to enable the articulation of products to the regime before they are available for customers to originate
        /// </summary>
        /// <value>The date and time from which this product is effective (ie. is available for origination).  Used to enable the articulation of products to the regime before they are available for customers to originate</value>
        [DataMember(Name="effectiveFrom")]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// The date and time at which this product will be retired and will no longer be offered.  Used to enable the managed deprecation of products
        /// </summary>
        /// <value>The date and time at which this product will be retired and will no longer be offered.  Used to enable the managed deprecation of products</value>
        [DataMember(Name="effectiveTo")]
        public string EffectiveTo { get; set; }

        /// <summary>
        /// The last date and time that the information for this product was changed (or the creation date for the product if it has never been altered)
        /// </summary>
        /// <value>The last date and time that the information for this product was changed (or the creation date for the product if it has never been altered)</value>
        [Required]
        [DataMember(Name="lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets ProductCategory
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EnumProductCategory
        {
            /// <summary>
            /// Enum PERSATCALLDEPOSITSEnum for PERS_AT_CALL_DEPOSITS
            /// </summary>
            [EnumMember(Value = "PERS_AT_CALL_DEPOSITS")]
            PERSATCALLDEPOSITSEnum = 1,            /// <summary>
            /// Enum BUSATCALLDEPOSITSEnum for BUS_AT_CALL_DEPOSITS
            /// </summary>
            [EnumMember(Value = "BUS_AT_CALL_DEPOSITS")]
            BUSATCALLDEPOSITSEnum = 2,            /// <summary>
            /// Enum TERMDEPOSITSEnum for TERM_DEPOSITS
            /// </summary>
            [EnumMember(Value = "TERM_DEPOSITS")]
            TERMDEPOSITSEnum = 3,            /// <summary>
            /// Enum RESIDENTIALMORTGAGESEnum for RESIDENTIAL_MORTGAGES
            /// </summary>
            [EnumMember(Value = "RESIDENTIAL_MORTGAGES")]
            RESIDENTIALMORTGAGESEnum = 4,            /// <summary>
            /// Enum PERSCREDANDCHRGCARDSEnum for PERS_CRED_AND_CHRG_CARDS
            /// </summary>
            [EnumMember(Value = "PERS_CRED_AND_CHRG_CARDS")]
            PERSCREDANDCHRGCARDSEnum = 5,            /// <summary>
            /// Enum BUSCREDANDCHRGCARDSEnum for BUS_CRED_AND_CHRG_CARDS
            /// </summary>
            [EnumMember(Value = "BUS_CRED_AND_CHRG_CARDS")]
            BUSCREDANDCHRGCARDSEnum = 6,            /// <summary>
            /// Enum PERSLOANSEnum for PERS_LOANS
            /// </summary>
            [EnumMember(Value = "PERS_LOANS")]
            PERSLOANSEnum = 7,            /// <summary>
            /// Enum PERSLEASINGEnum for PERS_LEASING
            /// </summary>
            [EnumMember(Value = "PERS_LEASING")]
            PERSLEASINGEnum = 8,            /// <summary>
            /// Enum BUSLEASINGEnum for BUS_LEASING
            /// </summary>
            [EnumMember(Value = "BUS_LEASING")]
            BUSLEASINGEnum = 9,            /// <summary>
            /// Enum TRADEFINANCEEnum for TRADE_FINANCE
            /// </summary>
            [EnumMember(Value = "TRADE_FINANCE")]
            TRADEFINANCEEnum = 10,            /// <summary>
            /// Enum PERSOVERDRAFTEnum for PERS_OVERDRAFT
            /// </summary>
            [EnumMember(Value = "PERS_OVERDRAFT")]
            PERSOVERDRAFTEnum = 11,            /// <summary>
            /// Enum BUSOVERDRAFTEnum for BUS_OVERDRAFT
            /// </summary>
            [EnumMember(Value = "BUS_OVERDRAFT")]
            BUSOVERDRAFTEnum = 12,            /// <summary>
            /// Enum BUSLOANSEnum for BUS_LOANS
            /// </summary>
            [EnumMember(Value = "BUS_LOANS")]
            BUSLOANSEnum = 13,            /// <summary>
            /// Enum FOREIGNCURRATCALLDEPOSITSEnum for FOREIGN_CURR_AT_CALL_DEPOSITS
            /// </summary>
            [EnumMember(Value = "FOREIGN_CURR_AT_CALL_DEPOSITS")]
            FOREIGNCURRATCALLDEPOSITSEnum = 14,            /// <summary>
            /// Enum FOREIGNCURRTERMDEPOSITSEnum for FOREIGN_CURR_TERM_DEPOSITS
            /// </summary>
            [EnumMember(Value = "FOREIGN_CURR_TERM_DEPOSITS")]
            FOREIGNCURRTERMDEPOSITSEnum = 15,            /// <summary>
            /// Enum FOREIGNCURRLOANEnum for FOREIGN_CURR_LOAN
            /// </summary>
            [EnumMember(Value = "FOREIGN_CURR_LOAN")]
            FOREIGNCURRLOANEnum = 16,            /// <summary>
            /// Enum FOREIGNCURRRENCTOVERDRAFTEnum for FOREIGN_CURRRENCT_OVERDRAFT
            /// </summary>
            [EnumMember(Value = "FOREIGN_CURRRENCT_OVERDRAFT")]
            FOREIGNCURRRENCTOVERDRAFTEnum = 17,            /// <summary>
            /// Enum TRAVELCARDEnum for TRAVEL_CARD
            /// </summary>
            [EnumMember(Value = "TRAVEL_CARD")]
            TRAVELCARDEnum = 18
        }

        /// <summary>
        /// Gets or Sets ProductCategory
        /// </summary>
        [Required]
        [DataMember(Name="productCategory")]
        public EnumProductCategory? ProductCategory { get; set; }

        /// <summary>
        /// The display name of the product
        /// </summary>
        /// <value>The display name of the product</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// A description of the product
        /// </summary>
        /// <value>A description of the product</value>
        [Required]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// A label of the brand for the product. Able to be used for filtering. For data providers with single brands this value is still required
        /// </summary>
        /// <value>A label of the brand for the product. Able to be used for filtering. For data providers with single brands this value is still required</value>
        [Required]
        [DataMember(Name="brand")]
        public string Brand { get; set; }

        /// <summary>
        /// An optional display name of the brand
        /// </summary>
        /// <value>An optional display name of the brand</value>
        [DataMember(Name="brandName")]
        public string BrandName { get; set; }

        /// <summary>
        /// A link to the an application web page where this product can be applied for.
        /// </summary>
        /// <value>A link to the an application web page where this product can be applied for.</value>
        [DataMember(Name="applicationUri")]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Indicates whether the product is specifically tailored to a circumstance.  In this case fees and prices are significantly negotiated depending on context. While all products are open to a degree of tailoring this flag indicates that tailoring is expected and thus that the provision of specific fees and rates is not applicable
        /// </summary>
        /// <value>Indicates whether the product is specifically tailored to a circumstance.  In this case fees and prices are significantly negotiated depending on context. While all products are open to a degree of tailoring this flag indicates that tailoring is expected and thus that the provision of specific fees and rates is not applicable</value>
        [Required]
        [DataMember(Name="isTailored")]
        public bool? IsTailored { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInformation
        /// </summary>
        [DataMember(Name="additionalInformation")]
        public ProductAdditionalInformation AdditionalInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  EffectiveTo: ").Append(EffectiveTo).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  ProductCategory: ").Append(ProductCategory).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
            sb.Append("  IsTailored: ").Append(IsTailored).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Product)obj);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="other">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    EffectiveFrom == other.EffectiveFrom ||
                    EffectiveFrom != null &&
                    EffectiveFrom.Equals(other.EffectiveFrom)
                ) && 
                (
                    EffectiveTo == other.EffectiveTo ||
                    EffectiveTo != null &&
                    EffectiveTo.Equals(other.EffectiveTo)
                ) && 
                (
                    LastUpdated == other.LastUpdated ||
                    LastUpdated != null &&
                    LastUpdated.Equals(other.LastUpdated)
                ) && 
                (
                    ProductCategory == other.ProductCategory ||
                    ProductCategory != null &&
                    ProductCategory.Equals(other.ProductCategory)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Brand == other.Brand ||
                    Brand != null &&
                    Brand.Equals(other.Brand)
                ) && 
                (
                    BrandName == other.BrandName ||
                    BrandName != null &&
                    BrandName.Equals(other.BrandName)
                ) && 
                (
                    ApplicationUri == other.ApplicationUri ||
                    ApplicationUri != null &&
                    ApplicationUri.Equals(other.ApplicationUri)
                ) && 
                (
                    IsTailored == other.IsTailored ||
                    IsTailored != null &&
                    IsTailored.Equals(other.IsTailored)
                ) && 
                (
                    AdditionalInformation == other.AdditionalInformation ||
                    AdditionalInformation != null &&
                    AdditionalInformation.Equals(other.AdditionalInformation)
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
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (EffectiveFrom != null)
                    hashCode = hashCode * 59 + EffectiveFrom.GetHashCode();
                    if (EffectiveTo != null)
                    hashCode = hashCode * 59 + EffectiveTo.GetHashCode();
                    if (LastUpdated != null)
                    hashCode = hashCode * 59 + LastUpdated.GetHashCode();
                    if (ProductCategory != null)
                    hashCode = hashCode * 59 + ProductCategory.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Brand != null)
                    hashCode = hashCode * 59 + Brand.GetHashCode();
                    if (BrandName != null)
                    hashCode = hashCode * 59 + BrandName.GetHashCode();
                    if (ApplicationUri != null)
                    hashCode = hashCode * 59 + ApplicationUri.GetHashCode();
                    if (IsTailored != null)
                    hashCode = hashCode * 59 + IsTailored.GetHashCode();
                    if (AdditionalInformation != null)
                    hashCode = hashCode * 59 + AdditionalInformation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Product left, Product right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Product left, Product right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
