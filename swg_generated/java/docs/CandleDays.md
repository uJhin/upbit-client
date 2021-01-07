
# CandleDays

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 마켓명 |  [optional]
**candleDateTimeUtc** | **String** | 캔들 기준 시각 (UTC 기준) |  [optional]
**candleDateTimeKst** | **String** | 캔들 기준 시각 (KST 기준) |  [optional]
**openingPrice** | **Double** | 시가 |  [optional]
**highPrice** | **Double** | 고가 |  [optional]
**lowPrice** | **Double** | 저가 |  [optional]
**tradePrice** | **Double** | 종가 |  [optional]
**timestamp** | [**BigDecimal**](BigDecimal.md) | 해당 캔들에서 마지막 틱이 저장된 시각 |  [optional]
**candleAccTradePrice** | **Double** | 누적 거래 금액 |  [optional]
**candleAccTradeVolume** | **Double** | 누적 거래량 |  [optional]
**prevClosingPrice** | **Double** | 전일 종가 (UTC 0시 기준) |  [optional]
**changePrice** | **Double** | 전일 종가 대비 변화 금액 |  [optional]
**changeRate** | **Double** | 전일 종가 대비 변화량 |  [optional]
**convertedTradePrice** | **Double** | 종가 환산 화폐 단위로 환산된 가격 (요청에 convertingPriceUnit 파라미터 없을 시 해당 필드 포함되지 않음.)  |  [optional]



