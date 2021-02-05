# SwaggerClient::TradeTicks

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓 구분 코드 | [optional] 
**trade_date_utc** | **String** | 체결 일자 (UTC 기준) | [optional] 
**trade_time_utc** | **String** | 체결 시각 (UTC 기준) | [optional] 
**timestamp** | **Float** | 체결 타임스탬프 | [optional] 
**trade_price** | **Float** | 체결 가격 | [optional] 
**trade_volume** | **Float** | 체결량 | [optional] 
**prev_closing_price** | **Float** | 전일 종가 | [optional] 
**change_price** | **Float** | 변화량 | [optional] 
**ask_bid** | **String** | 매도/매수 | [optional] 
**sequential_id** | **Float** | 체결 번호 (Unique)  &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 


