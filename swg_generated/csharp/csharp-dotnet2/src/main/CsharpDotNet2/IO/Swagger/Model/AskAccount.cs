using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 매도 시 사용하는 화폐의 계좌 상태
  /// </summary>
  [DataContract]
  public class AskAccount {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 주문가능 금액/수량
    /// </summary>
    /// <value>주문가능 금액/수량</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// 주문 중 묶여있는 금액/수량
    /// </summary>
    /// <value>주문 중 묶여있는 금액/수량</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public string Locked { get; set; }

    /// <summary>
    /// 매수평균가
    /// </summary>
    /// <value>매수평균가</value>
    [DataMember(Name="avg_buy_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avg_buy_price")]
    public string AvgBuyPrice { get; set; }

    /// <summary>
    /// 매수평균가 수정 여부
    /// </summary>
    /// <value>매수평균가 수정 여부</value>
    [DataMember(Name="avg_buy_price_modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avg_buy_price_modified")]
    public bool? AvgBuyPriceModified { get; set; }

    /// <summary>
    /// 평단가 기준 화폐
    /// </summary>
    /// <value>평단가 기준 화폐</value>
    [DataMember(Name="unit_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_currency")]
    public string UnitCurrency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AskAccount {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  AvgBuyPrice: ").Append(AvgBuyPrice).Append("\n");
      sb.Append("  AvgBuyPriceModified: ").Append(AvgBuyPriceModified).Append("\n");
      sb.Append("  UnitCurrency: ").Append(UnitCurrency).Append("\n");
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
