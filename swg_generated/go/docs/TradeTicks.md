# TradeTicks

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 마켓 구분 코드 | [optional] [default to null]
**TradeDateUtc** | **string** | 체결 일자 (UTC 기준) | [optional] [default to null]
**TradeTimeUtc** | **string** | 체결 시각 (UTC 기준) | [optional] [default to null]
**Timestamp** | **float32** | 체결 타임스탬프 | [optional] [default to null]
**TradePrice** | **float64** | 체결 가격 | [optional] [default to null]
**TradeVolume** | **float64** | 체결량 | [optional] [default to null]
**PrevClosingPrice** | **float64** | 전일 종가 | [optional] [default to null]
**ChangePrice** | **float64** | 변화량 | [optional] [default to null]
**AskBid** | **string** | 매도/매수 | [optional] [default to null]
**SequentialId** | **float32** | 체결 번호 (Unique) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


