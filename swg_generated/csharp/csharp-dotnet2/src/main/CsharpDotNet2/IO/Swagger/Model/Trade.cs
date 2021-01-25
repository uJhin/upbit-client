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
  public class Trade {
    /// <summary>
    /// 마켓의 유일 키
    /// </summary>
    /// <value>마켓의 유일 키</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 체결의 고유 아이디
    /// </summary>
    /// <value>체결의 고유 아이디</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// 체결 가격
    /// </summary>
    /// <value>체결 가격</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// 체결 양
    /// </summary>
    /// <value>체결 양</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public string Volume { get; set; }

    /// <summary>
    /// 체결된 총 가격
    /// </summary>
    /// <value>체결된 총 가격</value>
    [DataMember(Name="funds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funds")]
    public string Funds { get; set; }

    /// <summary>
    /// 체결 종류
    /// </summary>
    /// <value>체결 종류</value>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// 체결 시각
    /// </summary>
    /// <value>체결 시각</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Trade {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  Funds: ").Append(Funds).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
