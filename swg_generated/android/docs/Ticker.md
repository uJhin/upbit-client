
# Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 종목 구분 코드 |  [optional]
**tradeDate** | **String** | 최근 거래 일자(UTC) |  [optional]
**tradeTime** | **String** | 최근 거래 시각(UTC) |  [optional]
**tradeDateKst** | **String** | 최근 거래 일자(KST) |  [optional]
**tradeTimeKst** | **String** | 최근 거래 시각(KST) |  [optional]
**openingPrice** | **Double** | 시가 |  [optional]
**highPrice** | **Double** | 고가 |  [optional]
**lowPrice** | **Double** | 저가 |  [optional]
**tradePrice** | **Double** | 종가 |  [optional]
**prevClosingPrice** | **Double** | 전일 종가 |  [optional]
**change** | **String** | EVEN : 보합 RISE : 상승 FALL : 하락  |  [optional]
**changePrice** | **Double** | 변화액의 절대값 |  [optional]
**changeRate** | **Double** | 변화율의 절대값 |  [optional]
**signedChangePrice** | **Double** | 부호가 있는 변화액 |  [optional]
**signedChangeRate** | **Double** | 부호가 있는 변화율 |  [optional]
**tradeVolume** | **Double** | 가장 최근 거래량 |  [optional]
**accTradePrice** | **Double** | 누적 거래대금 (UTC 0시 기준) |  [optional]
**accTradePrice24h** | **Double** | 24시간 누적 거래대금 |  [optional]
**accTradeVolume** | **Double** | 누적 거래량 (UTC 0시 기준) |  [optional]
**accTradeVolume24h** | **Double** | 24시간 누적 거래량 |  [optional]
**highest52WeekPrice** | **Double** | 52주 신고가 |  [optional]
**highest52WeekDate** | **String** | 52주 신고가 달성일 |  [optional]
**lowest52WeekPrice** | **Double** | 52주 신저가 |  [optional]
**lowest52WeekDate** | **String** | 52주 신저가 달성일 |  [optional]
**timestamp** | [**BigDecimal**](BigDecimal.md) | 타임스탬프 |  [optional]



