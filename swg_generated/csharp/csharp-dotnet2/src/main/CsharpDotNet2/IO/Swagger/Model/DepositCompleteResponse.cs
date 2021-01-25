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
  public class DepositCompleteResponse {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 입금 주소
    /// </summary>
    /// <value>입금 주소</value>
    [DataMember(Name="deposit_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deposit_address")]
    public string DepositAddress { get; set; }

    /// <summary>
    /// 2차 입금 주소
    /// </summary>
    /// <value>2차 입금 주소</value>
    [DataMember(Name="secondary_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondary_address")]
    public string SecondaryAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DepositCompleteResponse {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  DepositAddress: ").Append(DepositAddress).Append("\n");
      sb.Append("  SecondaryAddress: ").Append(SecondaryAddress).Append("\n");
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
