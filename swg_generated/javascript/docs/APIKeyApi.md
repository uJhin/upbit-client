# UpbitOpenApi.APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**aPIKeyInfo**](APIKeyApi.md#aPIKeyInfo) | **GET** /api_keys | API 키 리스트 조회


<a name="aPIKeyInfo"></a>
# **aPIKeyInfo**
> [APIKey] aPIKeyInfo()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.APIKeyApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.aPIKeyInfo(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[APIKey]**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

