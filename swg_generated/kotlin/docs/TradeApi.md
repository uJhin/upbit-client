# TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**trade.ticker**](TradeApi.md#trade.ticker) | **GET** /ticker | 시세 Ticker 조회
[**trade.ticks**](TradeApi.md#trade.ticks) | **GET** /trades/ticks | 시세 체결 조회


<a name="trade.ticker"></a>
# **trade.ticker**
> kotlin.Any trade.ticker(markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = TradeApi()
val markets : kotlin.String = markets_example // kotlin.String | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
try {
    val result : kotlin.Any = apiInstance.trade.ticker(markets)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling TradeApi#trade.ticker")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TradeApi#trade.ticker")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **kotlin.String**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  |

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="trade.ticks"></a>
# **trade.ticks**
> kotlin.Any trade.ticks(market, to, count, cursor, daysAgo)

시세 체결 조회

## 최근 체결 내역 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = TradeApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
val to : kotlin.String = to_example // kotlin.String | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터 
val count : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 체결 개수 
val cursor : kotlin.String = cursor_example // kotlin.String | 페이지네이션 커서 (sequentialId)  `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. 
val daysAgo : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) 
try {
    val result : kotlin.Any = apiInstance.trade.ticks(market, to, count, cursor, daysAgo)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling TradeApi#trade.ticks")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TradeApi#trade.ticks")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  |
 **to** | **kotlin.String**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional]
 **count** | **java.math.BigDecimal**| 체결 개수  | [optional]
 **cursor** | **kotlin.String**| 페이지네이션 커서 (sequentialId)  &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional]
 **daysAgo** | **java.math.BigDecimal**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

