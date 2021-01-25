# CandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**candleDays**](CandleApi.md#candleDays) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
[**candleMinutes**](CandleApi.md#candleMinutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**candleMonth**](CandleApi.md#candleMonth) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
[**candleWeeks**](CandleApi.md#candleWeeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)


<a name="candleDays"></a>
# **candleDays**
> Object candleDays(market, to, count, convertingPriceUnit)

시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

### Example
```java
// Import classes:
//import io.swagger.client.api.CandleApi;

CandleApi apiInstance = new CandleApi();
String market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC) 
String to = "to_example"; // String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
BigDecimal count = new BigDecimal(); // BigDecimal | 캔들 개수 
String convertingPriceUnit = "KRW"; // String | 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.) `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다. 
try {
    Object result = apiInstance.candleDays(market, to, count, convertingPriceUnit);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CandleApi#candleDays");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **BigDecimal**| 캔들 개수  | [optional]
 **convertingPriceUnit** | **String**| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.) &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [optional] [default to KRW]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candleMinutes"></a>
# **candleMinutes**
> Object candleMinutes(unit, market, to, count)

시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

### Example
```java
// Import classes:
//import io.swagger.client.api.CandleApi;

CandleApi apiInstance = new CandleApi();
Integer unit = 56; // Integer | 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
String market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC) 
String to = "to_example"; // String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
BigDecimal count = new BigDecimal(); // BigDecimal | 캔들 개수 (최대 200개까지 요청 가능) 
try {
    Object result = apiInstance.candleMinutes(unit, market, to, count);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CandleApi#candleMinutes");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unit** | **Integer**| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  |
 **market** | **String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **BigDecimal**| 캔들 개수 (최대 200개까지 요청 가능)  | [optional]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candleMonth"></a>
# **candleMonth**
> Object candleMonth(market, to, count)

시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

### Example
```java
// Import classes:
//import io.swagger.client.api.CandleApi;

CandleApi apiInstance = new CandleApi();
String market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC) 
String to = "to_example"; // String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
BigDecimal count = new BigDecimal(); // BigDecimal | 캔들 개수 
try {
    Object result = apiInstance.candleMonth(market, to, count);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CandleApi#candleMonth");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **BigDecimal**| 캔들 개수  | [optional]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candleWeeks"></a>
# **candleWeeks**
> Object candleWeeks(market, to, count)

시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

### Example
```java
// Import classes:
//import io.swagger.client.api.CandleApi;

CandleApi apiInstance = new CandleApi();
String market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC) 
String to = "to_example"; // String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
BigDecimal count = new BigDecimal(); // BigDecimal | 캔들 개수 
try {
    Object result = apiInstance.candleWeeks(market, to, count);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CandleApi#candleWeeks");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **BigDecimal**| 캔들 개수  | [optional]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

