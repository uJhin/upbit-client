# \OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**order_cancel**](OrderApi.md#order_cancel) | **Delete** /order | 주문 취소 접수
[**order_chance**](OrderApi.md#order_chance) | **Get** /orders/chance | 주문 가능 정보
[**order_info**](OrderApi.md#order_info) | **Get** /order | 개별 주문 조회
[**order_info_all**](OrderApi.md#order_info_all) | **Get** /orders | 주문 리스트 조회
[**order_new**](OrderApi.md#order_new) | **Post** /orders | 주문하기
[**order_orderbook**](OrderApi.md#order_orderbook) | **Get** /orderbook | 시세 호가 정보(Orderbook) 조회


# **order_cancel**
> ::models::Order order_cancel(ctx, optional)
주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 취소할 주문의 UUID  | 
 **identifier** | **String**| 조회용 사용자 지정 값  | 

### Return type

[**::models::Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_chance**
> ::models::OrderChance order_chance(ctx, market)
주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **market** | **String**| Market ID  | 

### Return type

[**::models::OrderChance**](OrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_info**
> ::models::OrderInfo order_info(ctx, optional)
개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 주문 UUID  | 
 **identifier** | **String**| 조회용 사용자 지정 값  | 

### Return type

[**::models::OrderInfo**](OrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_info_all**
> Vec<::models::Order> order_info_all(ctx, optional)
주문 리스트 조회

## 주문 리스트를 조회한다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 아이디  | 
 **state** | **String**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | 
 **states** | [**Vec&lt;String&gt;**](String.md)| 주문 상태의 목록  | 
 **uuids** | [**Vec&lt;String&gt;**](String.md)| 주문 UUID의 목록  | 
 **identifiers** | [**Vec&lt;String&gt;**](String.md)| 주문 identifier의 목록  | 
 **page** | **f32**| 페이지 수, default: 1  | 
 **limit** | **f32**| 요청 개수, default: 100  | 
 **order_by** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | 

### Return type

[**Vec<::models::Order>**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_new**
> ::models::NewOrder order_new(ctx, market, side, ord_type, optional)
주문하기

## 주문 요청을 한다. **NOTE**: 원화 마켓 가격 단위를 확인하세요. 원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요. **NOTE**: identifier 파라미터 사용 `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다. 주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요. **NOTE**: 시장가 주문 시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **market** | **String**| 마켓 ID (필수)  | 
  **side** | **String**| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
  **ord_type** | **String**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **optional** | **map[string]interface{}** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a map[string]interface{}.

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 ID (필수)  | 
 **side** | **String**| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
 **ord_type** | **String**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **volume** | **String**| 주문량 (지정가, 시장가 매도 시 필수)  | [default to null]
 **price** | **String**| 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [default to null]
 **identifier** | **String**| 조회용 사용자 지정값 (선택)  | 

### Return type

[**::models::NewOrder**](NewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_orderbook**
> Vec<::models::Orderbook> order_orderbook(ctx, markets)
시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context containing the authentication | nil if no authentication
  **markets** | [**Vec&lt;String&gt;**](String.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  | 

### Return type

[**Vec<::models::Orderbook>**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

