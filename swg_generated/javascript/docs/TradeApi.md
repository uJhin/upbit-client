# UpbitOpenApi.TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tradeTicker**](TradeApi.md#tradeTicker) | **GET** /ticker | 시세 Ticker 조회
[**tradeTicks**](TradeApi.md#tradeTicks) | **GET** /trades/ticks | 시세 체결 조회


<a name="tradeTicker"></a>
# **tradeTicker**
> Object tradeTicker(markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.TradeApi();

var markets = "markets_example"; // String | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.tradeTicker(markets, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **String**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="tradeTicks"></a>
# **tradeTicks**
> Object tradeTicks(market, opts)

시세 체결 조회

## 최근 체결 내역 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.TradeApi();

var market = "market_example"; // String | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 

var opts = { 
  'to': "to_example", // String | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터 
  'count': 8.14, // Number | 체결 개수 
  'cursor': "cursor_example", // String | 페이지네이션 커서 (sequentialId)  `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. 
  'daysAgo': 8.14 // Number | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.tradeTicks(market, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **String**| 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터  | [optional] 
 **count** | **Number**| 체결 개수  | [optional] 
 **cursor** | **String**| 페이지네이션 커서 (sequentialId)  `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 
 **daysAgo** | **Number**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

