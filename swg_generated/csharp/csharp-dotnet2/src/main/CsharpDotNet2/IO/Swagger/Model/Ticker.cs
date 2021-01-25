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
  public class Ticker {
    /// <summary>
    /// 종목 구분 코드
    /// </summary>
    /// <value>종목 구분 코드</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 최근 거래 일자(UTC)
    /// </summary>
    /// <value>최근 거래 일자(UTC)</value>
    [DataMember(Name="trade_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_date")]
    public string TradeDate { get; set; }

    /// <summary>
    /// 최근 거래 시각(UTC)
    /// </summary>
    /// <value>최근 거래 시각(UTC)</value>
    [DataMember(Name="trade_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_time")]
    public string TradeTime { get; set; }

    /// <summary>
    /// 최근 거래 일자(KST)
    /// </summary>
    /// <value>최근 거래 일자(KST)</value>
    [DataMember(Name="trade_date_kst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_date_kst")]
    public string TradeDateKst { get; set; }

    /// <summary>
    /// 최근 거래 시각(KST)
    /// </summary>
    /// <value>최근 거래 시각(KST)</value>
    [DataMember(Name="trade_time_kst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_time_kst")]
    public string TradeTimeKst { get; set; }

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
    /// 전일 종가
    /// </summary>
    /// <value>전일 종가</value>
    [DataMember(Name="prev_closing_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prev_closing_price")]
    public double? PrevClosingPrice { get; set; }

    /// <summary>
    /// EVEN : 보합 RISE : 상승 FALL : 하락 
    /// </summary>
    /// <value>EVEN : 보합 RISE : 상승 FALL : 하락 </value>
    [DataMember(Name="change", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change")]
    public string Change { get; set; }

    /// <summary>
    /// 변화액의 절대값
    /// </summary>
    /// <value>변화액의 절대값</value>
    [DataMember(Name="change_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change_price")]
    public double? ChangePrice { get; set; }

    /// <summary>
    /// 변화율의 절대값
    /// </summary>
    /// <value>변화율의 절대값</value>
    [DataMember(Name="change_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change_rate")]
    public double? ChangeRate { get; set; }

    /// <summary>
    /// 부호가 있는 변화액
    /// </summary>
    /// <value>부호가 있는 변화액</value>
    [DataMember(Name="signed_change_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signed_change_price")]
    public double? SignedChangePrice { get; set; }

    /// <summary>
    /// 부호가 있는 변화율
    /// </summary>
    /// <value>부호가 있는 변화율</value>
    [DataMember(Name="signed_change_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signed_change_rate")]
    public double? SignedChangeRate { get; set; }

    /// <summary>
    /// 가장 최근 거래량
    /// </summary>
    /// <value>가장 최근 거래량</value>
    [DataMember(Name="trade_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trade_volume")]
    public double? TradeVolume { get; set; }

    /// <summary>
    /// 누적 거래대금 (UTC 0시 기준)
    /// </summary>
    /// <value>누적 거래대금 (UTC 0시 기준)</value>
    [DataMember(Name="acc_trade_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acc_trade_price")]
    public double? AccTradePrice { get; set; }

    /// <summary>
    /// 24시간 누적 거래대금
    /// </summary>
    /// <value>24시간 누적 거래대금</value>
    [DataMember(Name="acc_trade_price_24h", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acc_trade_price_24h")]
    public double? AccTradePrice24h { get; set; }

    /// <summary>
    /// 누적 거래량 (UTC 0시 기준)
    /// </summary>
    /// <value>누적 거래량 (UTC 0시 기준)</value>
    [DataMember(Name="acc_trade_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acc_trade_volume")]
    public double? AccTradeVolume { get; set; }

    /// <summary>
    /// 24시간 누적 거래량
    /// </summary>
    /// <value>24시간 누적 거래량</value>
    [DataMember(Name="acc_trade_volume_24h", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acc_trade_volume_24h")]
    public double? AccTradeVolume24h { get; set; }

    /// <summary>
    /// 52주 신고가
    /// </summary>
    /// <value>52주 신고가</value>
    [DataMember(Name="highest_52_week_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highest_52_week_price")]
    public double? Highest52WeekPrice { get; set; }

    /// <summary>
    /// 52주 신고가 달성일
    /// </summary>
    /// <value>52주 신고가 달성일</value>
    [DataMember(Name="highest_52_week_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highest_52_week_date")]
    public string Highest52WeekDate { get; set; }

    /// <summary>
    /// 52주 신저가
    /// </summary>
    /// <value>52주 신저가</value>
    [DataMember(Name="lowest_52_week_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowest_52_week_price")]
    public double? Lowest52WeekPrice { get; set; }

    /// <summary>
    /// 52주 신저가 달성일
    /// </summary>
    /// <value>52주 신저가 달성일</value>
    [DataMember(Name="lowest_52_week_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowest_52_week_date")]
    public string Lowest52WeekDate { get; set; }

    /// <summary>
    /// 타임스탬프
    /// </summary>
    /// <value>타임스탬프</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public decimal? Timestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Ticker {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
      sb.Append("  TradeTime: ").Append(TradeTime).Append("\n");
      sb.Append("  TradeDateKst: ").Append(TradeDateKst).Append("\n");
      sb.Append("  TradeTimeKst: ").Append(TradeTimeKst).Append("\n");
      sb.Append("  OpeningPrice: ").Append(OpeningPrice).Append("\n");
      sb.Append("  HighPrice: ").Append(HighPrice).Append("\n");
      sb.Append("  LowPrice: ").Append(LowPrice).Append("\n");
      sb.Append("  TradePrice: ").Append(TradePrice).Append("\n");
      sb.Append("  PrevClosingPrice: ").Append(PrevClosingPrice).Append("\n");
      sb.Append("  Change: ").Append(Change).Append("\n");
      sb.Append("  ChangePrice: ").Append(ChangePrice).Append("\n");
      sb.Append("  ChangeRate: ").Append(ChangeRate).Append("\n");
      sb.Append("  SignedChangePrice: ").Append(SignedChangePrice).Append("\n");
      sb.Append("  SignedChangeRate: ").Append(SignedChangeRate).Append("\n");
      sb.Append("  TradeVolume: ").Append(TradeVolume).Append("\n");
      sb.Append("  AccTradePrice: ").Append(AccTradePrice).Append("\n");
      sb.Append("  AccTradePrice24h: ").Append(AccTradePrice24h).Append("\n");
      sb.Append("  AccTradeVolume: ").Append(AccTradeVolume).Append("\n");
      sb.Append("  AccTradeVolume24h: ").Append(AccTradeVolume24h).Append("\n");
      sb.Append("  Highest52WeekPrice: ").Append(Highest52WeekPrice).Append("\n");
      sb.Append("  Highest52WeekDate: ").Append(Highest52WeekDate).Append("\n");
      sb.Append("  Lowest52WeekPrice: ").Append(Lowest52WeekPrice).Append("\n");
      sb.Append("  Lowest52WeekDate: ").Append(Lowest52WeekDate).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
