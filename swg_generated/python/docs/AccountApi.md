# swagger_client.AccountApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**account_info**](AccountApi.md#account_info) | **GET** /accounts | 전체 계좌 조회
[**account_wallet**](AccountApi.md#account_wallet) | **GET** /status/wallet | 입출금 현황


# **account_info**
> list[Account] account_info()

전체 계좌 조회

## 내가 보유한 자산 리스트를 보여줍니다. 

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
api_instance = swagger_client.AccountApi(swagger_client.ApiClient(configuration))

try:
    # 전체 계좌 조회
    api_response = api_instance.account_info()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->account_info: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Account]**](Account.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **account_wallet**
> list[Wallet] account_wallet()

입출금 현황

## 입출금 현황 및 블록 상태를 조회합니다.  **NOTE**: 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다.  입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다. 본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다. 

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
api_instance = swagger_client.AccountApi(swagger_client.ApiClient(configuration))

try:
    # 입출금 현황
    api_response = api_instance.account_wallet()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->account_wallet: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Wallet]**](Wallet.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

