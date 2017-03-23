/*
 * FDB Device Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.05
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// StorageInfo
    /// </summary>
    [DataContract]
    public partial class StorageInfo : IEquatable<StorageInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfo" /> class.
        /// </summary>
        /// <param name="StorageHandlingType">StorageHandlingType.</param>
        /// <param name="StorageLowValue">StorageLowValue.</param>
        /// <param name="StorageLowValueUnit">StorageLowValueUnit.</param>
        /// <param name="StorageHighValue">StorageHighValue.</param>
        /// <param name="StorageHighValueUnit">StorageHighValueUnit.</param>
        /// <param name="StorageSpecialCondition">StorageSpecialCondition.</param>
        public StorageInfo(string StorageHandlingType = default(string), string StorageLowValue = default(string), string StorageLowValueUnit = default(string), string StorageHighValue = default(string), string StorageHighValueUnit = default(string), string StorageSpecialCondition = default(string))
        {
            this.StorageHandlingType = StorageHandlingType;
            this.StorageLowValue = StorageLowValue;
            this.StorageLowValueUnit = StorageLowValueUnit;
            this.StorageHighValue = StorageHighValue;
            this.StorageHighValueUnit = StorageHighValueUnit;
            this.StorageSpecialCondition = StorageSpecialCondition;
        }

        /// <summary>
        /// Gets or Sets StorageHandlingType
        /// </summary>
        [DataMember(Name = "StorageHandlingType", EmitDefaultValue = false)]
        public string StorageHandlingType { get; set; }

        /// <summary>
        /// Gets or Sets StorageLowValue
        /// </summary>
        [DataMember(Name = "StorageLowValue", EmitDefaultValue = false)]
        public string StorageLowValue { get; set; }

        /// <summary>
        /// Gets or Sets StorageLowValueUnit
        /// </summary>
        [DataMember(Name = "StorageLowValueUnit", EmitDefaultValue = false)]
        public string StorageLowValueUnit { get; set; }

        /// <summary>
        /// Gets or Sets StorageHighValue
        /// </summary>
        [DataMember(Name = "StorageHighValue", EmitDefaultValue = false)]
        public string StorageHighValue { get; set; }

        /// <summary>
        /// Gets or Sets StorageHighValueUnit
        /// </summary>
        [DataMember(Name = "StorageHighValueUnit", EmitDefaultValue = false)]
        public string StorageHighValueUnit { get; set; }

        /// <summary>
        /// Gets or Sets StorageSpecialCondition
        /// </summary>
        [DataMember(Name = "StorageSpecialCondition", EmitDefaultValue = false)]
        public string StorageSpecialCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageInfo {\n");
            sb.Append("  StorageHandlingType: ").Append(StorageHandlingType).Append("\n");
            sb.Append("  StorageLowValue: ").Append(StorageLowValue).Append("\n");
            sb.Append("  StorageLowValueUnit: ").Append(StorageLowValueUnit).Append("\n");
            sb.Append("  StorageHighValue: ").Append(StorageHighValue).Append("\n");
            sb.Append("  StorageHighValueUnit: ").Append(StorageHighValueUnit).Append("\n");
            sb.Append("  StorageSpecialCondition: ").Append(StorageSpecialCondition).Append("\n");
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
            return this.Equals(obj as StorageInfo);
        }

        /// <summary>
        /// Returns true if StorageInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.StorageHandlingType == other.StorageHandlingType ||
                    this.StorageHandlingType != null &&
                    this.StorageHandlingType.Equals(other.StorageHandlingType)
                ) &&
                (
                    this.StorageLowValue == other.StorageLowValue ||
                    this.StorageLowValue != null &&
                    this.StorageLowValue.Equals(other.StorageLowValue)
                ) &&
                (
                    this.StorageLowValueUnit == other.StorageLowValueUnit ||
                    this.StorageLowValueUnit != null &&
                    this.StorageLowValueUnit.Equals(other.StorageLowValueUnit)
                ) &&
                (
                    this.StorageHighValue == other.StorageHighValue ||
                    this.StorageHighValue != null &&
                    this.StorageHighValue.Equals(other.StorageHighValue)
                ) &&
                (
                    this.StorageHighValueUnit == other.StorageHighValueUnit ||
                    this.StorageHighValueUnit != null &&
                    this.StorageHighValueUnit.Equals(other.StorageHighValueUnit)
                ) &&
                (
                    this.StorageSpecialCondition == other.StorageSpecialCondition ||
                    this.StorageSpecialCondition != null &&
                    this.StorageSpecialCondition.Equals(other.StorageSpecialCondition)
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
                if (this.StorageHandlingType != null)
                    hash = hash * 59 + this.StorageHandlingType.GetHashCode();
                if (this.StorageLowValue != null)
                    hash = hash * 59 + this.StorageLowValue.GetHashCode();
                if (this.StorageLowValueUnit != null)
                    hash = hash * 59 + this.StorageLowValueUnit.GetHashCode();
                if (this.StorageHighValue != null)
                    hash = hash * 59 + this.StorageHighValue.GetHashCode();
                if (this.StorageHighValueUnit != null)
                    hash = hash * 59 + this.StorageHighValueUnit.GetHashCode();
                if (this.StorageSpecialCondition != null)
                    hash = hash * 59 + this.StorageSpecialCondition.GetHashCode();
                return hash;
            }
        }
    }
}