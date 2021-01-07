# IO.Swagger.Api.DepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DepositCoinAddress**](DepositApi.md#depositcoinaddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
[**DepositCoinAddresses**](DepositApi.md#depositcoinaddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
[**DepositGenerateCoinAddress**](DepositApi.md#depositgeneratecoinaddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
[**DepositInfo**](DepositApi.md#depositinfo) | **GET** /deposit | 개별 입금 조회
[**DepositInfoAll**](DepositApi.md#depositinfoall) | **GET** /deposits | 입금 리스트 조회


<a name="depositcoinaddress"></a>
# **DepositCoinAddress**
> DepositCompleteResponse DepositCoinAddress (string currency)

개별 입금 주소 조회

## 개별 입금 주소 조회  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositCoinAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositApi();
            var currency = currency_example;  // string | Currency symbol 

            try
            {
                // 개별 입금 주소 조회
                DepositCompleteResponse result = apiInstance.DepositCoinAddress(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositApi.DepositCoinAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency symbol  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositcoinaddresses"></a>
# **DepositCoinAddresses**
> Object DepositCoinAddresses ()

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다.  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositCoinAddressesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositApi();

            try
            {
                // 전체 입금 주소 조회
                Object result = apiInstance.DepositCoinAddresses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositApi.DepositCoinAddresses: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositgeneratecoinaddress"></a>
# **DepositGenerateCoinAddress**
> DepositCompleteResponse DepositGenerateCoinAddress (string currency)

입금 주소 생성 요청

입금 주소 생성을 요청한다.  **NOTE**: 입금 주소 생성 요청 API 유의사항  입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositGenerateCoinAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositApi();
            var currency = currency_example;  // string | Currency 코드 

            try
            {
                // 입금 주소 생성 요청
                DepositCompleteResponse result = apiInstance.DepositGenerateCoinAddress(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositApi.DepositGenerateCoinAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드  | 

### Return type

[**DepositCompleteResponse**](DepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositinfo"></a>
# **DepositInfo**
> Deposit DepositInfo (string uuid = null, string txid = null, string currency = null)

개별 입금 조회

## 개별 입금 조회 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositApi();
            var uuid = uuid_example;  // string | 입금 UUID  (optional) 
            var txid = txid_example;  // string | 입금 TXID  (optional) 
            var currency = currency_example;  // string | Currency 코드  (optional) 

            try
            {
                // 개별 입금 조회
                Deposit result = apiInstance.DepositInfo(uuid, txid, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositApi.DepositInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 입금 UUID  | [optional] 
 **txid** | **string**| 입금 TXID  | [optional] 
 **currency** | **string**| Currency 코드  | [optional] 

### Return type

[**Deposit**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="depositinfoall"></a>
# **DepositInfoAll**
> List<Deposit> DepositInfoAll (string currency = null, string state = null, List<string> uuids = null, List<string> txids = null, decimal? limit = null, decimal? page = null, string orderBy = null)

입금 리스트 조회

## 입금 리스트 조회 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DepositInfoAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepositApi();
            var currency = currency_example;  // string | Currency 코드  (optional) 
            var state = state_example;  // string | 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  (optional) 
            var uuids = new List<string>(); // List<string> | 입금 UUID의 목록  (optional) 
            var txids = new List<string>(); // List<string> | 입금 TXID의 목록  (optional) 
            var limit = 8.14;  // decimal? | 개수 제한 (default: 100, max: 100)  (optional) 
            var page = 8.14;  // decimal? | 페이지 수, default: 1  (optional) 
            var orderBy = orderBy_example;  // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional) 

            try
            {
                // 입금 리스트 조회
                List&lt;Deposit&gt; result = apiInstance.DepositInfoAll(currency, state, uuids, txids, limit, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepositApi.DepositInfoAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드  | [optional] 
 **state** | **string**| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | [optional] 
 **uuids** | [**List&lt;string&gt;**](string.md)| 입금 UUID의 목록  | [optional] 
 **txids** | [**List&lt;string&gt;**](string.md)| 입금 TXID의 목록  | [optional] 
 **limit** | **decimal?**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **decimal?**| 페이지 수, default: 1  | [optional] 
 **orderBy** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**List<Deposit>**](Deposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

