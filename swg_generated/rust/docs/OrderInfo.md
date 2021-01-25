# OrderInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uuid** | **String** | 주문의 고유 아이디 | [optional] [default to null]
**side** | **String** | 주문 종류 | [optional] [default to null]
**ord_type** | **String** | 주문 방식 | [optional] [default to null]
**price** | **String** | 주문 당시 화폐 가격 | [optional] [default to null]
**state** | **String** | 주문 상태 | [optional] [default to null]
**market** | **String** | 마켓의 유일키 | [optional] [default to null]
**created_at** | **String** | 주문 생성 시간 | [optional] [default to null]
**volume** | **String** | 사용자가 입력한 주문 양 | [optional] [default to null]
**remaining_volume** | **String** | 체결 후 남은 주문 양 | [optional] [default to null]
**reserved_fee** | **String** | 수수료로 예약된 비용 | [optional] [default to null]
**remaining_fee** | **String** | 남은 수수료 | [optional] [default to null]
**paid_fee** | **String** | 사용된 수수료 | [optional] [default to null]
**locked** | **String** | 거래에 사용중인 비용 | [optional] [default to null]
**executed_volume** | **String** | 체결된 양 | [optional] [default to null]
**trades_count** | **f32** | 해당 주문에 걸린 체결 수 | [optional] [default to null]
**trades** | [**Vec<::models::Trade>**](Trade.md) | 체결 | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


