# IO.Swagger.Api.MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarketInfoAll**](MarketApi.md#marketinfoall) | **GET** /market/all | 마켓 코드 조회


<a name="marketinfoall"></a>
# **MarketInfoAll**
> Object MarketInfoAll (bool? isDetails = null)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MarketInfoAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MarketApi();
            var isDetails = true;  // bool? | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  (optional)  (default to false)

            try
            {
                // 마켓 코드 조회
                Object result = apiInstance.MarketInfoAll(isDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.MarketInfoAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **bool?**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

