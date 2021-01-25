using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 마켓에 대한 정보
  /// </summary>
  [DataContract]
  public class Market {
    /// <summary>
    /// 마켓 ID
    /// </summary>
    /// <value>마켓 ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// 마켓 이름
    /// </summary>
    /// <value>마켓 이름</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// 지원 주문 방식
    /// </summary>
    /// <value>지원 주문 방식</value>
    [DataMember(Name="order_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_types")]
    public List<string> OrderTypes { get; set; }

    /// <summary>
    /// 지원 주문 종류
    /// </summary>
    /// <value>지원 주문 종류</value>
    [DataMember(Name="order_sides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_sides")]
    public List<string> OrderSides { get; set; }

    /// <summary>
    /// Gets or Sets Bid
    /// </summary>
    [DataMember(Name="bid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid")]
    public Bid Bid { get; set; }

    /// <summary>
    /// Gets or Sets Ask
    /// </summary>
    [DataMember(Name="ask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask")]
    public Ask Ask { get; set; }

    /// <summary>
    /// 최대 매도/매수 금액
    /// </summary>
    /// <value>최대 매도/매수 금액</value>
    [DataMember(Name="max_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_total")]
    public string MaxTotal { get; set; }

    /// <summary>
    /// 마켓 운영 상태
    /// </summary>
    /// <value>마켓 운영 상태</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Market {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OrderTypes: ").Append(OrderTypes).Append("\n");
      sb.Append("  OrderSides: ").Append(OrderSides).Append("\n");
      sb.Append("  Bid: ").Append(Bid).Append("\n");
      sb.Append("  Ask: ").Append(Ask).Append("\n");
      sb.Append("  MaxTotal: ").Append(MaxTotal).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
