# TradeTicks

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **str** | 마켓 구분 코드 | [optional] 
**trade_date_utc** | **str** | 체결 일자 (UTC 기준) | [optional] 
**trade_time_utc** | **str** | 체결 시각 (UTC 기준) | [optional] 
**timestamp** | **float** | 체결 타임스탬프 | [optional] 
**trade_price** | **float** | 체결 가격 | [optional] 
**trade_volume** | **float** | 체결량 | [optional] 
**prev_closing_price** | **float** | 전일 종가 | [optional] 
**change_price** | **float** | 변화량 | [optional] 
**ask_bid** | **str** | 매도/매수 | [optional] 
**sequential_id** | **float** | 체결 번호 (Unique) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


