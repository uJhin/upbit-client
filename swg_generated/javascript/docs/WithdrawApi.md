# UpbitOpenApi.WithdrawApi

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
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.WithdrawApi();

var currency = "currency_example"; // String | Currency Symbol 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.withdrawChance(currency, callback);
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
> WithdrawCoin withdrawCoin(currency, amount, address, opts)

코인 출금하기

## 코인 출금을 요청한다.  **NOTE**: 바로출금 이용 시 유의사항  업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.WithdrawApi();

var currency = "currency_example"; // String | Currency 코드 

var amount = "amount_example"; // String | 출금 수량 

var address = "address_example"; // String | 출금 가능 주소에 등록된 출금 주소 

var opts = { 
  'secondaryAddress': "secondaryAddress_example", // String | 2차 출금 주소 (필요한 코인에 한해서) 
  'transactionType': "transactionType_example" // String | 출금 유형 - default : 일반출금 - internal : 바로출금 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.withdrawCoin(currency, amount, address, opts, callback);
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
> Withdraw withdrawInfo(opts)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.WithdrawApi();

var opts = { 
  'uuid': "uuid_example", // String | 출금 UUID 
  'txid': "txid_example", // String | 출금 TXID 
  'currency': "currency_example" // String | Currency 코드 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.withdrawInfo(opts, callback);
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
> [Withdraw] withdrawInfoAll(opts)

출금 리스트 조회

## 출금 리스트를 조회한다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.WithdrawApi();

var opts = { 
  'currency': "currency_example", // String | Currency 코드 
  'state': "state_example", // String | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 
  'uuids': ["uuids_example"], // [String] | 출금 UUID의 목록 
  'txids': ["txids_example"], // [String] | 출금 TXID의 목록 
  'limit': 8.14, // Number | 개수 제한 (default: 100, max: 100) 
  'page': 8.14, // Number | 페이지 수, default: 1 
  'orderBy': "orderBy_example" // String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.withdrawInfoAll(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | [optional] 
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional] 
 **uuids** | [**[String]**](String.md)| 출금 UUID의 목록  | [optional] 
 **txids** | [**[String]**](String.md)| 출금 TXID의 목록  | [optional] 
 **limit** | **Number**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **Number**| 페이지 수, default: 1  | [optional] 
 **orderBy** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**[Withdraw]**](Withdraw.md)

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
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.WithdrawApi();

var amount = "amount_example"; // String | 출금 원화 수량 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.withdrawKrw(amount, callback);
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

