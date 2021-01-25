# DepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deposit.coinAddress**](DepositApi.md#deposit.coinAddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
[**deposit.coinAddresses**](DepositApi.md#deposit.coinAddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
[**deposit.generateCoinAddress**](DepositApi.md#deposit.generateCoinAddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
[**deposit.info**](DepositApi.md#deposit.info) | **GET** /deposit | 개별 입금 조회
[**deposit.infoAll**](DepositApi.md#deposit.infoAll) | **GET** /deposits | 입금 리스트 조회


<a name="deposit.coinAddress"></a>
# **deposit.coinAddress**
> DepositCompleteResponse deposit.coinAddress(currency)

개별 입금 주소 조회

## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = DepositApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency symbol 
try {
    val result : DepositCompleteResponse = apiInstance.deposit.coinAddress(currency)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DepositApi#deposit.coinAddress")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepositApi#deposit.coinAddress")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency symbol  |

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="deposit.coinAddresses"></a>
# **deposit.coinAddresses**
> kotlin.Any deposit.coinAddresses()

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = DepositApi()
try {
    val result : kotlin.Any = apiInstance.deposit.coinAddresses()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DepositApi#deposit.coinAddresses")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepositApi#deposit.coinAddresses")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**kotlin.Any**](kotlin.Any.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="deposit.generateCoinAddress"></a>
# **deposit.generateCoinAddress**
> DepositCompleteResponse deposit.generateCoinAddress(currency)

입금 주소 생성 요청

입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = DepositApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
try {
    val result : DepositCompleteResponse = apiInstance.deposit.generateCoinAddress(currency)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DepositApi#deposit.generateCoinAddress")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepositApi#deposit.generateCoinAddress")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency 코드  |

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

<a name="deposit.info"></a>
# **deposit.info**
> Deposit deposit.info(uuid, txid, currency)

개별 입금 조회

## 개별 입금 조회 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = DepositApi()
val uuid : kotlin.String = uuid_example // kotlin.String | 입금 UUID 
val txid : kotlin.String = txid_example // kotlin.String | 입금 TXID 
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
try {
    val result : Deposit = apiInstance.deposit.info(uuid, txid, currency)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DepositApi#deposit.info")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepositApi#deposit.info")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **kotlin.String**| 입금 UUID  | [optional]
 **txid** | **kotlin.String**| 입금 TXID  | [optional]
 **currency** | **kotlin.String**| Currency 코드  | [optional]

### Return type

[**Deposit**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="deposit.infoAll"></a>
# **deposit.infoAll**
> kotlin.Array&lt;Deposit&gt; deposit.infoAll(currency, state, uuids, txids, limit, page, orderBy)

입금 리스트 조회

## 입금 리스트 조회 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = DepositApi()
val currency : kotlin.String = currency_example // kotlin.String | Currency 코드 
val state : kotlin.String = state_example // kotlin.String | 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중 
val uuids : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 입금 UUID의 목록 
val txids : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 입금 TXID의 목록 
val limit : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 개수 제한 (default: 100, max: 100) 
val page : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 페이지 수, default: 1 
val orderBy : kotlin.String = orderBy_example // kotlin.String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
try {
    val result : kotlin.Array<Deposit> = apiInstance.deposit.infoAll(currency, state, uuids, txids, limit, page, orderBy)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DepositApi#deposit.infoAll")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepositApi#deposit.infoAll")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **kotlin.String**| Currency 코드  | [optional]
 **state** | **kotlin.String**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | [optional]
 **uuids** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 입금 UUID의 목록  | [optional]
 **txids** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 입금 TXID의 목록  | [optional]
 **limit** | **java.math.BigDecimal**| 개수 제한 (default: 100, max: 100)  | [optional]
 **page** | **java.math.BigDecimal**| 페이지 수, default: 1  | [optional]
 **orderBy** | **kotlin.String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional]

### Return type

[**kotlin.Array&lt;Deposit&gt;**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

