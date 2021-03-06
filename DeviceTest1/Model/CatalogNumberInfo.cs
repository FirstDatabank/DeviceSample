/* 
 * FDB Prizm Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DeviceSample.Model
{
    /// <summary>
    /// CatalogNumberInfo
    /// </summary>
    [DataContract]
    public partial class CatalogNumberInfo :  IEquatable<CatalogNumberInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogNumberInfo" /> class.
        /// </summary>
        /// <param name="CatalogNumber">CatalogNumber.</param>
        /// <param name="IsTransactional">IsTransactional.</param>
        /// <param name="IsLabeled">IsLabeled.</param>
        /// <param name="CatalogCompanyName">CatalogCompanyName.</param>
        public CatalogNumberInfo(string CatalogNumber = default(string), bool? IsTransactional = default(bool?), bool? IsLabeled = default(bool?), string CatalogCompanyName = default(string))
        {
            this.CatalogNumber = CatalogNumber;
            this.IsTransactional = IsTransactional;
            this.IsLabeled = IsLabeled;
            this.CatalogCompanyName = CatalogCompanyName;
        }
        
        /// <summary>
        /// Gets or Sets CatalogNumber
        /// </summary>
        [DataMember(Name="CatalogNumber", EmitDefaultValue=false)]
        public string CatalogNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsTransactional
        /// </summary>
        [DataMember(Name="IsTransactional", EmitDefaultValue=false)]
        public bool? IsTransactional { get; set; }

        /// <summary>
        /// Gets or Sets IsLabeled
        /// </summary>
        [DataMember(Name="IsLabeled", EmitDefaultValue=false)]
        public bool? IsLabeled { get; set; }

        /// <summary>
        /// Gets or Sets CatalogCompanyName
        /// </summary>
        [DataMember(Name="CatalogCompanyName", EmitDefaultValue=false)]
        public string CatalogCompanyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogNumberInfo {\n");
            sb.Append("  CatalogNumber: ").Append(CatalogNumber).Append("\n");
            sb.Append("  IsTransactional: ").Append(IsTransactional).Append("\n");
            sb.Append("  IsLabeled: ").Append(IsLabeled).Append("\n");
            sb.Append("  CatalogCompanyName: ").Append(CatalogCompanyName).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CatalogNumberInfo);
        }

        /// <summary>
        /// Returns true if CatalogNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogNumberInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogNumber == other.CatalogNumber ||
                    this.CatalogNumber != null &&
                    this.CatalogNumber.Equals(other.CatalogNumber)
                ) && 
                (
                    this.IsTransactional == other.IsTransactional ||
                    this.IsTransactional != null &&
                    this.IsTransactional.Equals(other.IsTransactional)
                ) && 
                (
                    this.IsLabeled == other.IsLabeled ||
                    this.IsLabeled != null &&
                    this.IsLabeled.Equals(other.IsLabeled)
                ) && 
                (
                    this.CatalogCompanyName == other.CatalogCompanyName ||
                    this.CatalogCompanyName != null &&
                    this.CatalogCompanyName.Equals(other.CatalogCompanyName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CatalogNumber != null)
                    hash = hash * 59 + this.CatalogNumber.GetHashCode();
                if (this.IsTransactional != null)
                    hash = hash * 59 + this.IsTransactional.GetHashCode();
                if (this.IsLabeled != null)
                    hash = hash * 59 + this.IsLabeled.GetHashCode();
                if (this.CatalogCompanyName != null)
                    hash = hash * 59 + this.CatalogCompanyName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
