using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 사용자의 보안등급 정보
  /// </summary>
  [DataContract]
  public class MemberLevel {
    /// <summary>
    /// 사용자의 보안 등급
    /// </summary>
    /// <value>사용자의 보안 등급</value>
    [DataMember(Name="security_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_level")]
    public decimal? SecurityLevel { get; set; }

    /// <summary>
    /// 사용자의 수수료 등급
    /// </summary>
    /// <value>사용자의 수수료 등급</value>
    [DataMember(Name="fee_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee_level")]
    public decimal? FeeLevel { get; set; }

    /// <summary>
    /// 사용자의 이메일 인증 여부
    /// </summary>
    /// <value>사용자의 이메일 인증 여부</value>
    [DataMember(Name="email_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_verified")]
    public bool? EmailVerified { get; set; }

    /// <summary>
    /// 사용자의 실명 인증 여부
    /// </summary>
    /// <value>사용자의 실명 인증 여부</value>
    [DataMember(Name="identity_auth_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identity_auth_verified")]
    public bool? IdentityAuthVerified { get; set; }

    /// <summary>
    /// 사용자의 계좌 인증 여부
    /// </summary>
    /// <value>사용자의 계좌 인증 여부</value>
    [DataMember(Name="bank_account_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bank_account_verified")]
    public bool? BankAccountVerified { get; set; }

    /// <summary>
    /// 사용자의 카카오페이 인증 여부
    /// </summary>
    /// <value>사용자의 카카오페이 인증 여부</value>
    [DataMember(Name="kakao_pay_auth_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kakao_pay_auth_verified")]
    public bool? KakaoPayAuthVerified { get; set; }

    /// <summary>
    /// 사용자의 계정 보호 상태
    /// </summary>
    /// <value>사용자의 계정 보호 상태</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// 사용자의 출금 보호 상태
    /// </summary>
    /// <value>사용자의 출금 보호 상태</value>
    [DataMember(Name="wallet_locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_locked")]
    public bool? WalletLocked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MemberLevel {\n");
      sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
      sb.Append("  FeeLevel: ").Append(FeeLevel).Append("\n");
      sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
      sb.Append("  IdentityAuthVerified: ").Append(IdentityAuthVerified).Append("\n");
      sb.Append("  BankAccountVerified: ").Append(BankAccountVerified).Append("\n");
      sb.Append("  KakaoPayAuthVerified: ").Append(KakaoPayAuthVerified).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  WalletLocked: ").Append(WalletLocked).Append("\n");
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
