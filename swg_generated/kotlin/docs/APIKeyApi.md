# APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**aPIKey.info**](APIKeyApi.md#aPIKey.info) | **GET** /api_keys | API 키 리스트 조회


<a name="aPIKey.info"></a>
# **aPIKey.info**
> kotlin.Array&lt;APIKey&gt; aPIKey.info()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = APIKeyApi()
try {
    val result : kotlin.Array<APIKey> = apiInstance.aPIKey.info()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling APIKeyApi#aPIKey.info")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling APIKeyApi#aPIKey.info")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**kotlin.Array&lt;APIKey&gt;**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

