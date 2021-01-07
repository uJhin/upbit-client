# \CandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CandleDays**](CandleApi.md#CandleDays) | **Get** /candles/days | 시세 캔들 조회 (일 단위)
[**CandleMinutes**](CandleApi.md#CandleMinutes) | **Get** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**CandleMonth**](CandleApi.md#CandleMonth) | **Get** /candles/months | 시세 캔들 조회 (월 단위)
[**CandleWeeks**](CandleApi.md#CandleWeeks) | **Get** /candles/weeks | 시세 캔들 조회 (주 단위)


# **CandleDays**
> interface{} CandleDays(ctx, market, optional)
시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **optional** | ***CandleApiCandleDaysOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a CandleApiCandleDaysOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **to** | **optional.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | 
 **count** | **optional.Float32**| 캔들 개수  | 
 **convertingPriceUnit** | **optional.String**| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [default to KRW]

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CandleMinutes**
> interface{} CandleMinutes(ctx, unit, market, optional)
시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **unit** | **int32**| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  | 
  **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **optional** | ***CandleApiCandleMinutesOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a CandleApiCandleMinutesOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **to** | **optional.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | 
 **count** | **optional.Float32**| 캔들 개수 (최대 200개까지 요청 가능)  | 

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CandleMonth**
> interface{} CandleMonth(ctx, market, optional)
시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **optional** | ***CandleApiCandleMonthOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a CandleApiCandleMonthOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **to** | **optional.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | 
 **count** | **optional.Float32**| 캔들 개수  | 

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CandleWeeks**
> interface{} CandleWeeks(ctx, market, optional)
시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **optional** | ***CandleApiCandleWeeksOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a CandleApiCandleWeeksOpts struct

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **to** | **optional.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | 
 **count** | **optional.Float32**| 캔들 개수  | 

### Return type

[**interface{}**](interface{}.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

