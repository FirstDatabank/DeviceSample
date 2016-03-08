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
    public partial class FDAProductInfo :  IEquatable<FDAProductInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FDAProductInfo" /> class.
        /// Initializes a new instance of the <see cref="FDAProductInfo" />class.
        /// </summary>
        /// <param name="FDAProductCode">FDAProductCode.</param>
        /// <param name="FDAProductCodeName">FDAProductCodeName.</param>
        /// <param name="FDAProductDeviceClass">FDAProductDeviceClass.</param>
        /// <param name="FDAProductDeviceClassDescription">FDAProductDeviceClassDescription.</param>
        /// <param name="AddDate">AddDate.</param>
        /// <param name="EndDate">EndDate.</param>

        public FDAProductInfo(string FDAProductCode = null, string FDAProductCodeName = null, string FDAProductDeviceClass = null, string FDAProductDeviceClassDescription = null, string AddDate = null, string EndDate = null)
        {
            this.FDAProductCode = FDAProductCode;
            this.FDAProductCodeName = FDAProductCodeName;
            this.FDAProductDeviceClass = FDAProductDeviceClass;
            this.FDAProductDeviceClassDescription = FDAProductDeviceClassDescription;
            this.AddDate = AddDate;
            this.EndDate = EndDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FDAProductCode
        /// </summary>
        [DataMember(Name="FDAProductCode", EmitDefaultValue=false)]
        public string FDAProductCode { get; set; }
    
        /// <summary>
        /// Gets or Sets FDAProductCodeName
        /// </summary>
        [DataMember(Name="FDAProductCodeName", EmitDefaultValue=false)]
        public string FDAProductCodeName { get; set; }
    
        /// <summary>
        /// Gets or Sets FDAProductDeviceClass
        /// </summary>
        [DataMember(Name="FDAProductDeviceClass", EmitDefaultValue=false)]
        public string FDAProductDeviceClass { get; set; }
    
        /// <summary>
        /// Gets or Sets FDAProductDeviceClassDescription
        /// </summary>
        [DataMember(Name="FDAProductDeviceClassDescription", EmitDefaultValue=false)]
        public string FDAProductDeviceClassDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets AddDate
        /// </summary>
        [DataMember(Name="AddDate", EmitDefaultValue=false)]
        public string AddDate { get; set; }
    
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FDAProductInfo {\n");
            sb.Append("  FDAProductCode: ").Append(FDAProductCode).Append("\n");
            sb.Append("  FDAProductCodeName: ").Append(FDAProductCodeName).Append("\n");
            sb.Append("  FDAProductDeviceClass: ").Append(FDAProductDeviceClass).Append("\n");
            sb.Append("  FDAProductDeviceClassDescription: ").Append(FDAProductDeviceClassDescription).Append("\n");
            sb.Append("  AddDate: ").Append(AddDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            
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
            return this.Equals(obj as FDAProductInfo);
        }

        /// <summary>
        /// Returns true if FDAProductInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FDAProductInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FDAProductInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FDAProductCode == other.FDAProductCode ||
                    this.FDAProductCode != null &&
                    this.FDAProductCode.Equals(other.FDAProductCode)
                ) && 
                (
                    this.FDAProductCodeName == other.FDAProductCodeName ||
                    this.FDAProductCodeName != null &&
                    this.FDAProductCodeName.Equals(other.FDAProductCodeName)
                ) && 
                (
                    this.FDAProductDeviceClass == other.FDAProductDeviceClass ||
                    this.FDAProductDeviceClass != null &&
                    this.FDAProductDeviceClass.Equals(other.FDAProductDeviceClass)
                ) && 
                (
                    this.FDAProductDeviceClassDescription == other.FDAProductDeviceClassDescription ||
                    this.FDAProductDeviceClassDescription != null &&
                    this.FDAProductDeviceClassDescription.Equals(other.FDAProductDeviceClassDescription)
                ) && 
                (
                    this.AddDate == other.AddDate ||
                    this.AddDate != null &&
                    this.AddDate.Equals(other.AddDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                
                if (this.FDAProductCode != null)
                    hash = hash * 59 + this.FDAProductCode.GetHashCode();
                
                if (this.FDAProductCodeName != null)
                    hash = hash * 59 + this.FDAProductCodeName.GetHashCode();
                
                if (this.FDAProductDeviceClass != null)
                    hash = hash * 59 + this.FDAProductDeviceClass.GetHashCode();
                
                if (this.FDAProductDeviceClassDescription != null)
                    hash = hash * 59 + this.FDAProductDeviceClassDescription.GetHashCode();
                
                if (this.AddDate != null)
                    hash = hash * 59 + this.AddDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
