using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class APIKey {
    /// <summary>
    /// Gets or Sets AccessKey
    /// </summary>
    [DataMember(Name="access_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_key")]
    public string AccessKey { get; set; }

    /// <summary>
    /// Gets or Sets ExpireAt
    /// </summary>
    [DataMember(Name="expire_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expire_at")]
    public string ExpireAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class APIKey {\n");
      sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
      sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
