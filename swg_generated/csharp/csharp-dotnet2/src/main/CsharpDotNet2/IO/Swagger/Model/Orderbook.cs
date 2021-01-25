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
  public class Orderbook {
    /// <summary>
    /// 마켓 코드
    /// </summary>
    /// <value>마켓 코드</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 호가 생성 시각
    /// </summary>
    /// <value>호가 생성 시각</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public decimal? Timestamp { get; set; }

    /// <summary>
    /// 호가 매도 총 잔량
    /// </summary>
    /// <value>호가 매도 총 잔량</value>
    [DataMember(Name="total_ask_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_ask_size")]
    public double? TotalAskSize { get; set; }

    /// <summary>
    /// 호가 매수 총량
    /// </summary>
    /// <value>호가 매수 총량</value>
    [DataMember(Name="total_bid_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_bid_size")]
    public double? TotalBidSize { get; set; }

    /// <summary>
    /// 호가
    /// </summary>
    /// <value>호가</value>
    [DataMember(Name="orderbook_units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderbook_units")]
    public List<OrderbookUnit> OrderbookUnits { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Orderbook {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  TotalAskSize: ").Append(TotalAskSize).Append("\n");
      sb.Append("  TotalBidSize: ").Append(TotalBidSize).Append("\n");
      sb.Append("  OrderbookUnits: ").Append(OrderbookUnits).Append("\n");
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
