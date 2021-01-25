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
  public class CandleMinutes {
    /// <summary>
    /// 마켓명
    /// </summary>
    /// <value>마켓명</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 캔들 기준 시각 (UTC 기준)
    /// </summary>
    /// <value>캔들 기준 시각 (UTC 기준)</value>
    [DataMember(Name="candle_date_time_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "candle_date_time_utc")]
    public string CandleDateTimeUtc { get; set; }

    /// <summary>
    /// 캔들 기준 시각 (KST 기준)
    /// </summary>
    /// <value>캔들 기준 시각 (KST 기준)</value>
    [DataMember(Name="candle_date_time_kst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "candle_date_time_kst")]
    public string CandleDateTimeKst { get; set; }

    /// <summary>
    /// 시가
    /// </summary>
    /// <value>시가</value>
    [DataMember(Name="opening_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opening_price")]
    public double? OpeningPrice { get; set; }

    /// <summary>
    /// 고가
    /// </summary>
    /// <value>고가</value>
    [DataMember(Name="high_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "high_price")]
    public double? HighPrice { get; set; }

    /// <summary>
    /// 저가
    /// </summary>
    /// <value>저가</value>
    [DataMember(Name="low_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "low_price")]
    public double? LowPrice { get; set; }

    /// <summary>
    /// 종가
    /// </summary>
    /// <value>종가</value>
    [DataMember(Name="trade_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_price")]
    public double? TradePrice { get; set; }

    /// <summary>
    /// 해당 캔들에서 마지막 틱이 저장된 시각
    /// </summary>
    /// <value>해당 캔들에서 마지막 틱이 저장된 시각</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public decimal? Timestamp { get; set; }

    /// <summary>
    /// 누적 거래 금액
    /// </summary>
    /// <value>누적 거래 금액</value>
    [DataMember(Name="candle_acc_trade_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "candle_acc_trade_price")]
    public double? CandleAccTradePrice { get; set; }

    /// <summary>
    /// 누적 거래량
    /// </summary>
    /// <value>누적 거래량</value>
    [DataMember(Name="candle_acc_trade_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "candle_acc_trade_volume")]
    public double? CandleAccTradeVolume { get; set; }

    /// <summary>
    /// 분 단위(유닛)
    /// </summary>
    /// <value>분 단위(유닛)</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public decimal? Unit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CandleMinutes {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  CandleDateTimeUtc: ").Append(CandleDateTimeUtc).Append("\n");
      sb.Append("  CandleDateTimeKst: ").Append(CandleDateTimeKst).Append("\n");
      sb.Append("  OpeningPrice: ").Append(OpeningPrice).Append("\n");
      sb.Append("  HighPrice: ").Append(HighPrice).Append("\n");
      sb.Append("  LowPrice: ").Append(LowPrice).Append("\n");
      sb.Append("  TradePrice: ").Append(TradePrice).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  CandleAccTradePrice: ").Append(CandleAccTradePrice).Append("\n");
      sb.Append("  CandleAccTradeVolume: ").Append(CandleAccTradeVolume).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
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
