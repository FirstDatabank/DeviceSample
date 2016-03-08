using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// Contains the call context parameters for all web service requests
    /// </summary>
    [DataContract]
    public partial class CallContext :  IEquatable<CallContext>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallContext" /> class.
        /// Initializes a new instance of the <see cref="CallContext" />class.
        /// </summary>
        /// <param name="CallID">Determines the customer&#39;s system identifier that uniquely identifies the current service call.</param>
        /// <param name="CallSystemName">Determines the calling system or application name.</param>
        /// <param name="DeptName">Determines the calling system&#39;s department that made the service call.</param>

        public CallContext(string CallID = null, string CallSystemName = null, string DeptName = null)
        {
            this.CallID = CallID;
            this.CallSystemName = CallSystemName;
            this.DeptName = DeptName;
            
        }
        
    
        /// <summary>
        /// Determines the customer's system identifier that uniquely identifies the current service call
        /// </summary>
        /// <value>Determines the customer's system identifier that uniquely identifies the current service call</value>
        [DataMember(Name="CallID", EmitDefaultValue=false)]
        public string CallID { get; set; }
    
        /// <summary>
        /// Determines the calling system or application name
        /// </summary>
        /// <value>Determines the calling system or application name</value>
        [DataMember(Name="CallSystemName", EmitDefaultValue=false)]
        public string CallSystemName { get; set; }
    
        /// <summary>
        /// Determines the calling system's department that made the service call
        /// </summary>
        /// <value>Determines the calling system's department that made the service call</value>
        [DataMember(Name="DeptName", EmitDefaultValue=false)]
        public string DeptName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallContext {\n");
            sb.Append("  CallID: ").Append(CallID).Append("\n");
            sb.Append("  CallSystemName: ").Append(CallSystemName).Append("\n");
            sb.Append("  DeptName: ").Append(DeptName).Append("\n");
            
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
            return this.Equals(obj as CallContext);
        }

        /// <summary>
        /// Returns true if CallContext instances are equal
        /// </summary>
        /// <param name="other">Instance of CallContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallID == other.CallID ||
                    this.CallID != null &&
                    this.CallID.Equals(other.CallID)
                ) && 
                (
                    this.CallSystemName == other.CallSystemName ||
                    this.CallSystemName != null &&
                    this.CallSystemName.Equals(other.CallSystemName)
                ) && 
                (
                    this.DeptName == other.DeptName ||
                    this.DeptName != null &&
                    this.DeptName.Equals(other.DeptName)
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
                
                if (this.CallID != null)
                    hash = hash * 59 + this.CallID.GetHashCode();
                
                if (this.CallSystemName != null)
                    hash = hash * 59 + this.CallSystemName.GetHashCode();
                
                if (this.DeptName != null)
                    hash = hash * 59 + this.DeptName.GetHashCode();
                
                return hash;
            }
        }

    }
}
