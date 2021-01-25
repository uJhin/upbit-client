# SWGOrderInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uuid** | **NSString*** | 주문의 고유 아이디 | [optional] 
**side** | **NSString*** | 주문 종류 | [optional] 
**ordType** | **NSString*** | 주문 방식 | [optional] 
**price** | **NSString*** | 주문 당시 화폐 가격 | [optional] 
**state** | **NSString*** | 주문 상태 | [optional] 
**market** | **NSString*** | 마켓의 유일키 | [optional] 
**createdAt** | **NSString*** | 주문 생성 시간 | [optional] 
**volume** | **NSString*** | 사용자가 입력한 주문 양 | [optional] 
**remainingVolume** | **NSString*** | 체결 후 남은 주문 양 | [optional] 
**reservedFee** | **NSString*** | 수수료로 예약된 비용 | [optional] 
**remainingFee** | **NSString*** | 남은 수수료 | [optional] 
**paidFee** | **NSString*** | 사용된 수수료 | [optional] 
**locked** | **NSString*** | 거래에 사용중인 비용 | [optional] 
**executedVolume** | **NSString*** | 체결된 양 | [optional] 
**tradesCount** | **NSNumber*** | 해당 주문에 걸린 체결 수 | [optional] 
**trades** | [**NSArray&lt;SWGTrade&gt;***](SWGTrade.md) | 체결 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


