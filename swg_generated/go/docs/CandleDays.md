# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 마켓명 | [optional] [default to null]
**CandleDateTimeUtc** | **string** | 캔들 기준 시각 (UTC 기준) | [optional] [default to null]
**CandleDateTimeKst** | **string** | 캔들 기준 시각 (KST 기준) | [optional] [default to null]
**OpeningPrice** | **float64** | 시가 | [optional] [default to null]
**HighPrice** | **float64** | 고가 | [optional] [default to null]
**LowPrice** | **float64** | 저가 | [optional] [default to null]
**TradePrice** | **float64** | 종가 | [optional] [default to null]
**Timestamp** | **float32** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] [default to null]
**CandleAccTradePrice** | **float64** | 누적 거래 금액 | [optional] [default to null]
**CandleAccTradeVolume** | **float64** | 누적 거래량 | [optional] [default to null]
**PrevClosingPrice** | **float64** | 전일 종가 (UTC 0시 기준) | [optional] [default to null]
**ChangePrice** | **float64** | 전일 종가 대비 변화 금액 | [optional] [default to null]
**ChangeRate** | **float64** | 전일 종가 대비 변화량 | [optional] [default to null]
**ConvertedTradePrice** | **float64** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


