# \WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdraw_chance**](WithdrawApi.md#withdraw_chance) | **Get** /withdraws/chance | 출금 가능 정보
[**withdraw_coin**](WithdrawApi.md#withdraw_coin) | **Post** /withdraws/coin | 코인 출금하기
[**withdraw_info**](WithdrawApi.md#withdraw_info) | **Get** /withdraw | 개별 출금 조회
[**withdraw_info_all**](WithdrawApi.md#withdraw_info_all) | **Get** /withdraws | 출금 리스트 조회
[**withdraw_krw**](WithdrawApi.md#withdraw_krw) | **Post** /withdraws/krw | 원화 출금하기


# **withdraw_chance**
> ::models::WithdrawChance withdraw_chance(ctx, currency)
출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **currency** | **String**| Currency Symbol  | 

### Return type

[**::models::WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_coin**
> ::models::WithdrawCoin withdraw_coin(ctx, currency, amount, address, optional)
코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **currency** | **String**| Currency 코드  | 
  **amount** | **String**| 출금 수량  | 
  **address** | **String**| 출금 가능 주소에 등록된 출금 주소  | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | 
 **amount** | **String**| 출금 수량  | 
 **address** | **String**| 출금 가능 주소에 등록된 출금 주소  | 
 **secondary_address** | **String**| 2차 출금 주소 (필요한 코인에 한해서)  | 
 **transaction_type** | **String**| 출금 유형 - default : 일반출금 - internal : 바로출금  | 

### Return type

[**::models::WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_info**
> ::models::Withdraw withdraw_info(ctx, optional)
개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 출금 UUID  | 
 **txid** | **String**| 출금 TXID  | 
 **currency** | **String**| Currency 코드  | 

### Return type

[**::models::Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_info_all**
> Vec<::models::Withdraw> withdraw_info_all(ctx, optional)
출금 리스트 조회

## 출금 리스트를 조회한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | 
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | 
 **uuids** | [**Vec&lt;String&gt;**](String.md)| 출금 UUID의 목록  | 
 **txids** | [**Vec&lt;String&gt;**](String.md)| 출금 TXID의 목록  | 
 **limit** | **f32**| 개수 제한 (default: 100, max: 100)  | 
 **page** | **f32**| 페이지 수, default: 1  | 
 **order_by** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | 

### Return type

[**Vec<::models::Withdraw>**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_krw**
> ::models::Withdraw withdraw_krw(ctx, amount)
원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **amount** | **String**| 출금 원화 수량  | 

### Return type

[**::models::Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

