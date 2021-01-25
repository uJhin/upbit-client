# OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**order.cancel**](OrderApi.md#order.cancel) | **DELETE** /order | 주문 취소 접수
[**order.chance**](OrderApi.md#order.chance) | **GET** /orders/chance | 주문 가능 정보
[**order.info**](OrderApi.md#order.info) | **GET** /order | 개별 주문 조회
[**order.infoAll**](OrderApi.md#order.infoAll) | **GET** /orders | 주문 리스트 조회
[**order.new**](OrderApi.md#order.new) | **POST** /orders | 주문하기
[**order.orderbook**](OrderApi.md#order.orderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


<a name="order.cancel"></a>
# **order.cancel**
> Order order.cancel(uuid, identifier)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다. **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val uuid : kotlin.String = uuid_example // kotlin.String | 취소할 주문의 UUID 
val identifier : kotlin.String = identifier_example // kotlin.String | 조회용 사용자 지정 값 
try {
    val result : Order = apiInstance.order.cancel(uuid, identifier)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.cancel")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.cancel")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **kotlin.String**| 취소할 주문의 UUID  | [optional]
 **identifier** | **kotlin.String**| 조회용 사용자 지정 값  | [optional]

### Return type

[**Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="order.chance"></a>
# **order.chance**
> OrderChance order.chance(market)

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val market : kotlin.String = market_example // kotlin.String | Market ID 
try {
    val result : OrderChance = apiInstance.order.chance(market)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.chance")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.chance")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| Market ID  |

### Return type

[**OrderChance**](OrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="order.info"></a>
# **order.info**
> OrderInfo order.info(uuid, identifier)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다. **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val uuid : kotlin.String = uuid_example // kotlin.String | 주문 UUID 
val identifier : kotlin.String = identifier_example // kotlin.String | 조회용 사용자 지정 값 
try {
    val result : OrderInfo = apiInstance.order.info(uuid, identifier)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.info")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.info")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **kotlin.String**| 주문 UUID  | [optional]
 **identifier** | **kotlin.String**| 조회용 사용자 지정 값  | [optional]

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="order.infoAll"></a>
# **order.infoAll**
> kotlin.Array&lt;Order&gt; order.infoAll(market, state, states, uuids, identifiers, page, limit, orderBy)

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 아이디 
val state : kotlin.String = state_example // kotlin.String | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 
val states : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 주문 상태의 목록 
val uuids : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 주문 UUID의 목록 
val identifiers : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 주문 identifier의 목록 
val page : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 페이지 수, default: 1 
val limit : java.math.BigDecimal = 8.14 // java.math.BigDecimal | 요청 개수, default: 100 
val orderBy : kotlin.String = orderBy_example // kotlin.String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
try {
    val result : kotlin.Array<Order> = apiInstance.order.infoAll(market, state, states, uuids, identifiers, page, limit, orderBy)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.infoAll")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.infoAll")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 아이디  | [optional]
 **state** | **kotlin.String**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional]
 **states** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 주문 상태의 목록  | [optional]
 **uuids** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 주문 UUID의 목록  | [optional]
 **identifiers** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 주문 identifier의 목록  | [optional]
 **page** | **java.math.BigDecimal**| 페이지 수, default: 1  | [optional]
 **limit** | **java.math.BigDecimal**| 요청 개수, default: 100  | [optional]
 **orderBy** | **kotlin.String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional]

### Return type

[**kotlin.Array&lt;Order&gt;**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="order.new"></a>
# **order.new**
> NewOrder order.new(market, side, ordType, volume, price, identifier)

주문하기

## 주문 요청을 한다. **NOTE**: 원화 마켓 가격 단위를 확인하세요. 원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요. **NOTE**: identifier 파라미터 사용 &#x60;identifier&#x60;는 서비스에서 발급하는 &#x60;uuid&#x60;가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다. 주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 &#x60;identifier&#x60; 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요. **NOTE**: 시장가 주문 시장가 주문은 &#x60;ord_type&#x60; 필드를 &#x60;price&#x60; or &#x60;market&#x60; 으로 설정해야됩니다. 매수 주문의 경우 &#x60;ord_type&#x60;을 &#x60;price&#x60;로 설정하고 &#x60;volume&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 매도 주문의 경우 &#x60;ord_type&#x60;을 &#x60;market&#x60;로 설정하고 &#x60;price&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val market : kotlin.String = market_example // kotlin.String | 마켓 ID (필수) 
val side : kotlin.String = side_example // kotlin.String | 주문 종류 (필수) - bid : 매수 - ask : 매도 
val ordType : kotlin.String = ordType_example // kotlin.String | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 
val volume : kotlin.String = volume_example // kotlin.String | 주문량 (지정가, 시장가 매도 시 필수) 
val price : kotlin.String = price_example // kotlin.String | 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) 
val identifier : kotlin.String = identifier_example // kotlin.String | 조회용 사용자 지정값 (선택) 
try {
    val result : NewOrder = apiInstance.order.new(market, side, ordType, volume, price, identifier)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.new")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.new")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **kotlin.String**| 마켓 ID (필수)  |
 **side** | **kotlin.String**| 주문 종류 (필수) - bid : 매수 - ask : 매도  |
 **ordType** | **kotlin.String**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  |
 **volume** | **kotlin.String**| 주문량 (지정가, 시장가 매도 시 필수)  | [optional] [default to null]
 **price** | **kotlin.String**| 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [optional] [default to null]
 **identifier** | **kotlin.String**| 조회용 사용자 지정값 (선택)  | [optional]

### Return type

[**NewOrder**](NewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

<a name="order.orderbook"></a>
# **order.orderbook**
> kotlin.Array&lt;Orderbook&gt; order.orderbook(markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*

val apiInstance = OrderApi()
val markets : kotlin.Array<kotlin.String> =  // kotlin.Array<kotlin.String> | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 
try {
    val result : kotlin.Array<Orderbook> = apiInstance.order.orderbook(markets)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling OrderApi#order.orderbook")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling OrderApi#order.orderbook")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**kotlin.Array&lt;kotlin.String&gt;**](kotlin.String.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  |

### Return type

[**kotlin.Array&lt;Orderbook&gt;**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

