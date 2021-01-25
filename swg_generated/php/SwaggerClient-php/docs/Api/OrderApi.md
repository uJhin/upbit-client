# Swagger\Client\OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderCancel**](OrderApi.md#orderCancel) | **DELETE** /order | 주문 취소 접수
[**orderChance**](OrderApi.md#orderChance) | **GET** /orders/chance | 주문 가능 정보
[**orderInfo**](OrderApi.md#orderInfo) | **GET** /order | 개별 주문 조회
[**orderInfoAll**](OrderApi.md#orderInfoAll) | **GET** /orders | 주문 리스트 조회
[**orderNew**](OrderApi.md#orderNew) | **POST** /orders | 주문하기
[**orderOrderbook**](OrderApi.md#orderOrderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


# **orderCancel**
> \Swagger\Client\Model\Order orderCancel($uuid, $identifier)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 취소할 주문의 UUID
$identifier = "identifier_example"; // string | 조회용 사용자 지정 값

try {
    $result = $apiInstance->orderCancel($uuid, $identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderCancel: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 취소할 주문의 UUID | [optional]
 **identifier** | **string**| 조회용 사용자 지정 값 | [optional]

### Return type

[**\Swagger\Client\Model\Order**](../Model/Order.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **orderChance**
> \Swagger\Client\Model\OrderChance orderChance($market)

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$market = "market_example"; // string | Market ID

try {
    $result = $apiInstance->orderChance($market);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderChance: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Market ID |

### Return type

[**\Swagger\Client\Model\OrderChance**](../Model/OrderChance.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **orderInfo**
> \Swagger\Client\Model\OrderInfo orderInfo($uuid, $identifier)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = "uuid_example"; // string | 주문 UUID
$identifier = "identifier_example"; // string | 조회용 사용자 지정 값

try {
    $result = $apiInstance->orderInfo($uuid, $identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderInfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 주문 UUID | [optional]
 **identifier** | **string**| 조회용 사용자 지정 값 | [optional]

### Return type

[**\Swagger\Client\Model\OrderInfo**](../Model/OrderInfo.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **orderInfoAll**
> \Swagger\Client\Model\Order[] orderInfoAll($market, $state, $states, $uuids, $identifiers, $page, $limit, $order_by)

주문 리스트 조회

## 주문 리스트를 조회한다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$market = "market_example"; // string | 마켓 아이디
$state = "state_example"; // string | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소
$states = array("states_example"); // string[] | 주문 상태의 목록
$uuids = array("uuids_example"); // string[] | 주문 UUID의 목록
$identifiers = array("identifiers_example"); // string[] | 주문 identifier의 목록
$page = 8.14; // float | 페이지 수, default: 1
$limit = 8.14; // float | 요청 개수, default: 100
$order_by = "order_by_example"; // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)

try {
    $result = $apiInstance->orderInfoAll($market, $state, $states, $uuids, $identifiers, $page, $limit, $order_by);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderInfoAll: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 아이디 | [optional]
 **state** | **string**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 | [optional]
 **states** | [**string[]**](../Model/string.md)| 주문 상태의 목록 | [optional]
 **uuids** | [**string[]**](../Model/string.md)| 주문 UUID의 목록 | [optional]
 **identifiers** | [**string[]**](../Model/string.md)| 주문 identifier의 목록 | [optional]
 **page** | **float**| 페이지 수, default: 1 | [optional]
 **limit** | **float**| 요청 개수, default: 100 | [optional]
 **order_by** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) | [optional]

### Return type

[**\Swagger\Client\Model\Order[]**](../Model/Order.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **orderNew**
> \Swagger\Client\Model\NewOrder orderNew($market, $side, $ord_type, $volume, $price, $identifier)

주문하기

## 주문 요청을 한다. **NOTE**: 원화 마켓 가격 단위를 확인하세요. 원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요. **NOTE**: identifier 파라미터 사용 `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다. 주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요. **NOTE**: 시장가 주문 시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$market = "market_example"; // string | 마켓 ID (필수)
$side = "side_example"; // string | 주문 종류 (필수) - bid : 매수 - ask : 매도
$ord_type = "ord_type_example"; // string | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)
$volume = "null"; // string | 주문량 (지정가, 시장가 매도 시 필수)
$price = "null"; // string | 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)
$identifier = "identifier_example"; // string | 조회용 사용자 지정값 (선택)

try {
    $result = $apiInstance->orderNew($market, $side, $ord_type, $volume, $price, $identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderNew: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 ID (필수) |
 **side** | **string**| 주문 종류 (필수) - bid : 매수 - ask : 매도 |
 **ord_type** | **string**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) |
 **volume** | **string**| 주문량 (지정가, 시장가 매도 시 필수) | [optional] [default to null]
 **price** | **string**| 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) | [optional] [default to null]
 **identifier** | **string**| 조회용 사용자 지정값 (선택) | [optional]

### Return type

[**\Swagger\Client\Model\NewOrder**](../Model/NewOrder.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **orderOrderbook**
> \Swagger\Client\Model\Orderbook[] orderOrderbook($markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Bearer
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');

$apiInstance = new Swagger\Client\Api\OrderApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$markets = array("markets_example"); // string[] | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)

try {
    $result = $apiInstance->orderOrderbook($markets);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OrderApi->orderOrderbook: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**string[]**](../Model/string.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) |

### Return type

[**\Swagger\Client\Model\Orderbook[]**](../Model/Orderbook.md)

### Authorization

[Bearer](../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

