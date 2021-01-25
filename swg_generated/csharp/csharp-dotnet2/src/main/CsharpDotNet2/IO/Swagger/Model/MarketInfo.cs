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
  public class MarketInfo {
    /// <summary>
    /// 업비트에서 제공중인 시장 정보
    /// </summary>
    /// <value>업비트에서 제공중인 시장 정보</value>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public string Market { get; set; }

    /// <summary>
    /// 거래 대상 암호화폐 한글명
    /// </summary>
    /// <value>거래 대상 암호화폐 한글명</value>
    [DataMember(Name="korean_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "korean_name")]
    public string KoreanName { get; set; }

    /// <summary>
    /// 거래 대상 암호화폐 영문명
    /// </summary>
    /// <value>거래 대상 암호화폐 영문명</value>
    [DataMember(Name="english_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "english_name")]
    public string EnglishName { get; set; }

    /// <summary>
    /// 유의 종목 여부 - NONE (해당 사항 없음) - CAUTION (투자유의) 
    /// </summary>
    /// <value>유의 종목 여부 - NONE (해당 사항 없음) - CAUTION (투자유의) </value>
    [DataMember(Name="market_warning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market_warning")]
    public string MarketWarning { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketInfo {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  KoreanName: ").Append(KoreanName).Append("\n");
      sb.Append("  EnglishName: ").Append(EnglishName).Append("\n");
      sb.Append("  MarketWarning: ").Append(MarketWarning).Append("\n");
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
