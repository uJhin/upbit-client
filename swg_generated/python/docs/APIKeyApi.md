# swagger_client.APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**a_pi_key_info**](APIKeyApi.md#a_pi_key_info) | **GET** /api_keys | API 키 리스트 조회


# **a_pi_key_info**
> list[APIKey] a_pi_key_info()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

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
api_instance = swagger_client.APIKeyApi(swagger_client.ApiClient(configuration))

try:
    # API 키 리스트 조회
    api_response = api_instance.a_pi_key_info()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling APIKeyApi->a_pi_key_info: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[APIKey]**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

