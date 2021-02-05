# AccountApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**account.info**](AccountApi.md#account.info) | **GET** /accounts | 전체 계좌 조회
[**account.wallet**](AccountApi.md#account.wallet) | **GET** /status/wallet | 입출금 현황


<a name="account.info"></a>
# **account.info**
> kotlin.Array&lt;Account&gt; account.info()

전체 계좌 조회

## 내가 보유한 자산 리스트를 보여줍니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = AccountApi()
try {
    val result : kotlin.Array<Account> = apiInstance.account.info()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling AccountApi#account.info")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AccountApi#account.info")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**kotlin.Array&lt;Account&gt;**](Account.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="account.wallet"></a>
# **account.wallet**
> kotlin.Array&lt;Wallet&gt; account.wallet()

입출금 현황

## 입출금 현황 및 블록 상태를 조회합니다.  **NOTE**: 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다.  입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다. 본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = AccountApi()
try {
    val result : kotlin.Array<Wallet> = apiInstance.account.wallet()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling AccountApi#account.wallet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AccountApi#account.wallet")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**kotlin.Array&lt;Wallet&gt;**](Wallet.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

