# \TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**trade_ticker**](TradeApi.md#trade_ticker) | **Get** /ticker | 시세 Ticker 조회
[**trade_ticks**](TradeApi.md#trade_ticks) | **Get** /trades/ticks | 시세 체결 조회


# **trade_ticker**
> Value trade_ticker(ctx, markets)
시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **markets** | **String**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

[**Value**](Value.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **trade_ticks**
> Value trade_ticks(ctx, market, optional)
시세 체결 조회

## 최근 체결 내역 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **market** | **String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **String**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | 
 **count** | **f32**| 체결 개수  | 
 **cursor** | **String**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | 
 **days_ago** | **f32**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | 

### Return type

[**Value**](Value.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

