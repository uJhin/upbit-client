# IO.Swagger.Model.TradeTicks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 마켓 구분 코드 | [optional] 
**TradeDateUtc** | **string** | 체결 일자 (UTC 기준) | [optional] 
**TradeTimeUtc** | **string** | 체결 시각 (UTC 기준) | [optional] 
**Timestamp** | **decimal?** | 체결 타임스탬프 | [optional] 
**TradePrice** | **double?** | 체결 가격 | [optional] 
**TradeVolume** | **double?** | 체결량 | [optional] 
**PrevClosingPrice** | **double?** | 전일 종가 | [optional] 
**ChangePrice** | **double?** | 변화량 | [optional] 
**AskBid** | **string** | 매도/매수 | [optional] 
**SequentialId** | **decimal?** | 체결 번호 (Unique) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

