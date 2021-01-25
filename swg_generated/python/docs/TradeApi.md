# swagger_client.TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**trade_ticker**](TradeApi.md#trade_ticker) | **GET** /ticker | 시세 Ticker 조회
[**trade_ticks**](TradeApi.md#trade_ticks) | **GET** /trades/ticks | 시세 체결 조회


# **trade_ticker**
> object trade_ticker(markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

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
api_instance = swagger_client.TradeApi(swagger_client.ApiClient(configuration))
markets = 'markets_example' # str | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 

try:
    # 시세 Ticker 조회
    api_response = api_instance.trade_ticker(markets)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TradeApi->trade_ticker: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **str**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **trade_ticks**
> object trade_ticks(market, to=to, count=count, cursor=cursor, days_ago=days_ago)

시세 체결 조회

## 최근 체결 내역 

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
api_instance = swagger_client.TradeApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
to = 'to_example' # str | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터  (optional)
count = 8.14 # float | 체결 개수  (optional)
cursor = 'cursor_example' # str | 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  (optional)
days_ago = 8.14 # float | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  (optional)

try:
    # 시세 체결 조회
    api_response = api_instance.trade_ticks(market, to=to, count=count, cursor=cursor, days_ago=days_ago)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TradeApi->trade_ticks: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **str**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional] 
 **count** | **float**| 체결 개수  | [optional] 
 **cursor** | **str**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 
 **days_ago** | **float**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional] 

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

