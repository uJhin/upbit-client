
# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **kotlin.String** | 마켓명 |  [optional]
**candle_date_time_utc** | **kotlin.String** | 캔들 기준 시각 (UTC 기준) |  [optional]
**candle_date_time_kst** | **kotlin.String** | 캔들 기준 시각 (KST 기준) |  [optional]
**opening_price** | **kotlin.Double** | 시가 |  [optional]
**high_price** | **kotlin.Double** | 고가 |  [optional]
**low_price** | **kotlin.Double** | 저가 |  [optional]
**trade_price** | **kotlin.Double** | 종가 |  [optional]
**timestamp** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | 해당 캔들에서 마지막 틱이 저장된 시각 |  [optional]
**candle_acc_trade_price** | **kotlin.Double** | 누적 거래 금액 |  [optional]
**candle_acc_trade_volume** | **kotlin.Double** | 누적 거래량 |  [optional]
**prev_closing_price** | **kotlin.Double** | 전일 종가 (UTC 0시 기준) |  [optional]
**change_price** | **kotlin.Double** | 전일 종가 대비 변화 금액 |  [optional]
**change_rate** | **kotlin.Double** | 전일 종가 대비 변화량 |  [optional]
**converted_trade_price** | **kotlin.Double** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  |  [optional]



