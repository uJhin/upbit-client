# IO.Swagger.Api.APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**APIKeyInfo**](APIKeyApi.md#apikeyinfo) | **GET** /api_keys | API 키 리스트 조회


<a name="apikeyinfo"></a>
# **APIKeyInfo**
> List<APIKey> APIKeyInfo ()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIKeyInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new APIKeyApi();

            try
            {
                // API 키 리스트 조회
                List&lt;APIKey&gt; result = apiInstance.APIKeyInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.APIKeyInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<APIKey>**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

