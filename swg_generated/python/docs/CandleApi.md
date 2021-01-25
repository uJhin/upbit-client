# swagger_client.CandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**candle_days**](CandleApi.md#candle_days) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
[**candle_minutes**](CandleApi.md#candle_minutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**candle_month**](CandleApi.md#candle_month) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
[**candle_weeks**](CandleApi.md#candle_weeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)


# **candle_days**
> object candle_days(market, to=to, count=count, converting_price_unit=converting_price_unit)

시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

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
api_instance = swagger_client.CandleApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 코드 (ex. KRW-BTC) 
to = 'to_example' # str | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
count = 8.14 # float | 캔들 개수  (optional)
converting_price_unit = 'KRW' # str | 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.) `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  (optional) (default to KRW)

try:
    # 시세 캔들 조회 (일 단위)
    api_response = api_instance.candle_days(market, to=to, count=count, converting_price_unit=converting_price_unit)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CandleApi->candle_days: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **str**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **float**| 캔들 개수  | [optional] 
 **converting_price_unit** | **str**| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.) &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [optional] [default to KRW]

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candle_minutes**
> object candle_minutes(unit, market, to=to, count=count)

시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

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
api_instance = swagger_client.CandleApi(swagger_client.ApiClient(configuration))
unit = 56 # int | 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
market = 'market_example' # str | 마켓 코드 (ex. KRW-BTC) 
to = 'to_example' # str | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
count = 8.14 # float | 캔들 개수 (최대 200개까지 요청 가능)  (optional)

try:
    # 시세 캔들 조회 (분 단위)
    api_response = api_instance.candle_minutes(unit, market, to=to, count=count)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CandleApi->candle_minutes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unit** | **int**| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  | 
 **market** | **str**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **str**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **float**| 캔들 개수 (최대 200개까지 요청 가능)  | [optional] 

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candle_month**
> object candle_month(market, to=to, count=count)

시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

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
api_instance = swagger_client.CandleApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 코드 (ex. KRW-BTC) 
to = 'to_example' # str | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
count = 8.14 # float | 캔들 개수  (optional)

try:
    # 시세 캔들 조회 (월 단위)
    api_response = api_instance.candle_month(market, to=to, count=count)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CandleApi->candle_month: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **str**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **float**| 캔들 개수  | [optional] 

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candle_weeks**
> object candle_weeks(market, to=to, count=count)

시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

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
api_instance = swagger_client.CandleApi(swagger_client.ApiClient(configuration))
market = 'market_example' # str | 마켓 코드 (ex. KRW-BTC) 
to = 'to_example' # str | 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
count = 8.14 # float | 캔들 개수  (optional)

try:
    # 시세 캔들 조회 (주 단위)
    api_response = api_instance.candle_weeks(market, to=to, count=count)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CandleApi->candle_weeks: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **str**| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **str**| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **float**| 캔들 개수  | [optional] 

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

