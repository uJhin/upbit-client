# SWGCandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **NSString*** | 마켓명 | [optional] 
**candleDateTimeUtc** | **NSString*** | 캔들 기준 시각 (UTC 기준) | [optional] 
**candleDateTimeKst** | **NSString*** | 캔들 기준 시각 (KST 기준) | [optional] 
**openingPrice** | **NSNumber*** | 시가 | [optional] 
**highPrice** | **NSNumber*** | 고가 | [optional] 
**lowPrice** | **NSNumber*** | 저가 | [optional] 
**tradePrice** | **NSNumber*** | 종가 | [optional] 
**timestamp** | **NSNumber*** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**candleAccTradePrice** | **NSNumber*** | 누적 거래 금액 | [optional] 
**candleAccTradeVolume** | **NSNumber*** | 누적 거래량 | [optional] 
**prevClosingPrice** | **NSNumber*** | 전일 종가 (UTC 0시 기준) | [optional] 
**changePrice** | **NSNumber*** | 전일 종가 대비 변화 금액 | [optional] 
**changeRate** | **NSNumber*** | 전일 종가 대비 변화량 | [optional] 
**convertedTradePrice** | **NSNumber*** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


