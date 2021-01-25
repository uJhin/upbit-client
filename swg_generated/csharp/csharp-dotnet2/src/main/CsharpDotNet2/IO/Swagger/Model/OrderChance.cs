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
  public class OrderChance {
    /// <summary>
    /// 매수 수수료 비율
    /// </summary>
    /// <value>매수 수수료 비율</value>
    [DataMember(Name="bid_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid_fee")]
    public string BidFee { get; set; }

    /// <summary>
    /// 매도 수수료 비율
    /// </summary>
    /// <value>매도 수수료 비율</value>
    [DataMember(Name="ask_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask_fee")]
    public string AskFee { get; set; }

    /// <summary>
    /// Gets or Sets Market
    /// </summary>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public Market Market { get; set; }

    /// <summary>
    /// Gets or Sets BidAccount
    /// </summary>
    [DataMember(Name="bid_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid_account")]
    public BidAccount BidAccount { get; set; }

    /// <summary>
    /// Gets or Sets AskAccount
    /// </summary>
    [DataMember(Name="ask_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask_account")]
    public AskAccount AskAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderChance {\n");
      sb.Append("  BidFee: ").Append(BidFee).Append("\n");
      sb.Append("  AskFee: ").Append(AskFee).Append("\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  BidAccount: ").Append(BidAccount).Append("\n");
      sb.Append("  AskAccount: ").Append(AskAccount).Append("\n");
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
