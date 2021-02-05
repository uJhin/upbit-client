# swagger_client.DepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deposit_coin_address**](DepositApi.md#deposit_coin_address) | **GET** /deposits/coin_address | 개별 입금 주소 조회
[**deposit_coin_addresses**](DepositApi.md#deposit_coin_addresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
[**deposit_generate_coin_address**](DepositApi.md#deposit_generate_coin_address) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
[**deposit_info**](DepositApi.md#deposit_info) | **GET** /deposit | 개별 입금 조회
[**deposit_info_all**](DepositApi.md#deposit_info_all) | **GET** /deposits | 입금 리스트 조회


# **deposit_coin_address**
> DepositCompleteResponse deposit_coin_address(currency)

개별 입금 주소 조회

## 개별 입금 주소 조회  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

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
api_instance = swagger_client.DepositApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency symbol 

try:
    # 개별 입금 주소 조회
    api_response = api_instance.deposit_coin_address(currency)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepositApi->deposit_coin_address: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency symbol  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_coin_addresses**
> object deposit_coin_addresses()

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다.  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

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
api_instance = swagger_client.DepositApi(swagger_client.ApiClient(configuration))

try:
    # 전체 입금 주소 조회
    api_response = api_instance.deposit_coin_addresses()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepositApi->deposit_coin_addresses: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_generate_coin_address**
> DepositCompleteResponse deposit_generate_coin_address(currency)

입금 주소 생성 요청

입금 주소 생성을 요청한다.  **NOTE**: 입금 주소 생성 요청 API 유의사항  입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

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
api_instance = swagger_client.DepositApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency 코드 

try:
    # 입금 주소 생성 요청
    api_response = api_instance.deposit_generate_coin_address(currency)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepositApi->deposit_generate_coin_address: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency 코드  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_info**
> Deposit deposit_info(uuid=uuid, txid=txid, currency=currency)

개별 입금 조회

## 개별 입금 조회 

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
api_instance = swagger_client.DepositApi(swagger_client.ApiClient(configuration))
uuid = 'uuid_example' # str | 입금 UUID  (optional)
txid = 'txid_example' # str | 입금 TXID  (optional)
currency = 'currency_example' # str | Currency 코드  (optional)

try:
    # 개별 입금 조회
    api_response = api_instance.deposit_info(uuid=uuid, txid=txid, currency=currency)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepositApi->deposit_info: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **str**| 입금 UUID  | [optional] 
 **txid** | **str**| 입금 TXID  | [optional] 
 **currency** | **str**| Currency 코드  | [optional] 

### Return type

[**Deposit**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deposit_info_all**
> list[Deposit] deposit_info_all(currency=currency, state=state, uuids=uuids, txids=txids, limit=limit, page=page, order_by=order_by)

입금 리스트 조회

## 입금 리스트 조회 

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
api_instance = swagger_client.DepositApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency 코드  (optional)
state = 'state_example' # str | 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  (optional)
uuids = ['uuids_example'] # list[str] | 입금 UUID의 목록  (optional)
txids = ['txids_example'] # list[str] | 입금 TXID의 목록  (optional)
limit = 8.14 # float | 개수 제한 (default: 100, max: 100)  (optional)
page = 8.14 # float | 페이지 수, default: 1  (optional)
order_by = 'order_by_example' # str | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

try:
    # 입금 리스트 조회
    api_response = api_instance.deposit_info_all(currency=currency, state=state, uuids=uuids, txids=txids, limit=limit, page=page, order_by=order_by)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepositApi->deposit_info_all: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency 코드  | [optional] 
 **state** | **str**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | [optional] 
 **uuids** | [**list[str]**](str.md)| 입금 UUID의 목록  | [optional] 
 **txids** | [**list[str]**](str.md)| 입금 TXID의 목록  | [optional] 
 **limit** | **float**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **float**| 페이지 수, default: 1  | [optional] 
 **order_by** | **str**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**list[Deposit]**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

