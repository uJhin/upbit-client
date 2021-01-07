# IO.Swagger.Model.Ticker
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 종목 구분 코드 | [optional] 
**TradeDate** | **string** | 최근 거래 일자(UTC) | [optional] 
**TradeTime** | **string** | 최근 거래 시각(UTC) | [optional] 
**TradeDateKst** | **string** | 최근 거래 일자(KST) | [optional] 
**TradeTimeKst** | **string** | 최근 거래 시각(KST) | [optional] 
**OpeningPrice** | **double?** | 시가 | [optional] 
**HighPrice** | **double?** | 고가 | [optional] 
**LowPrice** | **double?** | 저가 | [optional] 
**TradePrice** | **double?** | 종가 | [optional] 
**PrevClosingPrice** | **double?** | 전일 종가 | [optional] 
**Change** | **string** | EVEN : 보합 RISE : 상승 FALL : 하락  | [optional] 
**ChangePrice** | **double?** | 변화액의 절대값 | [optional] 
**ChangeRate** | **double?** | 변화율의 절대값 | [optional] 
**SignedChangePrice** | **double?** | 부호가 있는 변화액 | [optional] 
**SignedChangeRate** | **double?** | 부호가 있는 변화율 | [optional] 
**TradeVolume** | **double?** | 가장 최근 거래량 | [optional] 
**AccTradePrice** | **double?** | 누적 거래대금 (UTC 0시 기준) | [optional] 
**AccTradePrice24h** | **double?** | 24시간 누적 거래대금 | [optional] 
**AccTradeVolume** | **double?** | 누적 거래량 (UTC 0시 기준) | [optional] 
**AccTradeVolume24h** | **double?** | 24시간 누적 거래량 | [optional] 
**Highest52WeekPrice** | **double?** | 52주 신고가 | [optional] 
**Highest52WeekDate** | **string** | 52주 신고가 달성일 | [optional] 
**Lowest52WeekPrice** | **double?** | 52주 신저가 | [optional] 
**Lowest52WeekDate** | **string** | 52주 신저가 달성일 | [optional] 
**Timestamp** | **decimal?** | 타임스탬프 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

