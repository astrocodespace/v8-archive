/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Directus.Client.SwaggerDateConverter;

namespace IO.Directus.Model
{
    /// <summary>
    /// GetPreferencesData
    /// </summary>
    [DataContract]
    public partial class GetPreferencesData :  IEquatable<GetPreferencesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreferencesData" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="User">User.</param>
        /// <param name="TableName">TableName.</param>
        /// <param name="Title">Title.</param>
        /// <param name="ColumnsVisible">ColumnsVisible.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="SortOrder">SortOrder.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SearchString">SearchString.</param>
        public GetPreferencesData(int? Id = default(int?), int? User = default(int?), string TableName = default(string), string Title = default(string), string ColumnsVisible = default(string), string Sort = default(string), string SortOrder = default(string), string Status = default(string), string SearchString = default(string))
        {
            this.Id = Id;
            this.User = User;
            this.TableName = TableName;
            this.Title = Title;
            this.ColumnsVisible = ColumnsVisible;
            this.Sort = Sort;
            this.SortOrder = SortOrder;
            this.Status = Status;
            this.SearchString = SearchString;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="table_name", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ColumnsVisible
        /// </summary>
        [DataMember(Name="columns_visible", EmitDefaultValue=false)]
        public string ColumnsVisible { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SearchString
        /// </summary>
        [DataMember(Name="search_string", EmitDefaultValue=false)]
        public string SearchString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPreferencesData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ColumnsVisible: ").Append(ColumnsVisible).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetPreferencesData);
        }

        /// <summary>
        /// Returns true if GetPreferencesData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPreferencesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPreferencesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ColumnsVisible == input.ColumnsVisible ||
                    (this.ColumnsVisible != null &&
                    this.ColumnsVisible.Equals(input.ColumnsVisible))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SearchString == input.SearchString ||
                    (this.SearchString != null &&
                    this.SearchString.Equals(input.SearchString))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ColumnsVisible != null)
                    hashCode = hashCode * 59 + this.ColumnsVisible.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SearchString != null)
                    hashCode = hashCode * 59 + this.SearchString.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
