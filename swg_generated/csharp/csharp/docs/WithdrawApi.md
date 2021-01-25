# IO.Swagger.Api.WithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WithdrawChance**](WithdrawApi.md#withdrawchance) | **GET** /withdraws/chance | 출금 가능 정보
[**WithdrawCoin**](WithdrawApi.md#withdrawcoin) | **POST** /withdraws/coin | 코인 출금하기
[**WithdrawInfo**](WithdrawApi.md#withdrawinfo) | **GET** /withdraw | 개별 출금 조회
[**WithdrawInfoAll**](WithdrawApi.md#withdrawinfoall) | **GET** /withdraws | 출금 리스트 조회
[**WithdrawKrw**](WithdrawApi.md#withdrawkrw) | **POST** /withdraws/krw | 원화 출금하기


<a name="withdrawchance"></a>
# **WithdrawChance**
> WithdrawChance WithdrawChance (string currency)

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawChanceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawApi();
            var currency = currency_example;  // string | Currency Symbol 

            try
            {
                // 출금 가능 정보
                WithdrawChance result = apiInstance.WithdrawChance(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawApi.WithdrawChance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency Symbol  | 

### Return type

[**WithdrawChance**](WithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="withdrawcoin"></a>
# **WithdrawCoin**
> WithdrawCoin WithdrawCoin (string currency, string amount, string address, string secondaryAddress = null, string transactionType = null)

코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawCoinExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawApi();
            var currency = currency_example;  // string | Currency 코드 
            var amount = amount_example;  // string | 출금 수량 
            var address = address_example;  // string | 출금 가능 주소에 등록된 출금 주소 
            var secondaryAddress = secondaryAddress_example;  // string | 2차 출금 주소 (필요한 코인에 한해서)  (optional) 
            var transactionType = transactionType_example;  // string | 출금 유형 - default : 일반출금 - internal : 바로출금  (optional) 

            try
            {
                // 코인 출금하기
                WithdrawCoin result = apiInstance.WithdrawCoin(currency, amount, address, secondaryAddress, transactionType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawApi.WithdrawCoin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드  | 
 **amount** | **string**| 출금 수량  | 
 **address** | **string**| 출금 가능 주소에 등록된 출금 주소  | 
 **secondaryAddress** | **string**| 2차 출금 주소 (필요한 코인에 한해서)  | [optional] 
 **transactionType** | **string**| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional] 

### Return type

[**WithdrawCoin**](WithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="withdrawinfo"></a>
# **WithdrawInfo**
> Withdraw WithdrawInfo (string uuid = null, string txid = null, string currency = null)

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawApi();
            var uuid = uuid_example;  // string | 출금 UUID  (optional) 
            var txid = txid_example;  // string | 출금 TXID  (optional) 
            var currency = currency_example;  // string | Currency 코드  (optional) 

            try
            {
                // 개별 출금 조회
                Withdraw result = apiInstance.WithdrawInfo(uuid, txid, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawApi.WithdrawInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 출금 UUID  | [optional] 
 **txid** | **string**| 출금 TXID  | [optional] 
 **currency** | **string**| Currency 코드  | [optional] 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="withdrawinfoall"></a>
# **WithdrawInfoAll**
> List<Withdraw> WithdrawInfoAll (string currency = null, string state = null, List<string> uuids = null, List<string> txids = null, decimal? limit = null, decimal? page = null, string orderBy = null)

출금 리스트 조회

## 출금 리스트를 조회한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawInfoAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawApi();
            var currency = currency_example;  // string | Currency 코드  (optional) 
            var state = state_example;  // string | 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  (optional) 
            var uuids = new List<string>(); // List<string> | 출금 UUID의 목록  (optional) 
            var txids = new List<string>(); // List<string> | 출금 TXID의 목록  (optional) 
            var limit = 8.14;  // decimal? | 개수 제한 (default: 100, max: 100)  (optional) 
            var page = 8.14;  // decimal? | 페이지 수, default: 1  (optional) 
            var orderBy = orderBy_example;  // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional) 

            try
            {
                // 출금 리스트 조회
                List&lt;Withdraw&gt; result = apiInstance.WithdrawInfoAll(currency, state, uuids, txids, limit, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawApi.WithdrawInfoAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency 코드  | [optional] 
 **state** | **string**| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional] 
 **uuids** | [**List&lt;string&gt;**](string.md)| 출금 UUID의 목록  | [optional] 
 **txids** | [**List&lt;string&gt;**](string.md)| 출금 TXID의 목록  | [optional] 
 **limit** | **decimal?**| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **decimal?**| 페이지 수, default: 1  | [optional] 
 **orderBy** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**List<Withdraw>**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="withdrawkrw"></a>
# **WithdrawKrw**
> Withdraw WithdrawKrw (string amount)

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawKrwExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WithdrawApi();
            var amount = amount_example;  // string | 출금 원화 수량 

            try
            {
                // 원화 출금하기
                Withdraw result = apiInstance.WithdrawKrw(amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WithdrawApi.WithdrawKrw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **string**| 출금 원화 수량  | 

### Return type

[**Withdraw**](Withdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

