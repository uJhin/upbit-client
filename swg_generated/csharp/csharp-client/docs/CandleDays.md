# IO.Swagger.Model.CandleDays
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | 마켓명 | [optional] 
**CandleDateTimeUtc** | **string** | 캔들 기준 시각 (UTC 기준) | [optional] 
**CandleDateTimeKst** | **string** | 캔들 기준 시각 (KST 기준) | [optional] 
**OpeningPrice** | **double?** | 시가 | [optional] 
**HighPrice** | **double?** | 고가 | [optional] 
**LowPrice** | **double?** | 저가 | [optional] 
**TradePrice** | **double?** | 종가 | [optional] 
**Timestamp** | **decimal?** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**CandleAccTradePrice** | **double?** | 누적 거래 금액 | [optional] 
**CandleAccTradeVolume** | **double?** | 누적 거래량 | [optional] 
**PrevClosingPrice** | **double?** | 전일 종가 (UTC 0시 기준) | [optional] 
**ChangePrice** | **double?** | 전일 종가 대비 변화 금액 | [optional] 
**ChangeRate** | **double?** | 전일 종가 대비 변화량 | [optional] 
**ConvertedTradePrice** | **double?** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

