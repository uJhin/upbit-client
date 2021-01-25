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
  public class Wallet {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 입출금 상태 - working : 입출금 가능 - withdraw_only : 출금만 가능 - deposit_only : 입금만 가능 - paused : 입출금 중단 - unsupported : 입출금 미지원 
    /// </summary>
    /// <value>입출금 상태 - working : 입출금 가능 - withdraw_only : 출금만 가능 - deposit_only : 입금만 가능 - paused : 입출금 중단 - unsupported : 입출금 미지원 </value>
    [DataMember(Name="wallet_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_state")]
    public string WalletState { get; set; }

    /// <summary>
    /// 블록 상태 - normal : 정상 - delayed : 지연 - inactive : 비활성 (점검 등) 
    /// </summary>
    /// <value>블록 상태 - normal : 정상 - delayed : 지연 - inactive : 비활성 (점검 등) </value>
    [DataMember(Name="block_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_state")]
    public string BlockState { get; set; }

    /// <summary>
    /// 블록 높이
    /// </summary>
    /// <value>블록 높이</value>
    [DataMember(Name="block_height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_height")]
    public decimal? BlockHeight { get; set; }

    /// <summary>
    /// 블록 갱신 시각
    /// </summary>
    /// <value>블록 갱신 시각</value>
    [DataMember(Name="block_updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_updated_at")]
    public string BlockUpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Wallet {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  WalletState: ").Append(WalletState).Append("\n");
      sb.Append("  BlockState: ").Append(BlockState).Append("\n");
      sb.Append("  BlockHeight: ").Append(BlockHeight).Append("\n");
      sb.Append("  BlockUpdatedAt: ").Append(BlockUpdatedAt).Append("\n");
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
