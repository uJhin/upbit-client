# \WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WithdrawChance**](WithdrawApi.md#WithdrawChance) | **Get** /withdraws/chance | 출금 가능 정보
[**WithdrawCoin**](WithdrawApi.md#WithdrawCoin) | **Post** /withdraws/coin | 코인 출금하기
[**WithdrawInfo**](WithdrawApi.md#WithdrawInfo) | **Get** /withdraw | 개별 출금 조회
[**WithdrawInfoAll**](WithdrawApi.md#WithdrawInfoAll) | **Get** /withdraws | 출금 리스트 조회
[**WithdrawKrw**](WithdrawApi.md#WithdrawKrw) | **Post** /withdraws/krw | 원화 출금하기


# **WithdrawChance**
> WithdrawChance WithdrawChance(ctx, currency)
출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **currency** | **string**| Currency Symbol  | 

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **WithdrawCoin**
> WithdrawCoin WithdrawCoin(ctx, currency, amount, address, optional)
코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **currency** | **string**| Currency 코드  | 
  **amount** | **string**| 출금 수량  | 
  **address** | **string**| 출금 가능 주소에 등록된 출금 주소  | 
 **optional** | ***WithdrawApiWithdrawCoinOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a WithdrawApiWithdrawCoinOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **secondaryAddress** | **optional.String**| 2차 출금 주소 (필요한 코인에 한해서)  | 
 **transactionType** | **optional.String**| 출금 유형 - default : 일반출금 - internal : 바로출금  | 

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **WithdrawInfo**
> Withdraw WithdrawInfo(ctx, optional)
개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***WithdrawApiWithdrawInfoOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a WithdrawApiWithdrawInfoOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **optional.String**| 출금 UUID  | 
 **txid** | **optional.String**| 출금 TXID  | 
 **currency** | **optional.String**| Currency 코드  | 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **WithdrawInfoAll**
> []Withdraw WithdrawInfoAll(ctx, optional)
출금 리스트 조회

## 출금 리스트를 조회한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***WithdrawApiWithdrawInfoAllOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a WithdrawApiWithdrawInfoAllOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **optional.String**| Currency 코드  | 
 **state** | **optional.String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | 
 **uuids** | [**optional.Interface of []string**](string.md)| 출금 UUID의 목록  | 
 **txids** | [**optional.Interface of []string**](string.md)| 출금 TXID의 목록  | 
 **limit** | **optional.Float32**| 개수 제한 (default: 100, max: 100)  | 
 **page** | **optional.Float32**| 페이지 수, default: 1  | 
 **orderBy** | **optional.String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | 

### Return type

[**[]Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **WithdrawKrw**
> Withdraw WithdrawKrw(ctx, amount)
원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **amount** | **string**| 출금 원화 수량  | 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

