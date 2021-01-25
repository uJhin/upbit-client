# swagger_client.WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdraw_chance**](WithdrawApi.md#withdraw_chance) | **GET** /withdraws/chance | 출금 가능 정보
[**withdraw_coin**](WithdrawApi.md#withdraw_coin) | **POST** /withdraws/coin | 코인 출금하기
[**withdraw_info**](WithdrawApi.md#withdraw_info) | **GET** /withdraw | 개별 출금 조회
[**withdraw_info_all**](WithdrawApi.md#withdraw_info_all) | **GET** /withdraws | 출금 리스트 조회
[**withdraw_krw**](WithdrawApi.md#withdraw_krw) | **POST** /withdraws/krw | 원화 출금하기


# **withdraw_chance**
> WithdrawChance withdraw_chance(currency)

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

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
api_instance = swagger_client.WithdrawApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency Symbol 

try:
    # 출금 가능 정보
    api_response = api_instance.withdraw_chance(currency)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WithdrawApi->withdraw_chance: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency Symbol  | 

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_coin**
> WithdrawCoin withdraw_coin(currency, amount, address, secondary_address=secondary_address, transaction_type=transaction_type)

코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

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
api_instance = swagger_client.WithdrawApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency 코드 
amount = 'amount_example' # str | 출금 수량 
address = 'address_example' # str | 출금 가능 주소에 등록된 출금 주소 
secondary_address = 'secondary_address_example' # str | 2차 출금 주소 (필요한 코인에 한해서)  (optional)
transaction_type = 'transaction_type_example' # str | 출금 유형 - default : 일반출금 - internal : 바로출금  (optional)

try:
    # 코인 출금하기
    api_response = api_instance.withdraw_coin(currency, amount, address, secondary_address=secondary_address, transaction_type=transaction_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WithdrawApi->withdraw_coin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency 코드  | 
 **amount** | **str**| 출금 수량  | 
 **address** | **str**| 출금 가능 주소에 등록된 출금 주소  | 
 **secondary_address** | **str**| 2차 출금 주소 (필요한 코인에 한해서)  | [optional] 
 **transaction_type** | **str**| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional] 

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_info**
> Withdraw withdraw_info(uuid=uuid, txid=txid, currency=currency)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

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
api_instance = swagger_client.WithdrawApi(swagger_client.ApiClient(configuration))
uuid = 'uuid_example' # str | 출금 UUID  (optional)
txid = 'txid_example' # str | 출금 TXID  (optional)
currency = 'currency_example' # str | Currency 코드  (optional)

try:
    # 개별 출금 조회
    api_response = api_instance.withdraw_info(uuid=uuid, txid=txid, currency=currency)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WithdrawApi->withdraw_info: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **str**| 출금 UUID  | [optional] 
 **txid** | **str**| 출금 TXID  | [optional] 
 **currency** | **str**| Currency 코드  | [optional] 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_info_all**
> list[Withdraw] withdraw_info_all(currency=currency, state=state, uuids=uuids, txids=txids, limit=limit, page=page, order_by=order_by)

출금 리스트 조회

## 출금 리스트를 조회한다. 

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
api_instance = swagger_client.WithdrawApi(swagger_client.ApiClient(configuration))
currency = 'currency_example' # str | Currency 코드  (optional)
state = 'state_example' # str | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  (optional)
uuids = ['uuids_example'] # list[str] | 출금 UUID의 목록  (optional)
txids = ['txids_example'] # list[str] | 출금 TXID의 목록  (optional)
limit = 8.14 # float | 개수 제한 (default: 100, max: 100)  (optional)
page = 8.14 # float | 페이지 수, default: 1  (optional)
order_by = 'order_by_example' # str | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

try:
    # 출금 리스트 조회
    api_response = api_instance.withdraw_info_all(currency=currency, state=state, uuids=uuids, txids=txids, limit=limit, page=page, order_by=order_by)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WithdrawApi->withdraw_info_all: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **str**| Currency 코드  | [optional] 
 **state** | **str**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional] 
 **uuids** | [**list[str]**](str.md)| 출금 UUID의 목록  | [optional] 
 **txids** | [**list[str]**](str.md)| 출금 TXID의 목록  | [optional] 
 **limit** | **float**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **float**| 페이지 수, default: 1  | [optional] 
 **order_by** | **str**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**list[Withdraw]**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdraw_krw**
> Withdraw withdraw_krw(amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

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
api_instance = swagger_client.WithdrawApi(swagger_client.ApiClient(configuration))
amount = 'amount_example' # str | 출금 원화 수량 

try:
    # 원화 출금하기
    api_response = api_instance.withdraw_krw(amount)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WithdrawApi->withdraw_krw: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **str**| 출금 원화 수량  | 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

