# SwaggerClient::TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**trade_ticker**](TradeApi.md#trade_ticker) | **GET** /ticker | 시세 Ticker 조회
[**trade_ticks**](TradeApi.md#trade_ticks) | **GET** /trades/ticks | 시세 체결 조회


# **trade_ticker**
> Object trade_ticker(markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

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

api_instance = SwaggerClient::TradeApi.new

markets = 'markets_example' # String | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 


begin
  #시세 Ticker 조회
  result = api_instance.trade_ticker(markets)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TradeApi->trade_ticker: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **String**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **trade_ticks**
> Object trade_ticks(market, opts)

시세 체결 조회

## 최근 체결 내역 

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

api_instance = SwaggerClient::TradeApi.new

market = 'market_example' # String | 마켓 코드 (ex. KRW-BTC, BTC-BCC) 

opts = { 
  to: 'to_example', # String | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터 
  count: 8.14, # Float | 체결 개수 
  cursor: 'cursor_example', # String | 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. 
  days_ago: 8.14 # Float | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) 
}

begin
  #시세 체결 조회
  result = api_instance.trade_ticks(market, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TradeApi->trade_ticks: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **String**| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **String**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional] 
 **count** | **Float**| 체결 개수  | [optional] 
 **cursor** | **String**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 
 **days_ago** | **Float**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional] 

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



