/*
 * FDB Device Services
 *
 * Web API for accessing medical device information
 *
 * OpenAPI spec version: 1.05
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// MRISafetyInfo
    /// </summary>
    [DataContract]
    public partial class MRISafetyInfo : IEquatable<MRISafetyInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MRISafetyInfo" /> class.
        /// </summary>
        /// <param name="MRISafetyLabel">MRISafetyLabel.</param>
        /// <param name="MRISafetySource">MRISafetySource.</param>
        public MRISafetyInfo(string MRISafetyLabel = default(string), string MRISafetySource = default(string))
        {
            this.MRISafetyLabel = MRISafetyLabel;
            this.MRISafetySource = MRISafetySource;
        }

        /// <summary>
        /// Gets or Sets MRISafetyLabel
        /// </summary>
        [DataMember(Name = "MRISafetyLabel", EmitDefaultValue = false)]
        public string MRISafetyLabel { get; set; }

        /// <summary>
        /// Gets or Sets MRISafetySource
        /// </summary>
        [DataMember(Name = "MRISafetySource", EmitDefaultValue = false)]
        public string MRISafetySource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MRISafetyInfo {\n");
            sb.Append("  MRISafetyLabel: ").Append(MRISafetyLabel).Append("\n");
            sb.Append("  MRISafetySource: ").Append(MRISafetySource).Append("\n");
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
            return this.Equals(obj as MRISafetyInfo);
        }

        /// <summary>
        /// Returns true if MRISafetyInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MRISafetyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MRISafetyInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.MRISafetyLabel == other.MRISafetyLabel ||
                    this.MRISafetyLabel != null &&
                    this.MRISafetyLabel.Equals(other.MRISafetyLabel)
                ) &&
                (
                    this.MRISafetySource == other.MRISafetySource ||
                    this.MRISafetySource != null &&
                    this.MRISafetySource.Equals(other.MRISafetySource)
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
                if (this.MRISafetyLabel != null)
                    hash = hash * 59 + this.MRISafetyLabel.GetHashCode();
                if (this.MRISafetySource != null)
                    hash = hash * 59 + this.MRISafetySource.GetHashCode();
                return hash;
            }
        }
    }
}