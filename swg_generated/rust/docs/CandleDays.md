# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓명 | [optional] [default to null]
**candle_date_time_utc** | **String** | 캔들 기준 시각 (UTC 기준) | [optional] [default to null]
**candle_date_time_kst** | **String** | 캔들 기준 시각 (KST 기준) | [optional] [default to null]
**opening_price** | **f64** | 시가 | [optional] [default to null]
**high_price** | **f64** | 고가 | [optional] [default to null]
**low_price** | **f64** | 저가 | [optional] [default to null]
**trade_price** | **f64** | 종가 | [optional] [default to null]
**timestamp** | **f32** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] [default to null]
**candle_acc_trade_price** | **f64** | 누적 거래 금액 | [optional] [default to null]
**candle_acc_trade_volume** | **f64** | 누적 거래량 | [optional] [default to null]
**prev_closing_price** | **f64** | 전일 종가 (UTC 0시 기준) | [optional] [default to null]
**change_price** | **f64** | 전일 종가 대비 변화 금액 | [optional] [default to null]
**change_rate** | **f64** | 전일 종가 대비 변화량 | [optional] [default to null]
**converted_trade_price** | **f64** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


