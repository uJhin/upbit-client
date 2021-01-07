# UpbitOpenApi.CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓명 | [optional] 
**candleDateTimeUtc** | **String** | 캔들 기준 시각 (UTC 기준) | [optional] 
**candleDateTimeKst** | **String** | 캔들 기준 시각 (KST 기준) | [optional] 
**openingPrice** | **Number** | 시가 | [optional] 
**highPrice** | **Number** | 고가 | [optional] 
**lowPrice** | **Number** | 저가 | [optional] 
**tradePrice** | **Number** | 종가 | [optional] 
**timestamp** | **Number** | 해당 캔들에서 마지막 틱이 저장된 시각 | [optional] 
**candleAccTradePrice** | **Number** | 누적 거래 금액 | [optional] 
**candleAccTradeVolume** | **Number** | 누적 거래량 | [optional] 
**prevClosingPrice** | **Number** | 전일 종가 (UTC 0시 기준) | [optional] 
**changePrice** | **Number** | 전일 종가 대비 변화 금액 | [optional] 
**changeRate** | **Number** | 전일 종가 대비 변화량 | [optional] 
**convertedTradePrice** | **Number** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  | [optional] 


