# WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdraw.chance**](WithdrawApi.md#withdraw.chance) | **GET** /withdraws/chance | 출금 가능 정보
[**withdraw.coin**](WithdrawApi.md#withdraw.coin) | **POST** /withdraws/coin | 코인 출금하기
[**withdraw.info**](WithdrawApi.md#withdraw.info) | **GET** /withdraw | 개별 출금 조회
[**withdraw.infoAll**](WithdrawApi.md#withdraw.infoAll) | **GET** /withdraws | 출금 리스트 조회
[**withdraw.krw**](WithdrawApi.md#withdraw.krw) | **POST** /withdraws/krw | 원화 출금하기


<a name="withdraw.chance"></a>
# **withdraw.chance**
> WithdrawChance withdraw.chance(currency)

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = WithdrawApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency Symbol 
try {
    val result : WithdrawChance = apiInstance.withdraw.chance(currency)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling WithdrawApi#withdraw.chance")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WithdrawApi#withdraw.chance")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency Symbol  |

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdraw.coin"></a>
# **withdraw.coin**
> WithdrawCoin withdraw.coin(currency, amount, address, secondaryAddress, transactionType)

코인 출금하기

## 코인 출금을 요청한다.  **NOTE**: 바로출금 이용 시 유의사항  업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = WithdrawApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
val amount : kotlin.String = amount_example // kotlin.String | 출금 수량 
val address : kotlin.String = address_example // kotlin.String | 출금 가능 주소에 등록된 출금 주소 
val secondaryAddress : kotlin.String = secondaryAddress_example // kotlin.String | 2차 출금 주소 (필요한 코인에 한해서) 
val transactionType : kotlin.String = transactionType_example // kotlin.String | 출금 유형 - default : 일반출금 - internal : 바로출금 
try {
    val result : WithdrawCoin = apiInstance.withdraw.coin(currency, amount, address, secondaryAddress, transactionType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling WithdrawApi#withdraw.coin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WithdrawApi#withdraw.coin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency 코드  |
 **amount** | **kotlin.String**| 출금 수량  |
 **address** | **kotlin.String**| 출금 가능 주소에 등록된 출금 주소  |
 **secondaryAddress** | **kotlin.String**| 2차 출금 주소 (필요한 코인에 한해서)  | [optional]
 **transactionType** | **kotlin.String**| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional]

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

<a name="withdraw.info"></a>
# **withdraw.info**
> Withdraw withdraw.info(uuid, txid, currency)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = WithdrawApi()
val uuid : kotlin.String = uuid_example // kotlin.String | 출금 UUID 
val txid : kotlin.String = txid_example // kotlin.String | 출금 TXID 
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
try {
    val result : Withdraw = apiInstance.withdraw.info(uuid, txid, currency)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling WithdrawApi#withdraw.info")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WithdrawApi#withdraw.info")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **kotlin.String**| 출금 UUID  | [optional]
 **txid** | **kotlin.String**| 출금 TXID  | [optional]
 **currency** | **kotlin.String**| Currency 코드  | [optional]

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdraw.infoAll"></a>
# **withdraw.infoAll**
> kotlin.Array&lt;Withdraw&gt; withdraw.infoAll(currency, state, uuids, txids, limit, page, orderBy)

출금 리스트 조회

## 출금 리스트를 조회한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = WithdrawApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
val state : kotlin.String = state_example // kotlin.String | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 
val uuids : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 출금 UUID의 목록 
val txids : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 출금 TXID의 목록 
val limit : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 개수 제한 (default: 100, max: 100) 
val page : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 페이지 수, default: 1 
val orderBy : kotlin.String = orderBy_example // kotlin.String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
try {
    val result : kotlin.Array<Withdraw> = apiInstance.withdraw.infoAll(currency, state, uuids, txids, limit, page, orderBy)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling WithdrawApi#withdraw.infoAll")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WithdrawApi#withdraw.infoAll")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency 코드  | [optional]
 **state** | **kotlin.String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional]
 **uuids** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 출금 UUID의 목록  | [optional]
 **txids** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 출금 TXID의 목록  | [optional]
 **limit** | **java.math.BigDecimal**| 개수 제한 (default: 100, max: 100)  | [optional]
 **page** | **java.math.BigDecimal**| 페이지 수, default: 1  | [optional]
 **orderBy** | **kotlin.String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional]

### Return type

[**kotlin.Array&lt;Withdraw&gt;**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdraw.krw"></a>
# **withdraw.krw**
> Withdraw withdraw.krw(amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = WithdrawApi()
val amount : kotlin.String = amount_example // kotlin.String | 출금 원화 수량 
try {
    val result : Withdraw = apiInstance.withdraw.krw(amount)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling WithdrawApi#withdraw.krw")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WithdrawApi#withdraw.krw")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **kotlin.String**| 출금 원화 수량  |

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

