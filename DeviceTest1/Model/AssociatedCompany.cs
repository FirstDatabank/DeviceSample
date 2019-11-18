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
    /// AssociatedCompany
    /// </summary>
    [DataContract]
    public partial class AssociatedCompany :  IEquatable<AssociatedCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedCompany" /> class.
        /// </summary>
        /// <param name="AssociatedCompanyId">AssociatedCompanyId.</param>
        /// <param name="AssociatedCompanyName">AssociatedCompanyName.</param>
        public AssociatedCompany(int? AssociatedCompanyId = default(int?), string AssociatedCompanyName = default(string))
        {
            this.AssociatedCompanyId = AssociatedCompanyId;
            this.AssociatedCompanyName = AssociatedCompanyName;
        }
        
        /// <summary>
        /// Gets or Sets AssociatedCompanyId
        /// </summary>
        [DataMember(Name="AssociatedCompanyId", EmitDefaultValue=false)]
        public int? AssociatedCompanyId { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedCompanyName
        /// </summary>
        [DataMember(Name="AssociatedCompanyName", EmitDefaultValue=false)]
        public string AssociatedCompanyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedCompany {\n");
            sb.Append("  AssociatedCompanyId: ").Append(AssociatedCompanyId).Append("\n");
            sb.Append("  AssociatedCompanyName: ").Append(AssociatedCompanyName).Append("\n");
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
            return this.Equals(obj as AssociatedCompany);
        }

        /// <summary>
        /// Returns true if AssociatedCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of AssociatedCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedCompany other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssociatedCompanyId == other.AssociatedCompanyId ||
                    this.AssociatedCompanyId != null &&
                    this.AssociatedCompanyId.Equals(other.AssociatedCompanyId)
                ) && 
                (
                    this.AssociatedCompanyName == other.AssociatedCompanyName ||
                    this.AssociatedCompanyName != null &&
                    this.AssociatedCompanyName.Equals(other.AssociatedCompanyName)
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
                if (this.AssociatedCompanyId != null)
                    hash = hash * 59 + this.AssociatedCompanyId.GetHashCode();
                if (this.AssociatedCompanyName != null)
                    hash = hash * 59 + this.AssociatedCompanyName.GetHashCode();
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