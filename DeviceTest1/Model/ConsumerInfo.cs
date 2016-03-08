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
    public partial class ConsumerInfo :  IEquatable<ConsumerInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerInfo" /> class.
        /// Initializes a new instance of the <see cref="ConsumerInfo" />class.
        /// </summary>
        /// <param name="ContactPhone">ContactPhone.</param>
        /// <param name="ContactEmail">ContactEmail.</param>

        public ConsumerInfo(string ContactPhone = null, string ContactEmail = null)
        {
            this.ContactPhone = ContactPhone;
            this.ContactEmail = ContactEmail;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="ContactPhone", EmitDefaultValue=false)]
        public string ContactPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name="ContactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerInfo {\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            
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
            return this.Equals(obj as ConsumerInfo);
        }

        /// <summary>
        /// Returns true if ConsumerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsumerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContactPhone == other.ContactPhone ||
                    this.ContactPhone != null &&
                    this.ContactPhone.Equals(other.ContactPhone)
                ) && 
                (
                    this.ContactEmail == other.ContactEmail ||
                    this.ContactEmail != null &&
                    this.ContactEmail.Equals(other.ContactEmail)
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
                
                if (this.ContactPhone != null)
                    hash = hash * 59 + this.ContactPhone.GetHashCode();
                
                if (this.ContactEmail != null)
                    hash = hash * 59 + this.ContactEmail.GetHashCode();
                
                return hash;
            }
        }

    }
}
