/* 
 * FDB Device Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// </summary>
        /// <param name="SizeUnitAbbreviation">Returns the size unit abbreviation.</param>
        /// <param name="SizeValue">Returns the size.</param>
        /// <param name="SizeType">Returns the size type.</param>
        public SizeInfo(string SizeUnitAbbreviation = null, string SizeValue = null, string SizeType = null)
        {
            this.SizeUnitAbbreviation = SizeUnitAbbreviation;
            this.SizeValue = SizeValue;
            this.SizeType = SizeType;
        }
        
        /// <summary>
        /// Returns the size unit abbreviation
        /// </summary>
        /// <value>Returns the size unit abbreviation</value>
        [DataMember(Name="SizeUnitAbbreviation", EmitDefaultValue=false)]
        public string SizeUnitAbbreviation { get; set; }
        /// <summary>
        /// Returns the size
        /// </summary>
        /// <value>Returns the size</value>
        [DataMember(Name="SizeValue", EmitDefaultValue=false)]
        public string SizeValue { get; set; }
        /// <summary>
        /// Returns the size type
        /// </summary>
        /// <value>Returns the size type</value>
        [DataMember(Name="SizeType", EmitDefaultValue=false)]
        public string SizeType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SizeInfo {\n");
            sb.Append("  SizeUnitAbbreviation: ").Append(SizeUnitAbbreviation).Append("\n");
            sb.Append("  SizeValue: ").Append(SizeValue).Append("\n");
            sb.Append("  SizeType: ").Append(SizeType).Append("\n");
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
                    this.SizeUnitAbbreviation == other.SizeUnitAbbreviation ||
                    this.SizeUnitAbbreviation != null &&
                    this.SizeUnitAbbreviation.Equals(other.SizeUnitAbbreviation)
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
                if (this.SizeUnitAbbreviation != null)
                    hash = hash * 59 + this.SizeUnitAbbreviation.GetHashCode();
                if (this.SizeValue != null)
                    hash = hash * 59 + this.SizeValue.GetHashCode();
                if (this.SizeType != null)
                    hash = hash * 59 + this.SizeType.GetHashCode();
                return hash;
            }
        }
    }

}
