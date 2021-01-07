# OrderInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | 주문의 고유 아이디 | [optional] [default to null]
**Side** | **string** | 주문 종류 | [optional] [default to null]
**OrdType** | **string** | 주문 방식 | [optional] [default to null]
**Price** | **string** | 주문 당시 화폐 가격 | [optional] [default to null]
**State** | **string** | 주문 상태 | [optional] [default to null]
**Market** | **string** | 마켓의 유일키 | [optional] [default to null]
**CreatedAt** | **string** | 주문 생성 시간 | [optional] [default to null]
**Volume** | **string** | 사용자가 입력한 주문 양 | [optional] [default to null]
**RemainingVolume** | **string** | 체결 후 남은 주문 양 | [optional] [default to null]
**ReservedFee** | **string** | 수수료로 예약된 비용 | [optional] [default to null]
**RemainingFee** | **string** | 남은 수수료 | [optional] [default to null]
**PaidFee** | **string** | 사용된 수수료 | [optional] [default to null]
**Locked** | **string** | 거래에 사용중인 비용 | [optional] [default to null]
**ExecutedVolume** | **string** | 체결된 양 | [optional] [default to null]
**TradesCount** | **float32** | 해당 주문에 걸린 체결 수 | [optional] [default to null]
**Trades** | [**[]Trade**](Trade.md) | 체결 | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


