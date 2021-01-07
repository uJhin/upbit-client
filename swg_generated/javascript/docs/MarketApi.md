# UpbitOpenApi.MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**marketInfoAll**](MarketApi.md#marketInfoAll) | **GET** /market/all | 마켓 코드 조회


<a name="marketInfoAll"></a>
# **marketInfoAll**
> Object marketInfoAll(opts)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.MarketApi();

var opts = { 
  'isDetails': false // Boolean | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터) 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.marketInfoAll(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **Boolean**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

