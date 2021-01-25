# UpbitOpenApi.TradeTicks

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓 구분 코드 | [optional] 
**tradeDateUtc** | **String** | 체결 일자 (UTC 기준) | [optional] 
**tradeTimeUtc** | **String** | 체결 시각 (UTC 기준) | [optional] 
**timestamp** | **Number** | 체결 타임스탬프 | [optional] 
**tradePrice** | **Number** | 체결 가격 | [optional] 
**tradeVolume** | **Number** | 체결량 | [optional] 
**prevClosingPrice** | **Number** | 전일 종가 | [optional] 
**changePrice** | **Number** | 변화량 | [optional] 
**askBid** | **String** | 매도/매수 | [optional] 
**sequentialId** | **Number** | 체결 번호 (Unique) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 


