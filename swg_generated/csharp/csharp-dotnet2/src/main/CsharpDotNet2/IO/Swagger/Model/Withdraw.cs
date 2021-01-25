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
  public class Withdraw {
    /// <summary>
    /// 입출금 종류
    /// </summary>
    /// <value>입출금 종류</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// 출금의 고유 아이디
    /// </summary>
    /// <value>출금의 고유 아이디</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 출금의 트랜잭션 아이디
    /// </summary>
    /// <value>출금의 트랜잭션 아이디</value>
    [DataMember(Name="txid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txid")]
    public string Txid { get; set; }

    /// <summary>
    /// 출금 상태
    /// </summary>
    /// <value>출금 상태</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// 출금 생성 시간
    /// </summary>
    /// <value>출금 생성 시간</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// 출금 완료 시간
    /// </summary>
    /// <value>출금 완료 시간</value>
    [DataMember(Name="done_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "done_at")]
    public string DoneAt { get; set; }

    /// <summary>
    /// 출금 금액/수량
    /// </summary>
    /// <value>출금 금액/수량</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// 출금 수수료
    /// </summary>
    /// <value>출금 수수료</value>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public string Fee { get; set; }

    /// <summary>
    /// 출금 유형 - default : 일반출금 - internal : 바로출금  String 
    /// </summary>
    /// <value>출금 유형 - default : 일반출금 - internal : 바로출금  String </value>
    [DataMember(Name="transaction_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_type")]
    public string TransactionType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Withdraw {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Txid: ").Append(Txid).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  DoneAt: ").Append(DoneAt).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
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
