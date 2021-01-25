# SwaggerClient::WithdrawApi

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

api_instance = SwaggerClient::WithdrawApi.new

currency = 'currency_example' # String | Currency Symbol 


begin
  #출금 가능 정보
  result = api_instance.withdraw_chance(currency)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling WithdrawApi->withdraw_chance: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency Symbol  | 

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **withdraw_coin**
> WithdrawCoin withdraw_coin(currency, amount, address, opts)

코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

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

api_instance = SwaggerClient::WithdrawApi.new

currency = 'currency_example' # String | Currency 코드 

amount = 'amount_example' # String | 출금 수량 

address = 'address_example' # String | 출금 가능 주소에 등록된 출금 주소 

opts = { 
  secondary_address: 'secondary_address_example', # String | 2차 출금 주소 (필요한 코인에 한해서) 
  transaction_type: 'transaction_type_example' # String | 출금 유형 - default : 일반출금 - internal : 바로출금 
}

begin
  #코인 출금하기
  result = api_instance.withdraw_coin(currency, amount, address, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling WithdrawApi->withdraw_coin: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | 
 **amount** | **String**| 출금 수량  | 
 **address** | **String**| 출금 가능 주소에 등록된 출금 주소  | 
 **secondary_address** | **String**| 2차 출금 주소 (필요한 코인에 한해서)  | [optional] 
 **transaction_type** | **String**| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional] 

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json



# **withdraw_info**
> Withdraw withdraw_info(opts)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

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

api_instance = SwaggerClient::WithdrawApi.new

opts = { 
  uuid: 'uuid_example', # String | 출금 UUID 
  txid: 'txid_example', # String | 출금 TXID 
  currency: 'currency_example' # String | Currency 코드 
}

begin
  #개별 출금 조회
  result = api_instance.withdraw_info(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling WithdrawApi->withdraw_info: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 출금 UUID  | [optional] 
 **txid** | **String**| 출금 TXID  | [optional] 
 **currency** | **String**| Currency 코드  | [optional] 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **withdraw_info_all**
> Array&lt;Withdraw&gt; withdraw_info_all(opts)

출금 리스트 조회

## 출금 리스트를 조회한다. 

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

api_instance = SwaggerClient::WithdrawApi.new

opts = { 
  currency: 'currency_example', # String | Currency 코드 
  state: 'state_example', # String | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 
  uuids: ['uuids_example'], # Array<String> | 출금 UUID의 목록 
  txids: ['txids_example'], # Array<String> | 출금 TXID의 목록 
  limit: 8.14, # Float | 개수 제한 (default: 100, max: 100) 
  page: 8.14, # Float | 페이지 수, default: 1 
  order_by: 'order_by_example' # String | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) 
}

begin
  #출금 리스트 조회
  result = api_instance.withdraw_info_all(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling WithdrawApi->withdraw_info_all: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency 코드  | [optional] 
 **state** | **String**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional] 
 **uuids** | [**Array&lt;String&gt;**](String.md)| 출금 UUID의 목록  | [optional] 
 **txids** | [**Array&lt;String&gt;**](String.md)| 출금 TXID의 목록  | [optional] 
 **limit** | **Float**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **Float**| 페이지 수, default: 1  | [optional] 
 **order_by** | **String**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**Array&lt;Withdraw&gt;**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **withdraw_krw**
> Withdraw withdraw_krw(amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

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

api_instance = SwaggerClient::WithdrawApi.new

amount = 'amount_example' # String | 출금 원화 수량 


begin
  #원화 출금하기
  result = api_instance.withdraw_krw(amount)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling WithdrawApi->withdraw_krw: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **String**| 출금 원화 수량  | 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json



