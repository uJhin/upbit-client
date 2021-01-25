# \MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**market_info_all**](MarketApi.md#market_info_all) | **Get** /market/all | 마켓 코드 조회


# **market_info_all**
> Value market_info_all(ctx, optional)
마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_details** | **bool**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [default to false]

### Return type

[**Value**](Value.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

