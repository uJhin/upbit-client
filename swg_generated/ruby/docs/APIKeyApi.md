# SwaggerClient::APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**a_pi_key_info**](APIKeyApi.md#a_pi_key_info) | **GET** /api_keys | API 키 리스트 조회


# **a_pi_key_info**
> Array&lt;APIKey&gt; a_pi_key_info

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

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

api_instance = SwaggerClient::APIKeyApi.new

begin
  #API 키 리스트 조회
  result = api_instance.a_pi_key_info
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling APIKeyApi->a_pi_key_info: #{e}"
end
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Array&lt;APIKey&gt;**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



