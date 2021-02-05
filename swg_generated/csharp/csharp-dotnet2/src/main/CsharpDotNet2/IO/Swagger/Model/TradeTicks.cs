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
  public class TradeTicks {
    /// <summary>
    /// 마켓 구분 코드
    /// </summary>
    /// <value>마켓 구분 코드</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 체결 일자 (UTC 기준)
    /// </summary>
    /// <value>체결 일자 (UTC 기준)</value>
    [DataMember(Name="trade_date_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_date_utc")]
    public string TradeDateUtc { get; set; }

    /// <summary>
    /// 체결 시각 (UTC 기준)
    /// </summary>
    /// <value>체결 시각 (UTC 기준)</value>
    [DataMember(Name="trade_time_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_time_utc")]
    public string TradeTimeUtc { get; set; }

    /// <summary>
    /// 체결 타임스탬프
    /// </summary>
    /// <value>체결 타임스탬프</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public decimal? Timestamp { get; set; }

    /// <summary>
    /// 체결 가격
    /// </summary>
    /// <value>체결 가격</value>
    [DataMember(Name="trade_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_price")]
    public double? TradePrice { get; set; }

    /// <summary>
    /// 체결량
    /// </summary>
    /// <value>체결량</value>
    [DataMember(Name="trade_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_volume")]
    public double? TradeVolume { get; set; }

    /// <summary>
    /// 전일 종가
    /// </summary>
    /// <value>전일 종가</value>
    [DataMember(Name="prev_closing_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prev_closing_price")]
    public double? PrevClosingPrice { get; set; }

    /// <summary>
    /// 변화량
    /// </summary>
    /// <value>변화량</value>
    [DataMember(Name="change_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change_price")]
    public double? ChangePrice { get; set; }

    /// <summary>
    /// 매도/매수
    /// </summary>
    /// <value>매도/매수</value>
    [DataMember(Name="ask_bid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask_bid")]
    public string AskBid { get; set; }

    /// <summary>
    /// 체결 번호 (Unique)  `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. 
    /// </summary>
    /// <value>체결 번호 (Unique)  `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. </value>
    [DataMember(Name="sequential_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequential_id")]
    public decimal? SequentialId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeTicks {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  TradeDateUtc: ").Append(TradeDateUtc).Append("\n");
      sb.Append("  TradeTimeUtc: ").Append(TradeTimeUtc).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  TradePrice: ").Append(TradePrice).Append("\n");
      sb.Append("  TradeVolume: ").Append(TradeVolume).Append("\n");
      sb.Append("  PrevClosingPrice: ").Append(PrevClosingPrice).Append("\n");
      sb.Append("  ChangePrice: ").Append(ChangePrice).Append("\n");
      sb.Append("  AskBid: ").Append(AskBid).Append("\n");
      sb.Append("  SequentialId: ").Append(SequentialId).Append("\n");
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
