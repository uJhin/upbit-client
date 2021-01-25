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
  public class OrderInfo {
    /// <summary>
    /// 주문의 고유 아이디
    /// </summary>
    /// <value>주문의 고유 아이디</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// 주문 종류
    /// </summary>
    /// <value>주문 종류</value>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// 주문 방식
    /// </summary>
    /// <value>주문 방식</value>
    [DataMember(Name="ord_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ord_type")]
    public string OrdType { get; set; }

    /// <summary>
    /// 주문 당시 화폐 가격
    /// </summary>
    /// <value>주문 당시 화폐 가격</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// 주문 상태
    /// </summary>
    /// <value>주문 상태</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// 마켓의 유일키
    /// </summary>
    /// <value>마켓의 유일키</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 주문 생성 시간
    /// </summary>
    /// <value>주문 생성 시간</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// 사용자가 입력한 주문 양
    /// </summary>
    /// <value>사용자가 입력한 주문 양</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public string Volume { get; set; }

    /// <summary>
    /// 체결 후 남은 주문 양
    /// </summary>
    /// <value>체결 후 남은 주문 양</value>
    [DataMember(Name="remaining_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_volume")]
    public string RemainingVolume { get; set; }

    /// <summary>
    /// 수수료로 예약된 비용
    /// </summary>
    /// <value>수수료로 예약된 비용</value>
    [DataMember(Name="reserved_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reserved_fee")]
    public string ReservedFee { get; set; }

    /// <summary>
    /// 남은 수수료
    /// </summary>
    /// <value>남은 수수료</value>
    [DataMember(Name="remaining_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_fee")]
    public string RemainingFee { get; set; }

    /// <summary>
    /// 사용된 수수료
    /// </summary>
    /// <value>사용된 수수료</value>
    [DataMember(Name="paid_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paid_fee")]
    public string PaidFee { get; set; }

    /// <summary>
    /// 거래에 사용중인 비용
    /// </summary>
    /// <value>거래에 사용중인 비용</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public string Locked { get; set; }

    /// <summary>
    /// 체결된 양
    /// </summary>
    /// <value>체결된 양</value>
    [DataMember(Name="executed_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executed_volume")]
    public string ExecutedVolume { get; set; }

    /// <summary>
    /// 해당 주문에 걸린 체결 수
    /// </summary>
    /// <value>해당 주문에 걸린 체결 수</value>
    [DataMember(Name="trades_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trades_count")]
    public decimal? TradesCount { get; set; }

    /// <summary>
    /// 체결
    /// </summary>
    /// <value>체결</value>
    [DataMember(Name="trades", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trades")]
    public List<Trade> Trades { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderInfo {\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  OrdType: ").Append(OrdType).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  RemainingVolume: ").Append(RemainingVolume).Append("\n");
      sb.Append("  ReservedFee: ").Append(ReservedFee).Append("\n");
      sb.Append("  RemainingFee: ").Append(RemainingFee).Append("\n");
      sb.Append("  PaidFee: ").Append(PaidFee).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  ExecutedVolume: ").Append(ExecutedVolume).Append("\n");
      sb.Append("  TradesCount: ").Append(TradesCount).Append("\n");
      sb.Append("  Trades: ").Append(Trades).Append("\n");
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
