# \DepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deposit_coin_address**](DepositApi.md#deposit_coin_address) | **Get** /deposits/coin_address | 개별 입금 주소 조회
[**deposit_coin_addresses**](DepositApi.md#deposit_coin_addresses) | **Get** /deposits/coin_addresses | 전체 입금 주소 조회
[**deposit_generate_coin_address**](DepositApi.md#deposit_generate_coin_address) | **Post** /deposits/generate_coin_address | 입금 주소 생성 요청
[**deposit_info**](DepositApi.md#deposit_info) | **Get** /deposit | 개별 입금 조회
[**deposit_info_all**](DepositApi.md#deposit_info_all) | **Get** /deposits | 입금 리스트 조회


# **deposit_coin_address**
> ::models::DepositCompleteResponse deposit_coin_address(ctx, currency)
개별 입금 주소 조회

## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **currency** | **String**| Currency symbol  | 

### Return type

[**::models::DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_coin_addresses**
> Value deposit_coin_addresses(ctx, )
전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Required Parameters
This endpoint does not need any parameter.

### Return type

[**Value**](Value.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_generate_coin_address**
> ::models::DepositCompleteResponse deposit_generate_coin_address(ctx, currency)
입금 주소 생성 요청

입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **currency** | **String**| Currency 코드  | 

### Return type

[**::models::DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_info**
> ::models::Deposit deposit_info(ctx, optional)
개별 입금 조회

## 개별 입금 조회 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 입금 UUID  | 
 **txid** | **String**| 입금 TXID  | 
 **currency** | **String**| Currency 코드  | 

### Return type

[**::models::Deposit**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_info_all**
> Vec<::models::Deposit> deposit_info_all(ctx, optional)
입금 리스트 조회

## 입금 리스트 조회 

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
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | 
 **uuids** | [**Vec&lt;String&gt;**](String.md)| 입금 UUID의 목록  | 
 **txids** | [**Vec&lt;String&gt;**](String.md)| 입금 TXID의 목록  | 
 **limit** | **f32**| 개수 제한 (default: 100, max: 100)  | 
 **page** | **f32**| 페이지 수, default: 1  | 
 **order_by** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | 

### Return type

[**Vec<::models::Deposit>**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

