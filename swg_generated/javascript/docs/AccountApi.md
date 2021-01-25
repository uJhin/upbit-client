# UpbitOpenApi.AccountApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountInfo**](AccountApi.md#accountInfo) | **GET** /accounts | 전체 계좌 조회
[**accountWallet**](AccountApi.md#accountWallet) | **GET** /status/wallet | 입출금 현황


<a name="accountInfo"></a>
# **accountInfo**
> [Account] accountInfo()

전체 계좌 조회

## 내가 보유한 자산 리스트를 보여줍니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.AccountApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.accountInfo(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Account]**](Account.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="accountWallet"></a>
# **accountWallet**
> [Wallet] accountWallet()

입출금 현황

## 입출금 현황 및 블록 상태를 조회합니다. **NOTE**: 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다. 입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다. 본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.AccountApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.accountWallet(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Wallet]**](Wallet.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

