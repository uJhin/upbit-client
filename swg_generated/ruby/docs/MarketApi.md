# SwaggerClient::MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**market_info_all**](MarketApi.md#market_info_all) | **GET** /market/all | 마켓 코드 조회


# **market_info_all**
> Object market_info_all(opts)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

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

api_instance = SwaggerClient::MarketApi.new

opts = { 
  is_details: false # BOOLEAN | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터) 
}

begin
  #마켓 코드 조회
  result = api_instance.market_info_all(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MarketApi->market_info_all: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_details** | **BOOLEAN**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



