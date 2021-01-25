# SwaggerClient::DepositApi

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

## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: Bearer
  config.api_key['Authorization'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['Authorization'] = 'Bearer'
end

api_instance = SwaggerClient::DepositApi.new

currency = 'currency_example' # String | Currency symbol 


begin
  #개별 입금 주소 조회
  result = api_instance.deposit_coin_address(currency)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DepositApi->deposit_coin_address: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency symbol  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **deposit_coin_addresses**
> Object deposit_coin_addresses

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: Bearer
  config.api_key['Authorization'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['Authorization'] = 'Bearer'
end

api_instance = SwaggerClient::DepositApi.new

begin
  #전체 입금 주소 조회
  result = api_instance.deposit_coin_addresses
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DepositApi->deposit_coin_addresses: #{e}"
end
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **deposit_generate_coin_address**
> DepositCompleteResponse deposit_generate_coin_address(currency)

입금 주소 생성 요청

입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: Bearer
  config.api_key['Authorization'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['Authorization'] = 'Bearer'
end

api_instance = SwaggerClient::DepositApi.new

currency = 'currency_example' # String | Currency 코드 


begin
  #입금 주소 생성 요청
  result = api_instance.deposit_generate_coin_address(currency)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DepositApi->deposit_generate_coin_address: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json



# **deposit_info**
> Deposit deposit_info(opts)

개별 입금 조회

## 개별 입금 조회 

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: Bearer
  config.api_key['Authorization'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['Authorization'] = 'Bearer'
end

api_instance = SwaggerClient::DepositApi.new

opts = { 
  uuid: 'uuid_example', # String | 입금 UUID 
  txid: 'txid_example', # String | 입금 TXID 
  currency: 'currency_example' # String | Currency 코드 
}

begin
  #개별 입금 조회
  result = api_instance.deposit_info(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DepositApi->deposit_info: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 입금 UUID  | [optional] 
 **txid** | **String**| 입금 TXID  | [optional] 
 **currency** | **String**| Currency 코드  | [optional] 

### Return type

[**Deposit**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **deposit_info_all**
> Array&lt;Deposit&gt; deposit_info_all(opts)

입금 리스트 조회

## 입금 리스트 조회 

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: Bearer
  config.api_key['Authorization'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['Authorization'] = 'Bearer'
end

api_instance = SwaggerClient::DepositApi.new

opts = { 
  currency: 'currency_example', # String | Currency 코드 
  state: 'state_example', # String | 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중 
  uuids: ['uuids_example'], # Array<String> | 입금 UUID의 목록 
  txids: ['txids_example'], # Array<String> | 입금 TXID의 목록 
  limit: 8.14, # Float | 개수 제한 (default: 100, max: 100) 
  page: 8.14, # Float | 페이지 수, default: 1 
  order_by: 'order_by_example' # String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
}

begin
  #입금 리스트 조회
  result = api_instance.deposit_info_all(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DepositApi->deposit_info_all: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | [optional] 
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | [optional] 
 **uuids** | [**Array&lt;String&gt;**](String.md)| 입금 UUID의 목록  | [optional] 
 **txids** | [**Array&lt;String&gt;**](String.md)| 입금 TXID의 목록  | [optional] 
 **limit** | **Float**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **Float**| 페이지 수, default: 1  | [optional] 
 **order_by** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**Array&lt;Deposit&gt;**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



