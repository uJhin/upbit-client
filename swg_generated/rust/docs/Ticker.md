# Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 종목 구분 코드 | [optional] [default to null]
**trade_date** | **String** | 최근 거래 일자(UTC) | [optional] [default to null]
**trade_time** | **String** | 최근 거래 시각(UTC) | [optional] [default to null]
**trade_date_kst** | **String** | 최근 거래 일자(KST) | [optional] [default to null]
**trade_time_kst** | **String** | 최근 거래 시각(KST) | [optional] [default to null]
**opening_price** | **f64** | 시가 | [optional] [default to null]
**high_price** | **f64** | 고가 | [optional] [default to null]
**low_price** | **f64** | 저가 | [optional] [default to null]
**trade_price** | **f64** | 종가 | [optional] [default to null]
**prev_closing_price** | **f64** | 전일 종가 | [optional] [default to null]
**change** | **String** | EVEN : 보합 RISE : 상승 FALL : 하락  | [optional] [default to null]
**change_price** | **f64** | 변화액의 절대값 | [optional] [default to null]
**change_rate** | **f64** | 변화율의 절대값 | [optional] [default to null]
**signed_change_price** | **f64** | 부호가 있는 변화액 | [optional] [default to null]
**signed_change_rate** | **f64** | 부호가 있는 변화율 | [optional] [default to null]
**trade_volume** | **f64** | 가장 최근 거래량 | [optional] [default to null]
**acc_trade_price** | **f64** | 누적 거래대금 (UTC 0시 기준) | [optional] [default to null]
**acc_trade_price_24h** | **f64** | 24시간 누적 거래대금 | [optional] [default to null]
**acc_trade_volume** | **f64** | 누적 거래량 (UTC 0시 기준) | [optional] [default to null]
**acc_trade_volume_24h** | **f64** | 24시간 누적 거래량 | [optional] [default to null]
**highest_52_week_price** | **f64** | 52주 신고가 | [optional] [default to null]
**highest_52_week_date** | **String** | 52주 신고가 달성일 | [optional] [default to null]
**lowest_52_week_price** | **f64** | 52주 신저가 | [optional] [default to null]
**lowest_52_week_date** | **String** | 52주 신저가 달성일 | [optional] [default to null]
**timestamp** | **f32** | 타임스탬프 | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


