# Market

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | 마켓 ID | [optional] [default to null]
**name** | **String** | 마켓 이름 | [optional] [default to null]
**order_types** | **Vec<String>** | 지원 주문 방식 | [optional] [default to null]
**order_sides** | **Vec<String>** | 지원 주문 종류 | [optional] [default to null]
**bid** | [***::models::Bid**](Bid.md) |  | [optional] [default to null]
**ask** | [***::models::Ask**](Ask.md) |  | [optional] [default to null]
**max_total** | **String** | 최대 매도/매수 금액 | [optional] [default to null]
**state** | **String** | 마켓 운영 상태 | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


