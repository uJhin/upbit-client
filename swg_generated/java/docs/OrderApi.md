# OrderApi

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
> Order orderCancel(uuid, identifier)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
String uuid = "uuid_example"; // String | 취소할 주문의 UUID 
String identifier = "identifier_example"; // String | 조회용 사용자 지정 값 
try {
    Order result = apiInstance.orderCancel(uuid, identifier);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderCancel");
    e.printStackTrace();
}
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
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
String market = "market_example"; // String | Market ID 
try {
    OrderChance result = apiInstance.orderChance(market);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderChance");
    e.printStackTrace();
}
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
> OrderInfo orderInfo(uuid, identifier)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
String uuid = "uuid_example"; // String | 주문 UUID 
String identifier = "identifier_example"; // String | 조회용 사용자 지정 값 
try {
    OrderInfo result = apiInstance.orderInfo(uuid, identifier);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderInfo");
    e.printStackTrace();
}
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
> List&lt;Order&gt; orderInfoAll(market, state, states, uuids, identifiers, page, limit, orderBy)

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
String market = "market_example"; // String | 마켓 아이디 
String state = "state_example"; // String | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 
List<String> states = Arrays.asList("states_example"); // List<String> | 주문 상태의 목록 
List<String> uuids = Arrays.asList("uuids_example"); // List<String> | 주문 UUID의 목록 
List<String> identifiers = Arrays.asList("identifiers_example"); // List<String> | 주문 identifier의 목록 
BigDecimal page = new BigDecimal(); // BigDecimal | 페이지 수, default: 1 
BigDecimal limit = new BigDecimal(); // BigDecimal | 요청 개수, default: 100 
String orderBy = "orderBy_example"; // String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
try {
    List<Order> result = apiInstance.orderInfoAll(market, state, states, uuids, identifiers, page, limit, orderBy);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderInfoAll");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 아이디  | [optional]
 **state** | **String**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional]
 **states** | [**List&lt;String&gt;**](String.md)| 주문 상태의 목록  | [optional]
 **uuids** | [**List&lt;String&gt;**](String.md)| 주문 UUID의 목록  | [optional]
 **identifiers** | [**List&lt;String&gt;**](String.md)| 주문 identifier의 목록  | [optional]
 **page** | **BigDecimal**| 페이지 수, default: 1  | [optional]
 **limit** | **BigDecimal**| 요청 개수, default: 100  | [optional]
 **orderBy** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional]

### Return type

[**List&lt;Order&gt;**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="orderNew"></a>
# **orderNew**
> NewOrder orderNew(market, side, ordType, volume, price, identifier)

주문하기

## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  &#x60;identifier&#x60;는 서비스에서 발급하는 &#x60;uuid&#x60;가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 &#x60;identifier&#x60; 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 &#x60;ord_type&#x60; 필드를 &#x60;price&#x60; or &#x60;market&#x60; 으로 설정해야됩니다. 매수 주문의 경우 &#x60;ord_type&#x60;을 &#x60;price&#x60;로 설정하고 &#x60;volume&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 매도 주문의 경우 &#x60;ord_type&#x60;을 &#x60;market&#x60;로 설정하고 &#x60;price&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
String market = "market_example"; // String | 마켓 ID (필수) 
String side = "side_example"; // String | 주문 종류 (필수) - bid : 매수 - ask : 매도 
String ordType = "ordType_example"; // String | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 
String volume = "null"; // String | 주문량 (지정가, 시장가 매도 시 필수) 
String price = "null"; // String | 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) 
String identifier = "identifier_example"; // String | 조회용 사용자 지정값 (선택) 
try {
    NewOrder result = apiInstance.orderNew(market, side, ordType, volume, price, identifier);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderNew");
    e.printStackTrace();
}
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
> List&lt;Orderbook&gt; orderOrderbook(markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.OrderApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

OrderApi apiInstance = new OrderApi();
List<String> markets = Arrays.asList("markets_example"); // List<String> | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 
try {
    List<Orderbook> result = apiInstance.orderOrderbook(markets);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OrderApi#orderOrderbook");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**List&lt;String&gt;**](String.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  |

### Return type

[**List&lt;Orderbook&gt;**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

