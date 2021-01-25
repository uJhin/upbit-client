using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 출금 제약 정보
  /// </summary>
  [DataContract]
  public class WithdrawLimit {
    /// <summary>
    /// 화폐를 의미하는 영문 대문자 코드
    /// </summary>
    /// <value>화폐를 의미하는 영문 대문자 코드</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 출금 최소 금액/수량
    /// </summary>
    /// <value>출금 최소 금액/수량</value>
    [DataMember(Name="minimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum")]
    public string Minimum { get; set; }

    /// <summary>
    /// 1회 출금 한도
    /// </summary>
    /// <value>1회 출금 한도</value>
    [DataMember(Name="onetime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onetime")]
    public string Onetime { get; set; }

    /// <summary>
    /// 1일 출금 한도
    /// </summary>
    /// <value>1일 출금 한도</value>
    [DataMember(Name="daily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "daily")]
    public string Daily { get; set; }

    /// <summary>
    /// 1일 잔여 출금 한도
    /// </summary>
    /// <value>1일 잔여 출금 한도</value>
    [DataMember(Name="remaining_daily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_daily")]
    public string RemainingDaily { get; set; }

    /// <summary>
    /// 통합 1일 잔여 출금 한도
    /// </summary>
    /// <value>통합 1일 잔여 출금 한도</value>
    [DataMember(Name="remaining_daily_krw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_daily_krw")]
    public string RemainingDailyKrw { get; set; }

    /// <summary>
    /// 출금 금액/수량 소수점 자리 수
    /// </summary>
    /// <value>출금 금액/수량 소수점 자리 수</value>
    [DataMember(Name="fixed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed")]
    public decimal? Fixed { get; set; }

    /// <summary>
    /// 출금 지원 여부
    /// </summary>
    /// <value>출금 지원 여부</value>
    [DataMember(Name="can_withdraw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_withdraw")]
    public bool? CanWithdraw { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WithdrawLimit {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Minimum: ").Append(Minimum).Append("\n");
      sb.Append("  Onetime: ").Append(Onetime).Append("\n");
      sb.Append("  Daily: ").Append(Daily).Append("\n");
      sb.Append("  RemainingDaily: ").Append(RemainingDaily).Append("\n");
      sb.Append("  RemainingDailyKrw: ").Append(RemainingDailyKrw).Append("\n");
      sb.Append("  Fixed: ").Append(Fixed).Append("\n");
      sb.Append("  CanWithdraw: ").Append(CanWithdraw).Append("\n");
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
