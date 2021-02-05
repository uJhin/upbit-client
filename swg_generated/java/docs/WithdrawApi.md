# WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdrawChance**](WithdrawApi.md#withdrawChance) | **GET** /withdraws/chance | 출금 가능 정보
[**withdrawCoin**](WithdrawApi.md#withdrawCoin) | **POST** /withdraws/coin | 코인 출금하기
[**withdrawInfo**](WithdrawApi.md#withdrawInfo) | **GET** /withdraw | 개별 출금 조회
[**withdrawInfoAll**](WithdrawApi.md#withdrawInfoAll) | **GET** /withdraws | 출금 리스트 조회
[**withdrawKrw**](WithdrawApi.md#withdrawKrw) | **POST** /withdraws/krw | 원화 출금하기


<a name="withdrawChance"></a>
# **withdrawChance**
> WithdrawChance withdrawChance(currency)

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WithdrawApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

WithdrawApi apiInstance = new WithdrawApi();
String currency = "currency_example"; // String | Currency Symbol 
try {
    WithdrawChance result = apiInstance.withdrawChance(currency);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WithdrawApi#withdrawChance");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency Symbol  |

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdrawCoin"></a>
# **withdrawCoin**
> WithdrawCoin withdrawCoin(currency, amount, address, secondaryAddress, transactionType)

코인 출금하기

## 코인 출금을 요청한다.  **NOTE**: 바로출금 이용 시 유의사항  업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WithdrawApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

WithdrawApi apiInstance = new WithdrawApi();
String currency = "currency_example"; // String | Currency 코드 
String amount = "amount_example"; // String | 출금 수량 
String address = "address_example"; // String | 출금 가능 주소에 등록된 출금 주소 
String secondaryAddress = "secondaryAddress_example"; // String | 2차 출금 주소 (필요한 코인에 한해서) 
String transactionType = "transactionType_example"; // String | 출금 유형 - default : 일반출금 - internal : 바로출금 
try {
    WithdrawCoin result = apiInstance.withdrawCoin(currency, amount, address, secondaryAddress, transactionType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WithdrawApi#withdrawCoin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  |
 **amount** | **String**| 출금 수량  |
 **address** | **String**| 출금 가능 주소에 등록된 출금 주소  |
 **secondaryAddress** | **String**| 2차 출금 주소 (필요한 코인에 한해서)  | [optional]
 **transactionType** | **String**| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional]

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

<a name="withdrawInfo"></a>
# **withdrawInfo**
> Withdraw withdrawInfo(uuid, txid, currency)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WithdrawApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

WithdrawApi apiInstance = new WithdrawApi();
String uuid = "uuid_example"; // String | 출금 UUID 
String txid = "txid_example"; // String | 출금 TXID 
String currency = "currency_example"; // String | Currency 코드 
try {
    Withdraw result = apiInstance.withdrawInfo(uuid, txid, currency);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WithdrawApi#withdrawInfo");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 출금 UUID  | [optional]
 **txid** | **String**| 출금 TXID  | [optional]
 **currency** | **String**| Currency 코드  | [optional]

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdrawInfoAll"></a>
# **withdrawInfoAll**
> List&lt;Withdraw&gt; withdrawInfoAll(currency, state, uuids, txids, limit, page, orderBy)

출금 리스트 조회

## 출금 리스트를 조회한다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WithdrawApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

WithdrawApi apiInstance = new WithdrawApi();
String currency = "currency_example"; // String | Currency 코드 
String state = "state_example"; // String | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 
List<String> uuids = Arrays.asList("uuids_example"); // List<String> | 출금 UUID의 목록 
List<String> txids = Arrays.asList("txids_example"); // List<String> | 출금 TXID의 목록 
BigDecimal limit = new BigDecimal(); // BigDecimal | 개수 제한 (default: 100, max: 100) 
BigDecimal page = new BigDecimal(); // BigDecimal | 페이지 수, default: 1 
String orderBy = "orderBy_example"; // String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
try {
    List<Withdraw> result = apiInstance.withdrawInfoAll(currency, state, uuids, txids, limit, page, orderBy);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WithdrawApi#withdrawInfoAll");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | [optional]
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional]
 **uuids** | [**List&lt;String&gt;**](String.md)| 출금 UUID의 목록  | [optional]
 **txids** | [**List&lt;String&gt;**](String.md)| 출금 TXID의 목록  | [optional]
 **limit** | **BigDecimal**| 개수 제한 (default: 100, max: 100)  | [optional]
 **page** | **BigDecimal**| 페이지 수, default: 1  | [optional]
 **orderBy** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional]

### Return type

[**List&lt;Withdraw&gt;**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="withdrawKrw"></a>
# **withdrawKrw**
> Withdraw withdrawKrw(amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WithdrawApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

WithdrawApi apiInstance = new WithdrawApi();
String amount = "amount_example"; // String | 출금 원화 수량 
try {
    Withdraw result = apiInstance.withdrawKrw(amount);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WithdrawApi#withdrawKrw");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **String**| 출금 원화 수량  |

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

