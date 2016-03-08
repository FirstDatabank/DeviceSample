using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SearchDevicesResponse :  IEquatable<SearchDevicesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDevicesResponse" /> class.
        /// Initializes a new instance of the <see cref="SearchDevicesResponse" />class.
        /// </summary>
        /// <param name="SeviceCallID">Returns the unique identifier for each service call..</param>
        /// <param name="Limit">Returns the maximum number of results that are returned.</param>
        /// <param name="Offset">Returns the index page number of the data that is returned.</param>
        /// <param name="TotalResultCount">Returns the total number of available results.</param>
        /// <param name="Items">Items.</param>

        public SearchDevicesResponse(string SeviceCallID = null, int? Limit = null, int? Offset = null, int? TotalResultCount = null, List<Device> Items = null)
        {
            this.SeviceCallID = SeviceCallID;
            this.Limit = Limit;
            this.Offset = Offset;
            this.TotalResultCount = TotalResultCount;
            this.Items = Items;
            
        }
        
    
        /// <summary>
        /// Returns the unique identifier for each service call.
        /// </summary>
        /// <value>Returns the unique identifier for each service call.</value>
        [DataMember(Name="SeviceCallID", EmitDefaultValue=false)]
        public string SeviceCallID { get; set; }
    
        /// <summary>
        /// Returns the maximum number of results that are returned
        /// </summary>
        /// <value>Returns the maximum number of results that are returned</value>
        [DataMember(Name="Limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
    
        /// <summary>
        /// Returns the index page number of the data that is returned
        /// </summary>
        /// <value>Returns the index page number of the data that is returned</value>
        [DataMember(Name="Offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }
    
        /// <summary>
        /// Returns the total number of available results
        /// </summary>
        /// <value>Returns the total number of available results</value>
        [DataMember(Name="TotalResultCount", EmitDefaultValue=false)]
        public int? TotalResultCount { get; set; }
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<Device> Items { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDevicesResponse {\n");
            sb.Append("  SeviceCallID: ").Append(SeviceCallID).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  TotalResultCount: ").Append(TotalResultCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            
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
            return this.Equals(obj as SearchDevicesResponse);
        }

        /// <summary>
        /// Returns true if SearchDevicesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchDevicesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchDevicesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SeviceCallID == other.SeviceCallID ||
                    this.SeviceCallID != null &&
                    this.SeviceCallID.Equals(other.SeviceCallID)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.TotalResultCount == other.TotalResultCount ||
                    this.TotalResultCount != null &&
                    this.TotalResultCount.Equals(other.TotalResultCount)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                
                if (this.SeviceCallID != null)
                    hash = hash * 59 + this.SeviceCallID.GetHashCode();
                
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                
                if (this.TotalResultCount != null)
                    hash = hash * 59 + this.TotalResultCount.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                return hash;
            }
        }

    }
}
