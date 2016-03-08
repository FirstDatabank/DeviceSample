using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// Returns clinical dimensions of the product
    /// </summary>
    [DataContract]
    public partial class SizeInfo :  IEquatable<SizeInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeInfo" /> class.
        /// Initializes a new instance of the <see cref="SizeInfo" />class.
        /// </summary>
        /// <param name="SizeUnit">SizeUnit.</param>
        /// <param name="SizeValue">SizeValue.</param>
        /// <param name="SizeType">SizeType.</param>
        /// <param name="SizeText">SizeText.</param>

        public SizeInfo(string SizeUnit = null, string SizeValue = null, string SizeType = null, string SizeText = null)
        {
            this.SizeUnit = SizeUnit;
            this.SizeValue = SizeValue;
            this.SizeType = SizeType;
            this.SizeText = SizeText;
            
        }
        
    
        /// <summary>
        /// Gets or Sets SizeUnit
        /// </summary>
        [DataMember(Name="SizeUnit", EmitDefaultValue=false)]
        public string SizeUnit { get; set; }
    
        /// <summary>
        /// Gets or Sets SizeValue
        /// </summary>
        [DataMember(Name="SizeValue", EmitDefaultValue=false)]
        public string SizeValue { get; set; }
    
        /// <summary>
        /// Gets or Sets SizeType
        /// </summary>
        [DataMember(Name="SizeType", EmitDefaultValue=false)]
        public string SizeType { get; set; }
    
        /// <summary>
        /// Gets or Sets SizeText
        /// </summary>
        [DataMember(Name="SizeText", EmitDefaultValue=false)]
        public string SizeText { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SizeInfo {\n");
            sb.Append("  SizeUnit: ").Append(SizeUnit).Append("\n");
            sb.Append("  SizeValue: ").Append(SizeValue).Append("\n");
            sb.Append("  SizeType: ").Append(SizeType).Append("\n");
            sb.Append("  SizeText: ").Append(SizeText).Append("\n");
            
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
            return this.Equals(obj as SizeInfo);
        }

        /// <summary>
        /// Returns true if SizeInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SizeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SizeInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SizeUnit == other.SizeUnit ||
                    this.SizeUnit != null &&
                    this.SizeUnit.Equals(other.SizeUnit)
                ) && 
                (
                    this.SizeValue == other.SizeValue ||
                    this.SizeValue != null &&
                    this.SizeValue.Equals(other.SizeValue)
                ) && 
                (
                    this.SizeType == other.SizeType ||
                    this.SizeType != null &&
                    this.SizeType.Equals(other.SizeType)
                ) && 
                (
                    this.SizeText == other.SizeText ||
                    this.SizeText != null &&
                    this.SizeText.Equals(other.SizeText)
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
                
                if (this.SizeUnit != null)
                    hash = hash * 59 + this.SizeUnit.GetHashCode();
                
                if (this.SizeValue != null)
                    hash = hash * 59 + this.SizeValue.GetHashCode();
                
                if (this.SizeType != null)
                    hash = hash * 59 + this.SizeType.GetHashCode();
                
                if (this.SizeText != null)
                    hash = hash * 59 + this.SizeText.GetHashCode();
                
                return hash;
            }
        }

    }
}
