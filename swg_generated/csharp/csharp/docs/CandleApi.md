# IO.Swagger.Api.CandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CandleDays**](CandleApi.md#candledays) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
[**CandleMinutes**](CandleApi.md#candleminutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**CandleMonth**](CandleApi.md#candlemonth) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
[**CandleWeeks**](CandleApi.md#candleweeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)


<a name="candledays"></a>
# **CandleDays**
> Object CandleDays (string market, string to = null, decimal? count = null, string convertingPriceUnit = null)

시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CandleDaysExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CandleApi();
            var market = market_example;  // string | 마켓 코드 (ex. KRW-BTC) 
            var to = to_example;  // string | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional) 
            var count = 8.14;  // decimal? | 캔들 개수  (optional) 
            var convertingPriceUnit = convertingPriceUnit_example;  // string | 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  (optional)  (default to KRW)

            try
            {
                // 시세 캔들 조회 (일 단위)
                Object result = apiInstance.CandleDays(market, to, count, convertingPriceUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CandleApi.CandleDays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **string**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **decimal?**| 캔들 개수  | [optional] 
 **convertingPriceUnit** | **string**| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [optional] [default to KRW]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="candleminutes"></a>
# **CandleMinutes**
> Object CandleMinutes (int? unit, string market, string to = null, decimal? count = null)

시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CandleMinutesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CandleApi();
            var unit = 56;  // int? | 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
            var market = market_example;  // string | 마켓 코드 (ex. KRW-BTC) 
            var to = to_example;  // string | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional) 
            var count = 8.14;  // decimal? | 캔들 개수 (최대 200개까지 요청 가능)  (optional) 

            try
            {
                // 시세 캔들 조회 (분 단위)
                Object result = apiInstance.CandleMinutes(unit, market, to, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CandleApi.CandleMinutes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unit** | **int?**| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  | 
 **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **string**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **decimal?**| 캔들 개수 (최대 200개까지 요청 가능)  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="candlemonth"></a>
# **CandleMonth**
> Object CandleMonth (string market, string to = null, decimal? count = null)

시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CandleMonthExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CandleApi();
            var market = market_example;  // string | 마켓 코드 (ex. KRW-BTC) 
            var to = to_example;  // string | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional) 
            var count = 8.14;  // decimal? | 캔들 개수  (optional) 

            try
            {
                // 시세 캔들 조회 (월 단위)
                Object result = apiInstance.CandleMonth(market, to, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CandleApi.CandleMonth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **string**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **decimal?**| 캔들 개수  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="candleweeks"></a>
# **CandleWeeks**
> Object CandleWeeks (string market, string to = null, decimal? count = null)

시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CandleWeeksExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CandleApi();
            var market = market_example;  // string | 마켓 코드 (ex. KRW-BTC) 
            var to = to_example;  // string | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional) 
            var count = 8.14;  // decimal? | 캔들 개수  (optional) 

            try
            {
                // 시세 캔들 조회 (주 단위)
                Object result = apiInstance.CandleWeeks(market, to, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CandleApi.CandleWeeks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **string**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **decimal?**| 캔들 개수  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

