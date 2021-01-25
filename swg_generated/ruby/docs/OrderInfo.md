# SwaggerClient::OrderInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uuid** | **String** | 주문의 고유 아이디 | [optional] 
**side** | **String** | 주문 종류 | [optional] 
**ord_type** | **String** | 주문 방식 | [optional] 
**price** | **String** | 주문 당시 화폐 가격 | [optional] 
**state** | **String** | 주문 상태 | [optional] 
**market** | **String** | 마켓의 유일키 | [optional] 
**created_at** | **String** | 주문 생성 시간 | [optional] 
**volume** | **String** | 사용자가 입력한 주문 양 | [optional] 
**remaining_volume** | **String** | 체결 후 남은 주문 양 | [optional] 
**reserved_fee** | **String** | 수수료로 예약된 비용 | [optional] 
**remaining_fee** | **String** | 남은 수수료 | [optional] 
**paid_fee** | **String** | 사용된 수수료 | [optional] 
**locked** | **String** | 거래에 사용중인 비용 | [optional] 
**executed_volume** | **String** | 체결된 양 | [optional] 
**trades_count** | **Float** | 해당 주문에 걸린 체결 수 | [optional] 
**trades** | [**Array&lt;Trade&gt;**](Trade.md) | 체결 | [optional] 


