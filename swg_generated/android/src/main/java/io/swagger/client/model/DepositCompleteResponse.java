/**
 * Upbit Open API
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: ujhin942@gmail.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;

@ApiModel(description = "")
public class DepositCompleteResponse {
  
  @SerializedName("currency")
  private String currency = null;
  @SerializedName("deposit_address")
  private String depositAddress = null;
  @SerializedName("secondary_address")
  private String secondaryAddress = null;

  /**
   * 화폐를 의미하는 영문 대문자 코드
   **/
  @ApiModelProperty(value = "화폐를 의미하는 영문 대문자 코드")
  public String getCurrency() {
    return currency;
  }
  public void setCurrency(String currency) {
    this.currency = currency;
  }

  /**
   * 입금 주소
   **/
  @ApiModelProperty(value = "입금 주소")
  public String getDepositAddress() {
    return depositAddress;
  }
  public void setDepositAddress(String depositAddress) {
    this.depositAddress = depositAddress;
  }

  /**
   * 2차 입금 주소
   **/
  @ApiModelProperty(value = "2차 입금 주소")
  public String getSecondaryAddress() {
    return secondaryAddress;
  }
  public void setSecondaryAddress(String secondaryAddress) {
    this.secondaryAddress = secondaryAddress;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DepositCompleteResponse depositCompleteResponse = (DepositCompleteResponse) o;
    return (this.currency == null ? depositCompleteResponse.currency == null : this.currency.equals(depositCompleteResponse.currency)) &&
        (this.depositAddress == null ? depositCompleteResponse.depositAddress == null : this.depositAddress.equals(depositCompleteResponse.depositAddress)) &&
        (this.secondaryAddress == null ? depositCompleteResponse.secondaryAddress == null : this.secondaryAddress.equals(depositCompleteResponse.secondaryAddress));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (this.currency == null ? 0: this.currency.hashCode());
    result = 31 * result + (this.depositAddress == null ? 0: this.depositAddress.hashCode());
    result = 31 * result + (this.secondaryAddress == null ? 0: this.secondaryAddress.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class DepositCompleteResponse {\n");
    
    sb.append("  currency: ").append(currency).append("\n");
    sb.append("  depositAddress: ").append(depositAddress).append("\n");
    sb.append("  secondaryAddress: ").append(secondaryAddress).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
