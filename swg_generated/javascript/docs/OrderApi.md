# UpbitOpenApi.OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderCancel**](OrderApi.md#orderCancel) | **DELETE** /order | 주문 취소 접수
[**orderChance**](OrderApi.md#orderChance) | **GET** /orders/chance | 주문 가능 정보
[**orderInfo**](OrderApi.md#orderInfo) | **GET** /order | 개별 주문 조회
[**orderInfoAll**](OrderApi.md#orderInfoAll) | **GET** /orders | 주문 리스트 조회
[**orderNew**](OrderApi.md#orderNew) | **POST** /orders | 주문하기
[**orderOrderbook**](OrderApi.md#orderOrderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


<a name="orderCancel"></a>
# **orderCancel**
> Order orderCancel(opts)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var opts = { 
  'uuid': "uuid_example", // String | 취소할 주문의 UUID 
  'identifier': "identifier_example" // String | 조회용 사용자 지정 값 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderCancel(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 취소할 주문의 UUID  | [optional] 
 **identifier** | **String**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="orderChance"></a>
# **orderChance**
> OrderChance orderChance(market)

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var market = "market_example"; // String | Market ID 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderChance(market, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| Market ID  | 

### Return type

[**OrderChance**](OrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="orderInfo"></a>
# **orderInfo**
> OrderInfo orderInfo(opts)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var opts = { 
  'uuid': "uuid_example", // String | 주문 UUID 
  'identifier': "identifier_example" // String | 조회용 사용자 지정 값 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderInfo(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 주문 UUID  | [optional] 
 **identifier** | **String**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="orderInfoAll"></a>
# **orderInfoAll**
> [Order] orderInfoAll(opts)

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var opts = { 
  'market': "market_example", // String | 마켓 아이디 
  'state': "state_example", // String | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 
  'states': ["states_example"], // [String] | 주문 상태의 목록 
  'uuids': ["uuids_example"], // [String] | 주문 UUID의 목록 
  'identifiers': ["identifiers_example"], // [String] | 주문 identifier의 목록 
  'page': 8.14, // Number | 페이지 수, default: 1 
  'limit': 8.14, // Number | 요청 개수, default: 100 
  'orderBy': "orderBy_example" // String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderInfoAll(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 아이디  | [optional] 
 **state** | **String**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional] 
 **states** | [**[String]**](String.md)| 주문 상태의 목록  | [optional] 
 **uuids** | [**[String]**](String.md)| 주문 UUID의 목록  | [optional] 
 **identifiers** | [**[String]**](String.md)| 주문 identifier의 목록  | [optional] 
 **page** | **Number**| 페이지 수, default: 1  | [optional] 
 **limit** | **Number**| 요청 개수, default: 100  | [optional] 
 **orderBy** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**[Order]**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="orderNew"></a>
# **orderNew**
> NewOrder orderNew(market, side, ordType, opts)

주문하기

## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var market = "market_example"; // String | 마켓 ID (필수) 

var side = "side_example"; // String | 주문 종류 (필수) - bid : 매수 - ask : 매도 

var ordType = "ordType_example"; // String | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 

var opts = { 
  'volume': "null", // String | 주문량 (지정가, 시장가 매도 시 필수) 
  'price': "null", // String | 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) 
  'identifier': "identifier_example" // String | 조회용 사용자 지정값 (선택) 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderNew(market, side, ordType, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 ID (필수)  | 
 **side** | **String**| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
 **ordType** | **String**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **volume** | **String**| 주문량 (지정가, 시장가 매도 시 필수)  | [optional] [default to null]
 **price** | **String**| 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [optional] [default to null]
 **identifier** | **String**| 조회용 사용자 지정값 (선택)  | [optional] 

### Return type

[**NewOrder**](NewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

<a name="orderOrderbook"></a>
# **orderOrderbook**
> [Orderbook] orderOrderbook(markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example
```javascript
var UpbitOpenApi = require('upbit_open_api');
var defaultClient = UpbitOpenApi.ApiClient.instance;

// Configure API key authorization: Bearer
var Bearer = defaultClient.authentications['Bearer'];
Bearer.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.apiKeyPrefix = 'Token';

var apiInstance = new UpbitOpenApi.OrderApi();

var markets = ["markets_example"]; // [String] | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.orderOrderbook(markets, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**[String]**](String.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  | 

### Return type

[**[Orderbook]**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

