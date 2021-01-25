# Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **string** | 종목 구분 코드 | [optional] 
**trade_date** | **string** | 최근 거래 일자(UTC) | [optional] 
**trade_time** | **string** | 최근 거래 시각(UTC) | [optional] 
**trade_date_kst** | **string** | 최근 거래 일자(KST) | [optional] 
**trade_time_kst** | **string** | 최근 거래 시각(KST) | [optional] 
**opening_price** | **double** | 시가 | [optional] 
**high_price** | **double** | 고가 | [optional] 
**low_price** | **double** | 저가 | [optional] 
**trade_price** | **double** | 종가 | [optional] 
**prev_closing_price** | **double** | 전일 종가 | [optional] 
**change** | **string** | EVEN : 보합 RISE : 상승 FALL : 하락 | [optional] 
**change_price** | **double** | 변화액의 절대값 | [optional] 
**change_rate** | **double** | 변화율의 절대값 | [optional] 
**signed_change_price** | **double** | 부호가 있는 변화액 | [optional] 
**signed_change_rate** | **double** | 부호가 있는 변화율 | [optional] 
**trade_volume** | **double** | 가장 최근 거래량 | [optional] 
**acc_trade_price** | **double** | 누적 거래대금 (UTC 0시 기준) | [optional] 
**acc_trade_price_24h** | **double** | 24시간 누적 거래대금 | [optional] 
**acc_trade_volume** | **double** | 누적 거래량 (UTC 0시 기준) | [optional] 
**acc_trade_volume_24h** | **double** | 24시간 누적 거래량 | [optional] 
**highest_52_week_price** | **double** | 52주 신고가 | [optional] 
**highest_52_week_date** | **string** | 52주 신고가 달성일 | [optional] 
**lowest_52_week_price** | **double** | 52주 신저가 | [optional] 
**lowest_52_week_date** | **string** | 52주 신저가 달성일 | [optional] 
**timestamp** | **float** | 타임스탬프 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


