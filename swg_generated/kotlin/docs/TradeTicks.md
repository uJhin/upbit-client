
# TradeTicks

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **kotlin.String** | 마켓 구분 코드 |  [optional]
**trade_date_utc** | **kotlin.String** | 체결 일자 (UTC 기준) |  [optional]
**trade_time_utc** | **kotlin.String** | 체결 시각 (UTC 기준) |  [optional]
**timestamp** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | 체결 타임스탬프 |  [optional]
**trade_price** | **kotlin.Double** | 체결 가격 |  [optional]
**trade_volume** | **kotlin.Double** | 체결량 |  [optional]
**prev_closing_price** | **kotlin.Double** | 전일 종가 |  [optional]
**change_price** | **kotlin.Double** | 변화량 |  [optional]
**ask_bid** | **kotlin.String** | 매도/매수 |  [optional]
**sequential_id** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | 체결 번호 (Unique)  &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  |  [optional]



