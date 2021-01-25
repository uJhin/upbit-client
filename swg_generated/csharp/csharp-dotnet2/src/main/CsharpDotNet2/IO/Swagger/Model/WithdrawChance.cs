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
  public class WithdrawChance {
    /// <summary>
    /// Gets or Sets MemberLevel
    /// </summary>
    [DataMember(Name="member_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_level")]
    public MemberLevel MemberLevel { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public Currency Currency { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public Account Account { get; set; }

    /// <summary>
    /// Gets or Sets WithdrawLimit
    /// </summary>
    [DataMember(Name="withdraw_limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "withdraw_limit")]
    public WithdrawLimit WithdrawLimit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WithdrawChance {\n");
      sb.Append("  MemberLevel: ").Append(MemberLevel).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  WithdrawLimit: ").Append(WithdrawLimit).Append("\n");
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
