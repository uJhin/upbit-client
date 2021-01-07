# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **string** | 마켓명 | [optional] 
**candle_date_time_utc** | **string** | 캔들 기준 시각 (UTC 기준) | [optional] 
**candle_date_time_kst** | **string** | 캔들 기준 시각 (KST 기준) | [optional] 
**opening_price** | **double** | 시가 | [optional] 
**high_price** | **double** | 고가 | [optional] 
**low_price** | **double** | 저가 | [optional] 
**trade_price** | **double** | 종가 | [optional] 
**timestamp** | **float** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**candle_acc_trade_price** | **double** | 누적 거래 금액 | [optional] 
**candle_acc_trade_volume** | **double** | 누적 거래량 | [optional] 
**prev_closing_price** | **double** | 전일 종가 (UTC 0시 기준) | [optional] 
**change_price** | **double** | 전일 종가 대비 변화 금액 | [optional] 
**change_rate** | **double** | 전일 종가 대비 변화량 | [optional] 
**converted_trade_price** | **double** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


