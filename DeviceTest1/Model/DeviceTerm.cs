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
    public partial class DeviceTerm :  IEquatable<DeviceTerm>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTerm" /> class.
        /// Initializes a new instance of the <see cref="DeviceTerm" />class.
        /// </summary>
        /// <param name="DeviceTermType">DeviceTermType.</param>
        /// <param name="DeviceTermDefinition">DeviceTermDefinition.</param>

        public DeviceTerm(string DeviceTermType = null, string DeviceTermDefinition = null)
        {
            this.DeviceTermType = DeviceTermType;
            this.DeviceTermDefinition = DeviceTermDefinition;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DeviceTermType
        /// </summary>
        [DataMember(Name="DeviceTermType", EmitDefaultValue=false)]
        public string DeviceTermType { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceTermDefinition
        /// </summary>
        [DataMember(Name="DeviceTermDefinition", EmitDefaultValue=false)]
        public string DeviceTermDefinition { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceTerm {\n");
            sb.Append("  DeviceTermType: ").Append(DeviceTermType).Append("\n");
            sb.Append("  DeviceTermDefinition: ").Append(DeviceTermDefinition).Append("\n");
            
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
            return this.Equals(obj as DeviceTerm);
        }

        /// <summary>
        /// Returns true if DeviceTerm instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTerm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceTermType == other.DeviceTermType ||
                    this.DeviceTermType != null &&
                    this.DeviceTermType.Equals(other.DeviceTermType)
                ) && 
                (
                    this.DeviceTermDefinition == other.DeviceTermDefinition ||
                    this.DeviceTermDefinition != null &&
                    this.DeviceTermDefinition.Equals(other.DeviceTermDefinition)
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
                
                if (this.DeviceTermType != null)
                    hash = hash * 59 + this.DeviceTermType.GetHashCode();
                
                if (this.DeviceTermDefinition != null)
                    hash = hash * 59 + this.DeviceTermDefinition.GetHashCode();
                
                return hash;
            }
        }

    }
}
