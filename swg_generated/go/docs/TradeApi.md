# \TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TradeTicker**](TradeApi.md#TradeTicker) | **Get** /ticker | 시세 Ticker 조회
[**TradeTicks**](TradeApi.md#TradeTicks) | **Get** /trades/ticks | 시세 체결 조회


# **TradeTicker**
> interface{} TradeTicker(ctx, markets)
시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **markets** | **string**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TradeTicks**
> interface{} TradeTicks(ctx, market, optional)
시세 체결 조회

## 최근 체결 내역 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **market** | **string**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **optional** | ***TradeApiTradeTicksOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a TradeApiTradeTicksOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **to** | **optional.String**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | 
 **count** | **optional.Float32**| 체결 개수  | 
 **cursor** | **optional.String**| 페이지네이션 커서 (sequentialId)  &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | 
 **daysAgo** | **optional.Float32**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | 

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

