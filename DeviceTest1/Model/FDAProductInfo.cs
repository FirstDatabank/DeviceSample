﻿/* 
 * FDB Device Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.03
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
    /// Returns the FDAProductInfo information
    /// </summary>
    [DataContract]
    public partial class FDAProductInfo : IEquatable<FDAProductInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FDAProductInfo" /> class.
        /// </summary>
        /// <param name="FDAProductCode">Returns the FDAProductCode.</param>
        /// <param name="FDAProductCodeName">Returns the FDAProductCodeName.</param>
        /// <param name="FDAProductClass">Returns the FDAProductClass.</param>
        public FDAProductInfo(string FDAProductCode = null, string FDAProductCodeName = null, string FDAProductClass = null)
        {
            this.FDAProductCode = FDAProductCode;
            this.FDAProductCodeName = FDAProductCodeName;
            this.FDAProductClass = FDAProductClass;
        }

        /// <summary>
        /// Returns the FDAProductCode
        /// </summary>
        /// <value>Returns the FDAProductCode</value>
        [DataMember(Name = "FDAProductCode", EmitDefaultValue = false)]
        public string FDAProductCode { get; set; }
        /// <summary>
        /// Returns the FDAProductCodeName
        /// </summary>
        /// <value>Returns the FDAProductCodeName</value>
        [DataMember(Name = "FDAProductCodeName", EmitDefaultValue = false)]
        public string FDAProductCodeName { get; set; }
        /// <summary>
        /// Returns the FDAProductClass
        /// </summary>
        /// <value>Returns the FDAProductClass</value>
        [DataMember(Name = "FDAProductClass", EmitDefaultValue = false)]
        public string FDAProductClass { get; set; }
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
            sb.Append("  FDAProductClass: ").Append(FDAProductClass).Append("\n");
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
                    this.FDAProductClass == other.FDAProductClass ||
                    this.FDAProductClass != null &&
                    this.FDAProductClass.Equals(other.FDAProductClass)
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
                if (this.FDAProductClass != null)
                    hash = hash * 59 + this.FDAProductClass.GetHashCode();
                return hash;
            }
        }
    }

}
