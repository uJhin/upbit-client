# swagger_client.MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**market_info_all**](MarketApi.md#market_info_all) | **GET** /market/all | 마켓 코드 조회


# **market_info_all**
> object market_info_all(is_details=is_details)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

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
api_instance = swagger_client.MarketApi(swagger_client.ApiClient(configuration))
is_details = false # bool | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  (optional) (default to false)

try:
    # 마켓 코드 조회
    api_response = api_instance.market_info_all(is_details=is_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MarketApi->market_info_all: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_details** | **bool**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

