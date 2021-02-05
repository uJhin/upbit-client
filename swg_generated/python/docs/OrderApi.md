# swagger_client.OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**order_cancel**](OrderApi.md#order_cancel) | **DELETE** /order | 주문 취소 접수
[**order_chance**](OrderApi.md#order_chance) | **GET** /orders/chance | 주문 가능 정보
[**order_info**](OrderApi.md#order_info) | **GET** /order | 개별 주문 조회
[**order_info_all**](OrderApi.md#order_info_all) | **GET** /orders | 주문 리스트 조회
[**order_new**](OrderApi.md#order_new) | **POST** /orders | 주문하기
[**order_orderbook**](OrderApi.md#order_orderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


# **order_cancel**
> Order order_cancel(uuid=uuid, identifier=identifier)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
uuid = 'uuid_example' # str | 취소할 주문의 UUID  (optional)
identifier = 'identifier_example' # str | 조회용 사용자 지정 값  (optional)

try:
    # 주문 취소 접수
    api_response = api_instance.order_cancel(uuid=uuid, identifier=identifier)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_cancel: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **str**| 취소할 주문의 UUID  | [optional] 
 **identifier** | **str**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_chance**
> OrderChance order_chance(market)

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | Market ID 

try:
    # 주문 가능 정보
    api_response = api_instance.order_chance(market)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_chance: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| Market ID  | 

### Return type

[**OrderChance**](OrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_info**
> OrderInfo order_info(uuid=uuid, identifier=identifier)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
uuid = 'uuid_example' # str | 주문 UUID  (optional)
identifier = 'identifier_example' # str | 조회용 사용자 지정 값  (optional)

try:
    # 개별 주문 조회
    api_response = api_instance.order_info(uuid=uuid, identifier=identifier)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_info: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **str**| 주문 UUID  | [optional] 
 **identifier** | **str**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_info_all**
> list[Order] order_info_all(market=market, state=state, states=states, uuids=uuids, identifiers=identifiers, page=page, limit=limit, order_by=order_by)

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 아이디  (optional)
state = 'state_example' # str | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  (optional)
states = ['states_example'] # list[str] | 주문 상태의 목록  (optional)
uuids = ['uuids_example'] # list[str] | 주문 UUID의 목록  (optional)
identifiers = ['identifiers_example'] # list[str] | 주문 identifier의 목록  (optional)
page = 8.14 # float | 페이지 수, default: 1  (optional)
limit = 8.14 # float | 요청 개수, default: 100  (optional)
order_by = 'order_by_example' # str | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

try:
    # 주문 리스트 조회
    api_response = api_instance.order_info_all(market=market, state=state, states=states, uuids=uuids, identifiers=identifiers, page=page, limit=limit, order_by=order_by)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_info_all: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 아이디  | [optional] 
 **state** | **str**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional] 
 **states** | [**list[str]**](str.md)| 주문 상태의 목록  | [optional] 
 **uuids** | [**list[str]**](str.md)| 주문 UUID의 목록  | [optional] 
 **identifiers** | [**list[str]**](str.md)| 주문 identifier의 목록  | [optional] 
 **page** | **float**| 페이지 수, default: 1  | [optional] 
 **limit** | **float**| 요청 개수, default: 100  | [optional] 
 **order_by** | **str**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**list[Order]**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_new**
> NewOrder order_new(market, side, ord_type, volume=volume, price=price, identifier=identifier)

주문하기

## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 ID (필수) 
side = 'side_example' # str | 주문 종류 (필수) - bid : 매수 - ask : 매도 
ord_type = 'ord_type_example' # str | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 
volume = 'null' # str | 주문량 (지정가, 시장가 매도 시 필수)  (optional) (default to null)
price = 'null' # str | 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  (optional) (default to null)
identifier = 'identifier_example' # str | 조회용 사용자 지정값 (선택)  (optional)

try:
    # 주문하기
    api_response = api_instance.order_new(market, side, ord_type, volume=volume, price=price, identifier=identifier)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_new: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 ID (필수)  | 
 **side** | **str**| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
 **ord_type** | **str**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **volume** | **str**| 주문량 (지정가, 시장가 매도 시 필수)  | [optional] [default to null]
 **price** | **str**| 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [optional] [default to null]
 **identifier** | **str**| 조회용 사용자 지정값 (선택)  | [optional] 

### Return type

[**NewOrder**](NewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_orderbook**
> list[Orderbook] order_orderbook(markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: Bearer
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.OrderApi(swagger_client.ApiClient(configuration))
markets = ['markets_example'] # list[str] | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 

try:
    # 시세 호가 정보(Orderbook) 조회
    api_response = api_instance.order_orderbook(markets)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OrderApi->order_orderbook: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**list[str]**](str.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  | 

### Return type

[**list[Orderbook]**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

