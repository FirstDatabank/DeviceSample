/* 
 * FDB Device Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.05
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DeviceSearch.Model
{
    /// <summary>
    /// Returns the categoriztion information of the device
    /// </summary>
    [DataContract]
    public partial class DeviceCategory : IEquatable<DeviceCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCategory" /> class.
        /// </summary>
        /// <param name="CategoryName">Returns the category name.</param>
        /// <param name="CategoryType">Returns the category type.</param>
        /// <param name="CategoryCode">Returns the category code, if it exists.</param>
        public DeviceCategory(string CategoryName = default(string), string CategoryType = default(string), string CategoryCode = default(string))
        {
            this.CategoryName = CategoryName;
            this.CategoryType = CategoryType;
            this.CategoryCode = CategoryCode;
        }

        /// <summary>
        /// Returns the category name
        /// </summary>
        /// <value>Returns the category name</value>
        [DataMember(Name = "CategoryName", EmitDefaultValue = false)]
        public string CategoryName { get; set; }
        /// <summary>
        /// Returns the category type
        /// </summary>
        /// <value>Returns the category type</value>
        [DataMember(Name = "CategoryType", EmitDefaultValue = false)]
        public string CategoryType { get; set; }
        /// <summary>
        /// Returns the category code, if it exists
        /// </summary>
        /// <value>Returns the category code, if it exists</value>
        [DataMember(Name = "CategoryCode", EmitDefaultValue = false)]
        public string CategoryCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceCategory {\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
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
            return this.Equals(obj as DeviceCategory);
        }

        /// <summary>
        /// Returns true if DeviceCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCategory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.CategoryName == other.CategoryName ||
                    this.CategoryName != null &&
                    this.CategoryName.Equals(other.CategoryName)
                ) &&
                (
                    this.CategoryType == other.CategoryType ||
                    this.CategoryType != null &&
                    this.CategoryType.Equals(other.CategoryType)
                ) &&
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
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
                if (this.CategoryName != null)
                    hash = hash * 59 + this.CategoryName.GetHashCode();
                if (this.CategoryType != null)
                    hash = hash * 59 + this.CategoryType.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                return hash;
            }
        }

    }

}
