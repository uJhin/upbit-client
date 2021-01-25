# SwaggerClient::CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓명 | [optional] 
**candle_date_time_utc** | **String** | 캔들 기준 시각 (UTC 기준) | [optional] 
**candle_date_time_kst** | **String** | 캔들 기준 시각 (KST 기준) | [optional] 
**opening_price** | **Float** | 시가 | [optional] 
**high_price** | **Float** | 고가 | [optional] 
**low_price** | **Float** | 저가 | [optional] 
**trade_price** | **Float** | 종가 | [optional] 
**timestamp** | **Float** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**candle_acc_trade_price** | **Float** | 누적 거래 금액 | [optional] 
**candle_acc_trade_volume** | **Float** | 누적 거래량 | [optional] 
**prev_closing_price** | **Float** | 전일 종가 (UTC 0시 기준) | [optional] 
**change_price** | **Float** | 전일 종가 대비 변화 금액 | [optional] 
**change_rate** | **Float** | 전일 종가 대비 변화량 | [optional] 
**converted_trade_price** | **Float** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] 


