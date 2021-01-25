using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 매수 시 제약사항
  /// </summary>
  [DataContract]
  public class Bid {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 주문금액 단위
    /// </summary>
    /// <value>주문금액 단위</value>
    [DataMember(Name="price_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_unit")]
    public string PriceUnit { get; set; }

    /// <summary>
    /// 최소 매도/매수 금액
    /// </summary>
    /// <value>최소 매도/매수 금액</value>
    [DataMember(Name="min_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_total")]
    public decimal? MinTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Bid {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  PriceUnit: ").Append(PriceUnit).Append("\n");
      sb.Append("  MinTotal: ").Append(MinTotal).Append("\n");
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
