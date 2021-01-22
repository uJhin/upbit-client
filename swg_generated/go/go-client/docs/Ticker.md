# Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 종목 구분 코드 | [optional] [default to null]
**TradeDate** | **string** | 최근 거래 일자(UTC) | [optional] [default to null]
**TradeTime** | **string** | 최근 거래 시각(UTC) | [optional] [default to null]
**TradeDateKst** | **string** | 최근 거래 일자(KST) | [optional] [default to null]
**TradeTimeKst** | **string** | 최근 거래 시각(KST) | [optional] [default to null]
**OpeningPrice** | **float64** | 시가 | [optional] [default to null]
**HighPrice** | **float64** | 고가 | [optional] [default to null]
**LowPrice** | **float64** | 저가 | [optional] [default to null]
**TradePrice** | **float64** | 종가 | [optional] [default to null]
**PrevClosingPrice** | **float64** | 전일 종가 | [optional] [default to null]
**Change** | **string** | EVEN : 보합 RISE : 상승 FALL : 하락  | [optional] [default to null]
**ChangePrice** | **float64** | 변화액의 절대값 | [optional] [default to null]
**ChangeRate** | **float64** | 변화율의 절대값 | [optional] [default to null]
**SignedChangePrice** | **float64** | 부호가 있는 변화액 | [optional] [default to null]
**SignedChangeRate** | **float64** | 부호가 있는 변화율 | [optional] [default to null]
**TradeVolume** | **float64** | 가장 최근 거래량 | [optional] [default to null]
**AccTradePrice** | **float64** | 누적 거래대금 (UTC 0시 기준) | [optional] [default to null]
**AccTradePrice24h** | **float64** | 24시간 누적 거래대금 | [optional] [default to null]
**AccTradeVolume** | **float64** | 누적 거래량 (UTC 0시 기준) | [optional] [default to null]
**AccTradeVolume24h** | **float64** | 24시간 누적 거래량 | [optional] [default to null]
**Highest52WeekPrice** | **float64** | 52주 신고가 | [optional] [default to null]
**Highest52WeekDate** | **string** | 52주 신고가 달성일 | [optional] [default to null]
**Lowest52WeekPrice** | **float64** | 52주 신저가 | [optional] [default to null]
**Lowest52WeekDate** | **string** | 52주 신저가 달성일 | [optional] [default to null]
**Timestamp** | **float32** | 타임스탬프 | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


