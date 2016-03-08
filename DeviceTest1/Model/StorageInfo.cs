using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class StorageInfo :  IEquatable<StorageInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageInfo" /> class.
        /// Initializes a new instance of the <see cref="StorageInfo" />class.
        /// </summary>
        /// <param name="StorageAndHandlingType">StorageAndHandlingType.</param>
        /// <param name="StorageLowValue">StorageLowValue.</param>
        /// <param name="StorageHighValue">StorageHighValue.</param>
        /// <param name="StorageUnitOfMeasure">StorageUnitOfMeasure.</param>
        /// <param name="StorageConditions">StorageConditions.</param>

        public StorageInfo(string StorageAndHandlingType = null, string StorageLowValue = null, string StorageHighValue = null, string StorageUnitOfMeasure = null, string StorageConditions = null)
        {
            this.StorageAndHandlingType = StorageAndHandlingType;
            this.StorageLowValue = StorageLowValue;
            this.StorageHighValue = StorageHighValue;
            this.StorageUnitOfMeasure = StorageUnitOfMeasure;
            this.StorageConditions = StorageConditions;
            
        }
        
    
        /// <summary>
        /// Gets or Sets StorageAndHandlingType
        /// </summary>
        [DataMember(Name="StorageAndHandlingType", EmitDefaultValue=false)]
        public string StorageAndHandlingType { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageLowValue
        /// </summary>
        [DataMember(Name="StorageLowValue", EmitDefaultValue=false)]
        public string StorageLowValue { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageHighValue
        /// </summary>
        [DataMember(Name="StorageHighValue", EmitDefaultValue=false)]
        public string StorageHighValue { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageUnitOfMeasure
        /// </summary>
        [DataMember(Name="StorageUnitOfMeasure", EmitDefaultValue=false)]
        public string StorageUnitOfMeasure { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageConditions
        /// </summary>
        [DataMember(Name="StorageConditions", EmitDefaultValue=false)]
        public string StorageConditions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageInfo {\n");
            sb.Append("  StorageAndHandlingType: ").Append(StorageAndHandlingType).Append("\n");
            sb.Append("  StorageLowValue: ").Append(StorageLowValue).Append("\n");
            sb.Append("  StorageHighValue: ").Append(StorageHighValue).Append("\n");
            sb.Append("  StorageUnitOfMeasure: ").Append(StorageUnitOfMeasure).Append("\n");
            sb.Append("  StorageConditions: ").Append(StorageConditions).Append("\n");
            
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
                    this.StorageAndHandlingType == other.StorageAndHandlingType ||
                    this.StorageAndHandlingType != null &&
                    this.StorageAndHandlingType.Equals(other.StorageAndHandlingType)
                ) && 
                (
                    this.StorageLowValue == other.StorageLowValue ||
                    this.StorageLowValue != null &&
                    this.StorageLowValue.Equals(other.StorageLowValue)
                ) && 
                (
                    this.StorageHighValue == other.StorageHighValue ||
                    this.StorageHighValue != null &&
                    this.StorageHighValue.Equals(other.StorageHighValue)
                ) && 
                (
                    this.StorageUnitOfMeasure == other.StorageUnitOfMeasure ||
                    this.StorageUnitOfMeasure != null &&
                    this.StorageUnitOfMeasure.Equals(other.StorageUnitOfMeasure)
                ) && 
                (
                    this.StorageConditions == other.StorageConditions ||
                    this.StorageConditions != null &&
                    this.StorageConditions.Equals(other.StorageConditions)
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
                
                if (this.StorageAndHandlingType != null)
                    hash = hash * 59 + this.StorageAndHandlingType.GetHashCode();
                
                if (this.StorageLowValue != null)
                    hash = hash * 59 + this.StorageLowValue.GetHashCode();
                
                if (this.StorageHighValue != null)
                    hash = hash * 59 + this.StorageHighValue.GetHashCode();
                
                if (this.StorageUnitOfMeasure != null)
                    hash = hash * 59 + this.StorageUnitOfMeasure.GetHashCode();
                
                if (this.StorageConditions != null)
                    hash = hash * 59 + this.StorageConditions.GetHashCode();
                
                return hash;
            }
        }

    }
}
