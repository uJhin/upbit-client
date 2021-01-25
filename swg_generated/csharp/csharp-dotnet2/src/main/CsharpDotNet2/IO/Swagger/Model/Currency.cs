using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 화폐 정보
  /// </summary>
  [DataContract]
  public class Currency {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// 해당 화폐의 출금 수수료
    /// </summary>
    /// <value>해당 화폐의 출금 수수료</value>
    [DataMember(Name="withdraw_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "withdraw_fee")]
    public string WithdrawFee { get; set; }

    /// <summary>
    /// 화폐의 코인 여부
    /// </summary>
    /// <value>화폐의 코인 여부</value>
    [DataMember(Name="is_coin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_coin")]
    public bool? IsCoin { get; set; }

    /// <summary>
    /// 해당 화폐의 지갑 상태
    /// </summary>
    /// <value>해당 화폐의 지갑 상태</value>
    [DataMember(Name="wallet_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_state")]
    public string WalletState { get; set; }

    /// <summary>
    /// 해당 화폐가 지원하는 입출금 정보
    /// </summary>
    /// <value>해당 화폐가 지원하는 입출금 정보</value>
    [DataMember(Name="wallet_support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_support")]
    public List<string> WalletSupport { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Currency {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  WithdrawFee: ").Append(WithdrawFee).Append("\n");
      sb.Append("  IsCoin: ").Append(IsCoin).Append("\n");
      sb.Append("  WalletState: ").Append(WalletState).Append("\n");
      sb.Append("  WalletSupport: ").Append(WalletSupport).Append("\n");
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
