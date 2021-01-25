# Swagger\Client\DepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**depositCoinAddress**](DepositApi.md#depositCoinAddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
[**depositCoinAddresses**](DepositApi.md#depositCoinAddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
[**depositGenerateCoinAddress**](DepositApi.md#depositGenerateCoinAddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
[**depositInfo**](DepositApi.md#depositInfo) | **GET** /deposit | 개별 입금 조회
[**depositInfoAll**](DepositApi.md#depositInfoAll) | **GET** /deposits | 입금 리스트 조회


# **depositCoinAddress**
> \Swagger\Client\Model\DepositCompleteResponse depositCoinAddress($currency)

개별 입금 주소 조회

## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\DepositApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency symbol

try {
    $result = $apiInstance->depositCoinAddress($currency);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DepositApi->depositCoinAddress: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency symbol |

### Return type

[**\Swagger\Client\Model\DepositCompleteResponse**](../Model/DepositCompleteResponse.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **depositCoinAddresses**
> object depositCoinAddresses()

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\DepositApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->depositCoinAddresses();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DepositApi->depositCoinAddresses: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **depositGenerateCoinAddress**
> \Swagger\Client\Model\DepositCompleteResponse depositGenerateCoinAddress($currency)

입금 주소 생성 요청

입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\DepositApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency 코드

try {
    $result = $apiInstance->depositGenerateCoinAddress($currency);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DepositApi->depositGenerateCoinAddress: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드 |

### Return type

[**\Swagger\Client\Model\DepositCompleteResponse**](../Model/DepositCompleteResponse.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **depositInfo**
> \Swagger\Client\Model\Deposit depositInfo($uuid, $txid, $currency)

개별 입금 조회

## 개별 입금 조회

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\DepositApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 입금 UUID
$txid = "txid_example"; // string | 입금 TXID
$currency = "currency_example"; // string | Currency 코드

try {
    $result = $apiInstance->depositInfo($uuid, $txid, $currency);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DepositApi->depositInfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 입금 UUID | [optional]
 **txid** | **string**| 입금 TXID | [optional]
 **currency** | **string**| Currency 코드 | [optional]

### Return type

[**\Swagger\Client\Model\Deposit**](../Model/Deposit.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **depositInfoAll**
> \Swagger\Client\Model\Deposit[] depositInfoAll($currency, $state, $uuids, $txids, $limit, $page, $order_by)

입금 리스트 조회

## 입금 리스트 조회

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\DepositApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency 코드
$state = "state_example"; // string | 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중
$uuids = array("uuids_example"); // string[] | 입금 UUID의 목록
$txids = array("txids_example"); // string[] | 입금 TXID의 목록
$limit = 8.14; // float | 개수 제한 (default: 100, max: 100)
$page = 8.14; // float | 페이지 수, default: 1
$order_by = "order_by_example"; // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)

try {
    $result = $apiInstance->depositInfoAll($currency, $state, $uuids, $txids, $limit, $page, $order_by);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DepositApi->depositInfoAll: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드 | [optional]
 **state** | **string**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중 | [optional]
 **uuids** | [**string[]**](../Model/string.md)| 입금 UUID의 목록 | [optional]
 **txids** | [**string[]**](../Model/string.md)| 입금 TXID의 목록 | [optional]
 **limit** | **float**| 개수 제한 (default: 100, max: 100) | [optional]
 **page** | **float**| 페이지 수, default: 1 | [optional]
 **order_by** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) | [optional]

### Return type

[**\Swagger\Client\Model\Deposit[]**](../Model/Deposit.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

