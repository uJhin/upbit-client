# Swagger\Client\TradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tradeTicker**](TradeApi.md#tradeTicker) | **GET** /ticker | 시세 Ticker 조회
[**tradeTicks**](TradeApi.md#tradeTicks) | **GET** /trades/ticks | 시세 체결 조회


# **tradeTicker**
> object tradeTicker($markets)

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\TradeApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$markets = "markets_example"; // string | 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)

try {
    $result = $apiInstance->tradeTicker($markets);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TradeApi->tradeTicker: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **string**| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) |

### Return type

**object**

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **tradeTicks**
> object tradeTicks($market, $to, $count, $cursor, $days_ago)

시세 체결 조회

## 최근 체결 내역

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\TradeApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$market = "market_example"; // string | 마켓 코드 (ex. KRW-BTC, BTC-BCC)
$to = "to_example"; // string | 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터
$count = 8.14; // float | 체결 개수
$cursor = "cursor_example"; // string | 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.
$days_ago = 8.14; // float | 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)

try {
    $result = $apiInstance->tradeTicks($market, $to, $count, $cursor, $days_ago);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TradeApi->tradeTicks: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 코드 (ex. KRW-BTC, BTC-BCC) |
 **to** | **string**| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터 | [optional]
 **count** | **float**| 체결 개수 | [optional]
 **cursor** | **string**| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. | [optional]
 **days_ago** | **float**| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) | [optional]

### Return type

**object**

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

