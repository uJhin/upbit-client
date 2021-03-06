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

import java.math.BigDecimal;
import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;

/**
 * 출금 제약 정보
 **/
@ApiModel(description = "출금 제약 정보")
public class WithdrawLimit {
  
  @SerializedName("currency")
  private String currency = null;
  @SerializedName("minimum")
  private String minimum = null;
  @SerializedName("onetime")
  private String onetime = null;
  @SerializedName("daily")
  private String daily = null;
  @SerializedName("remaining_daily")
  private String remainingDaily = null;
  @SerializedName("remaining_daily_krw")
  private String remainingDailyKrw = null;
  @SerializedName("fixed")
  private BigDecimal fixed = null;
  @SerializedName("can_withdraw")
  private Boolean canWithdraw = null;

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
   * 출금 최소 금액/수량
   **/
  @ApiModelProperty(value = "출금 최소 금액/수량")
  public String getMinimum() {
    return minimum;
  }
  public void setMinimum(String minimum) {
    this.minimum = minimum;
  }

  /**
   * 1회 출금 한도
   **/
  @ApiModelProperty(value = "1회 출금 한도")
  public String getOnetime() {
    return onetime;
  }
  public void setOnetime(String onetime) {
    this.onetime = onetime;
  }

  /**
   * 1일 출금 한도
   **/
  @ApiModelProperty(value = "1일 출금 한도")
  public String getDaily() {
    return daily;
  }
  public void setDaily(String daily) {
    this.daily = daily;
  }

  /**
   * 1일 잔여 출금 한도
   **/
  @ApiModelProperty(value = "1일 잔여 출금 한도")
  public String getRemainingDaily() {
    return remainingDaily;
  }
  public void setRemainingDaily(String remainingDaily) {
    this.remainingDaily = remainingDaily;
  }

  /**
   * 통합 1일 잔여 출금 한도
   **/
  @ApiModelProperty(value = "통합 1일 잔여 출금 한도")
  public String getRemainingDailyKrw() {
    return remainingDailyKrw;
  }
  public void setRemainingDailyKrw(String remainingDailyKrw) {
    this.remainingDailyKrw = remainingDailyKrw;
  }

  /**
   * 출금 금액/수량 소수점 자리 수
   **/
  @ApiModelProperty(value = "출금 금액/수량 소수점 자리 수")
  public BigDecimal getFixed() {
    return fixed;
  }
  public void setFixed(BigDecimal fixed) {
    this.fixed = fixed;
  }

  /**
   * 출금 지원 여부
   **/
  @ApiModelProperty(value = "출금 지원 여부")
  public Boolean getCanWithdraw() {
    return canWithdraw;
  }
  public void setCanWithdraw(Boolean canWithdraw) {
    this.canWithdraw = canWithdraw;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    WithdrawLimit withdrawLimit = (WithdrawLimit) o;
    return (this.currency == null ? withdrawLimit.currency == null : this.currency.equals(withdrawLimit.currency)) &&
        (this.minimum == null ? withdrawLimit.minimum == null : this.minimum.equals(withdrawLimit.minimum)) &&
        (this.onetime == null ? withdrawLimit.onetime == null : this.onetime.equals(withdrawLimit.onetime)) &&
        (this.daily == null ? withdrawLimit.daily == null : this.daily.equals(withdrawLimit.daily)) &&
        (this.remainingDaily == null ? withdrawLimit.remainingDaily == null : this.remainingDaily.equals(withdrawLimit.remainingDaily)) &&
        (this.remainingDailyKrw == null ? withdrawLimit.remainingDailyKrw == null : this.remainingDailyKrw.equals(withdrawLimit.remainingDailyKrw)) &&
        (this.fixed == null ? withdrawLimit.fixed == null : this.fixed.equals(withdrawLimit.fixed)) &&
        (this.canWithdraw == null ? withdrawLimit.canWithdraw == null : this.canWithdraw.equals(withdrawLimit.canWithdraw));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (this.currency == null ? 0: this.currency.hashCode());
    result = 31 * result + (this.minimum == null ? 0: this.minimum.hashCode());
    result = 31 * result + (this.onetime == null ? 0: this.onetime.hashCode());
    result = 31 * result + (this.daily == null ? 0: this.daily.hashCode());
    result = 31 * result + (this.remainingDaily == null ? 0: this.remainingDaily.hashCode());
    result = 31 * result + (this.remainingDailyKrw == null ? 0: this.remainingDailyKrw.hashCode());
    result = 31 * result + (this.fixed == null ? 0: this.fixed.hashCode());
    result = 31 * result + (this.canWithdraw == null ? 0: this.canWithdraw.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class WithdrawLimit {\n");
    
    sb.append("  currency: ").append(currency).append("\n");
    sb.append("  minimum: ").append(minimum).append("\n");
    sb.append("  onetime: ").append(onetime).append("\n");
    sb.append("  daily: ").append(daily).append("\n");
    sb.append("  remainingDaily: ").append(remainingDaily).append("\n");
    sb.append("  remainingDailyKrw: ").append(remainingDailyKrw).append("\n");
    sb.append("  fixed: ").append(fixed).append("\n");
    sb.append("  canWithdraw: ").append(canWithdraw).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
