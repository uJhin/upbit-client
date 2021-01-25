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
  public class OrderbookUnit {
    /// <summary>
    /// 매도호가
    /// </summary>
    /// <value>매도호가</value>
    [DataMember(Name="ask_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask_price")]
    public double? AskPrice { get; set; }

    /// <summary>
    /// 매수호가
    /// </summary>
    /// <value>매수호가</value>
    [DataMember(Name="bid_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid_price")]
    public double? BidPrice { get; set; }

    /// <summary>
    /// 매도 잔량
    /// </summary>
    /// <value>매도 잔량</value>
    [DataMember(Name="ask_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask_size")]
    public double? AskSize { get; set; }

    /// <summary>
    /// 매수 잔량
    /// </summary>
    /// <value>매수 잔량</value>
    [DataMember(Name="bid_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid_size")]
    public double? BidSize { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderbookUnit {\n");
      sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
      sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
      sb.Append("  AskSize: ").Append(AskSize).Append("\n");
      sb.Append("  BidSize: ").Append(BidSize).Append("\n");
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
