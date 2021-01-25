# SwaggerClient::Ticker

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**market** | **String** | 종목 구분 코드 | [optional] 
**trade_date** | **String** | 최근 거래 일자(UTC) | [optional] 
**trade_time** | **String** | 최근 거래 시각(UTC) | [optional] 
**trade_date_kst** | **String** | 최근 거래 일자(KST) | [optional] 
**trade_time_kst** | **String** | 최근 거래 시각(KST) | [optional] 
**opening_price** | **Float** | 시가 | [optional] 
**high_price** | **Float** | 고가 | [optional] 
**low_price** | **Float** | 저가 | [optional] 
**trade_price** | **Float** | 종가 | [optional] 
**prev_closing_price** | **Float** | 전일 종가 | [optional] 
**change** | **String** | EVEN : 보합 RISE : 상승 FALL : 하락  | [optional] 
**change_price** | **Float** | 변화액의 절대값 | [optional] 
**change_rate** | **Float** | 변화율의 절대값 | [optional] 
**signed_change_price** | **Float** | 부호가 있는 변화액 | [optional] 
**signed_change_rate** | **Float** | 부호가 있는 변화율 | [optional] 
**trade_volume** | **Float** | 가장 최근 거래량 | [optional] 
**acc_trade_price** | **Float** | 누적 거래대금 (UTC 0시 기준) | [optional] 
**acc_trade_price_24h** | **Float** | 24시간 누적 거래대금 | [optional] 
**acc_trade_volume** | **Float** | 누적 거래량 (UTC 0시 기준) | [optional] 
**acc_trade_volume_24h** | **Float** | 24시간 누적 거래량 | [optional] 
**highest_52_week_price** | **Float** | 52주 신고가 | [optional] 
**highest_52_week_date** | **String** | 52주 신고가 달성일 | [optional] 
**lowest_52_week_price** | **Float** | 52주 신저가 | [optional] 
**lowest_52_week_date** | **String** | 52주 신저가 달성일 | [optional] 
**timestamp** | **Float** | 타임스탬프 | [optional] 


