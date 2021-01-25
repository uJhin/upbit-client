# OrderInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uuid** | **str** | 주문의 고유 아이디 | [optional] 
**side** | **str** | 주문 종류 | [optional] 
**ord_type** | **str** | 주문 방식 | [optional] 
**price** | **str** | 주문 당시 화폐 가격 | [optional] 
**state** | **str** | 주문 상태 | [optional] 
**market** | **str** | 마켓의 유일키 | [optional] 
**created_at** | **str** | 주문 생성 시간 | [optional] 
**volume** | **str** | 사용자가 입력한 주문 양 | [optional] 
**remaining_volume** | **str** | 체결 후 남은 주문 양 | [optional] 
**reserved_fee** | **str** | 수수료로 예약된 비용 | [optional] 
**remaining_fee** | **str** | 남은 수수료 | [optional] 
**paid_fee** | **str** | 사용된 수수료 | [optional] 
**locked** | **str** | 거래에 사용중인 비용 | [optional] 
**executed_volume** | **str** | 체결된 양 | [optional] 
**trades_count** | **float** | 해당 주문에 걸린 체결 수 | [optional] 
**trades** | [**list[Trade]**](Trade.md) | 체결 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


