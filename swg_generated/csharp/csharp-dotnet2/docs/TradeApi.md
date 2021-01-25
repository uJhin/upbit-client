# IO.Swagger.Api.TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TradeTicker**](TradeApi.md#tradeticker) | **GET** /ticker | 시세 Ticker 조회
[**TradeTicks**](TradeApi.md#tradeticks) | **GET** /trades/ticks | 시세 체결 조회


<a name="tradeticker"></a>
# **TradeTicker**
> Object TradeTicker (string markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TradeTickerExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TradeApi();
            var markets = markets_example;  // string | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 

            try
            {
                // 시세 Ticker 조회
                Object result = apiInstance.TradeTicker(markets);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradeApi.TradeTicker: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **string**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tradeticks"></a>
# **TradeTicks**
> Object TradeTicks (string market, string to, decimal? count, string cursor, decimal? daysAgo)

시세 체결 조회

## 최근 체결 내역 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TradeTicksExample
    {
        public void main()
        {
            
            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TradeApi();
            var market = market_example;  // string | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
            var to = to_example;  // string | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터  (optional) 
            var count = 8.14;  // decimal? | 체결 개수  (optional) 
            var cursor = cursor_example;  // string | 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  (optional) 
            var daysAgo = 8.14;  // decimal? | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  (optional) 

            try
            {
                // 시세 체결 조회
                Object result = apiInstance.TradeTicks(market, to, count, cursor, daysAgo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradeApi.TradeTicks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **string**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional] 
 **count** | **decimal?**| 체결 개수  | [optional] 
 **cursor** | **string**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 
 **daysAgo** | **decimal?**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

