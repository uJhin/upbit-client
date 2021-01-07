
# Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **kotlin.String** | 종목 구분 코드 |  [optional]
**trade_date** | **kotlin.String** | 최근 거래 일자(UTC) |  [optional]
**trade_time** | **kotlin.String** | 최근 거래 시각(UTC) |  [optional]
**trade_date_kst** | **kotlin.String** | 최근 거래 일자(KST) |  [optional]
**trade_time_kst** | **kotlin.String** | 최근 거래 시각(KST) |  [optional]
**opening_price** | **kotlin.Double** | 시가 |  [optional]
**high_price** | **kotlin.Double** | 고가 |  [optional]
**low_price** | **kotlin.Double** | 저가 |  [optional]
**trade_price** | **kotlin.Double** | 종가 |  [optional]
**prev_closing_price** | **kotlin.Double** | 전일 종가 |  [optional]
**change** | **kotlin.String** | EVEN : 보합 RISE : 상승 FALL : 하락  |  [optional]
**change_price** | **kotlin.Double** | 변화액의 절대값 |  [optional]
**change_rate** | **kotlin.Double** | 변화율의 절대값 |  [optional]
**signed_change_price** | **kotlin.Double** | 부호가 있는 변화액 |  [optional]
**signed_change_rate** | **kotlin.Double** | 부호가 있는 변화율 |  [optional]
**trade_volume** | **kotlin.Double** | 가장 최근 거래량 |  [optional]
**acc_trade_price** | **kotlin.Double** | 누적 거래대금 (UTC 0시 기준) |  [optional]
**acc_trade_price_24h** | **kotlin.Double** | 24시간 누적 거래대금 |  [optional]
**acc_trade_volume** | **kotlin.Double** | 누적 거래량 (UTC 0시 기준) |  [optional]
**acc_trade_volume_24h** | **kotlin.Double** | 24시간 누적 거래량 |  [optional]
**highest_52_week_price** | **kotlin.Double** | 52주 신고가 |  [optional]
**highest_52_week_date** | **kotlin.String** | 52주 신고가 달성일 |  [optional]
**lowest_52_week_price** | **kotlin.Double** | 52주 신저가 |  [optional]
**lowest_52_week_date** | **kotlin.String** | 52주 신저가 달성일 |  [optional]
**timestamp** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | 타임스탬프 |  [optional]



