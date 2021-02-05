# Swagger\Client\WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdrawChance**](WithdrawApi.md#withdrawChance) | **GET** /withdraws/chance | 출금 가능 정보
[**withdrawCoin**](WithdrawApi.md#withdrawCoin) | **POST** /withdraws/coin | 코인 출금하기
[**withdrawInfo**](WithdrawApi.md#withdrawInfo) | **GET** /withdraw | 개별 출금 조회
[**withdrawInfoAll**](WithdrawApi.md#withdrawInfoAll) | **GET** /withdraws | 출금 리스트 조회
[**withdrawKrw**](WithdrawApi.md#withdrawKrw) | **POST** /withdraws/krw | 원화 출금하기


# **withdrawChance**
> \Swagger\Client\Model\WithdrawChance withdrawChance($currency)

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\WithdrawApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency Symbol

try {
    $result = $apiInstance->withdrawChance($currency);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling WithdrawApi->withdrawChance: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency Symbol |

### Return type

[**\Swagger\Client\Model\WithdrawChance**](../Model/WithdrawChance.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **withdrawCoin**
> \Swagger\Client\Model\WithdrawCoin withdrawCoin($currency, $amount, $address, $secondary_address, $transaction_type)

코인 출금하기

## 코인 출금을 요청한다.  **NOTE**: 바로출금 이용 시 유의사항  업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\WithdrawApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency 코드
$amount = "amount_example"; // string | 출금 수량
$address = "address_example"; // string | 출금 가능 주소에 등록된 출금 주소
$secondary_address = "secondary_address_example"; // string | 2차 출금 주소 (필요한 코인에 한해서)
$transaction_type = "transaction_type_example"; // string | 출금 유형 - default : 일반출금 - internal : 바로출금

try {
    $result = $apiInstance->withdrawCoin($currency, $amount, $address, $secondary_address, $transaction_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling WithdrawApi->withdrawCoin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드 |
 **amount** | **string**| 출금 수량 |
 **address** | **string**| 출금 가능 주소에 등록된 출금 주소 |
 **secondary_address** | **string**| 2차 출금 주소 (필요한 코인에 한해서) | [optional]
 **transaction_type** | **string**| 출금 유형 - default : 일반출금 - internal : 바로출금 | [optional]

### Return type

[**\Swagger\Client\Model\WithdrawCoin**](../Model/WithdrawCoin.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **withdrawInfo**
> \Swagger\Client\Model\Withdraw withdrawInfo($uuid, $txid, $currency)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\WithdrawApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 출금 UUID
$txid = "txid_example"; // string | 출금 TXID
$currency = "currency_example"; // string | Currency 코드

try {
    $result = $apiInstance->withdrawInfo($uuid, $txid, $currency);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling WithdrawApi->withdrawInfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 출금 UUID | [optional]
 **txid** | **string**| 출금 TXID | [optional]
 **currency** | **string**| Currency 코드 | [optional]

### Return type

[**\Swagger\Client\Model\Withdraw**](../Model/Withdraw.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **withdrawInfoAll**
> \Swagger\Client\Model\Withdraw[] withdrawInfoAll($currency, $state, $uuids, $txids, $limit, $page, $order_by)

출금 리스트 조회

## 출금 리스트를 조회한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\WithdrawApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currency = "currency_example"; // string | Currency 코드
$state = "state_example"; // string | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨
$uuids = array("uuids_example"); // string[] | 출금 UUID의 목록
$txids = array("txids_example"); // string[] | 출금 TXID의 목록
$limit = 8.14; // float | 개수 제한 (default: 100, max: 100)
$page = 8.14; // float | 페이지 수, default: 1
$order_by = "order_by_example"; // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)

try {
    $result = $apiInstance->withdrawInfoAll($currency, $state, $uuids, $txids, $limit, $page, $order_by);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling WithdrawApi->withdrawInfoAll: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드 | [optional]
 **state** | **string**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 | [optional]
 **uuids** | [**string[]**](../Model/string.md)| 출금 UUID의 목록 | [optional]
 **txids** | [**string[]**](../Model/string.md)| 출금 TXID의 목록 | [optional]
 **limit** | **float**| 개수 제한 (default: 100, max: 100) | [optional]
 **page** | **float**| 페이지 수, default: 1 | [optional]
 **order_by** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) | [optional]

### Return type

[**\Swagger\Client\Model\Withdraw[]**](../Model/Withdraw.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **withdrawKrw**
> \Swagger\Client\Model\Withdraw withdrawKrw($amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\WithdrawApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$amount = "amount_example"; // string | 출금 원화 수량

try {
    $result = $apiInstance->withdrawKrw($amount);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling WithdrawApi->withdrawKrw: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **string**| 출금 원화 수량 |

### Return type

[**\Swagger\Client\Model\Withdraw**](../Model/Withdraw.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

