# CandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**candle.days**](CandleApi.md#candle.days) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
[**candle.minutes**](CandleApi.md#candle.minutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**candle.month**](CandleApi.md#candle.month) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
[**candle.weeks**](CandleApi.md#candle.weeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)


<a name="candle.days"></a>
# **candle.days**
> kotlin.Any candle.days(market, to, count, convertingPriceUnit)

시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = CandleApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 코드 (ex. KRW-BTC) 
val to : kotlin.String = to_example // kotlin.String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
val count : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 캔들 개수 
val convertingPriceUnit : kotlin.String = convertingPriceUnit_example // kotlin.String | 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다. 
try {
    val result : kotlin.Any = apiInstance.candle.days(market, to, count, convertingPriceUnit)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling CandleApi#candle.days")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CandleApi#candle.days")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **kotlin.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **java.math.BigDecimal**| 캔들 개수  | [optional]
 **convertingPriceUnit** | **kotlin.String**| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [optional] [default to KRW]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candle.minutes"></a>
# **candle.minutes**
> kotlin.Any candle.minutes(unit, market, to, count)

시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = CandleApi()
val unit : kotlin.Int = 56 // kotlin.Int | 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
val market : kotlin.String = market_example // kotlin.String | 마켓 코드 (ex. KRW-BTC) 
val to : kotlin.String = to_example // kotlin.String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
val count : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 캔들 개수 (최대 200개까지 요청 가능) 
try {
    val result : kotlin.Any = apiInstance.candle.minutes(unit, market, to, count)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling CandleApi#candle.minutes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CandleApi#candle.minutes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unit** | **kotlin.Int**| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  |
 **market** | **kotlin.String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **kotlin.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **java.math.BigDecimal**| 캔들 개수 (최대 200개까지 요청 가능)  | [optional]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candle.month"></a>
# **candle.month**
> kotlin.Any candle.month(market, to, count)

시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = CandleApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 코드 (ex. KRW-BTC) 
val to : kotlin.String = to_example // kotlin.String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
val count : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 캔들 개수 
try {
    val result : kotlin.Any = apiInstance.candle.month(market, to, count)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling CandleApi#candle.month")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CandleApi#candle.month")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **kotlin.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **java.math.BigDecimal**| 캔들 개수  | [optional]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="candle.weeks"></a>
# **candle.weeks**
> kotlin.Any candle.weeks(market, to, count)

시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = CandleApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 코드 (ex. KRW-BTC) 
val to : kotlin.String = to_example // kotlin.String | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들 
val count : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 캔들 개수 
try {
    val result : kotlin.Any = apiInstance.candle.weeks(market, to, count)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling CandleApi#candle.weeks")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CandleApi#candle.weeks")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 코드 (ex. KRW-BTC)  |
 **to** | **kotlin.String**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional]
 **count** | **java.math.BigDecimal**| 캔들 개수  | [optional]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

