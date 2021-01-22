# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **str** | 마켓명 | [optional] 
**candle_date_time_utc** | **str** | 캔들 기준 시각 (UTC 기준) | [optional] 
**candle_date_time_kst** | **str** | 캔들 기준 시각 (KST 기준) | [optional] 
**opening_price** | **float** | 시가 | [optional] 
**high_price** | **float** | 고가 | [optional] 
**low_price** | **float** | 저가 | [optional] 
**trade_price** | **float** | 종가 | [optional] 
**timestamp** | **float** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**candle_acc_trade_price** | **float** | 누적 거래 금액 | [optional] 
**candle_acc_trade_volume** | **float** | 누적 거래량 | [optional] 
**prev_closing_price** | **float** | 전일 종가 (UTC 0시 기준) | [optional] 
**change_price** | **float** | 전일 종가 대비 변화 금액 | [optional] 
**change_rate** | **float** | 전일 종가 대비 변화량 | [optional] 
**converted_trade_price** | **float** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


