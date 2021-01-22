# Swagger\Client\MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**marketInfoAll**](MarketApi.md#marketInfoAll) | **GET** /market/all | 마켓 코드 조회


# **marketInfoAll**
> object marketInfoAll($is_details)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\MarketApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$is_details = false; // bool | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)

try {
    $result = $apiInstance->marketInfoAll($is_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MarketApi->marketInfoAll: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_details** | **bool**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터) | [optional] [default to false]

### Return type

**object**

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

