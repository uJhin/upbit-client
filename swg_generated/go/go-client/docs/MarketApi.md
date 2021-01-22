# \MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarketInfoAll**](MarketApi.md#MarketInfoAll) | **Get** /market/all | 마켓 코드 조회


# **MarketInfoAll**
> interface{} MarketInfoAll(ctx, optional)
마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MarketApiMarketInfoAllOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a MarketApiMarketInfoAllOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **optional.Bool**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [default to false]

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

