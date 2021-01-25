# TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tradeTicker**](TradeApi.md#tradeTicker) | **GET** /ticker | 시세 Ticker 조회
[**tradeTicks**](TradeApi.md#tradeTicks) | **GET** /trades/ticks | 시세 체결 조회


<a name="tradeTicker"></a>
# **tradeTicker**
> Object tradeTicker(markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Example
```java
// Import classes:
//import io.swagger.client.api.TradeApi;

TradeApi apiInstance = new TradeApi();
String markets = "markets_example"; // String | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
try {
    Object result = apiInstance.tradeTicker(markets);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TradeApi#tradeTicker");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **String**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="tradeTicks"></a>
# **tradeTicks**
> Object tradeTicks(market, to, count, cursor, daysAgo)

시세 체결 조회

## 최근 체결 내역 

### Example
```java
// Import classes:
//import io.swagger.client.api.TradeApi;

TradeApi apiInstance = new TradeApi();
String market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
String to = "to_example"; // String | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터 
BigDecimal count = new BigDecimal(); // BigDecimal | 체결 개수 
String cursor = "cursor_example"; // String | 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. 
BigDecimal daysAgo = new BigDecimal(); // BigDecimal | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) 
try {
    Object result = apiInstance.tradeTicks(market, to, count, cursor, daysAgo);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TradeApi#tradeTicks");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  |
 **to** | **String**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional]
 **count** | **BigDecimal**| 체결 개수  | [optional]
 **cursor** | **String**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional]
 **daysAgo** | **BigDecimal**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

