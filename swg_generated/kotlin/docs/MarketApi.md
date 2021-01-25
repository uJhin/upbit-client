# MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**market.infoAll**](MarketApi.md#market.infoAll) | **GET** /market/all | 마켓 코드 조회


<a name="market.infoAll"></a>
# **market.infoAll**
> kotlin.Any market.infoAll(isDetails)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = MarketApi()
val isDetails : kotlin.Boolean = true // kotlin.Boolean | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터) 
try {
    val result : kotlin.Any = apiInstance.market.infoAll(isDetails)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling MarketApi#market.infoAll")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MarketApi#market.infoAll")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **kotlin.Boolean**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

