# ApiKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**aPIKeyInfo**](ApiKeyApi.md#aPIKeyInfo) | **GET** /api_keys | API 키 리스트 조회


<a name="aPIKeyInfo"></a>
# **aPIKeyInfo**
> List&lt;APIKey&gt; aPIKeyInfo()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: Bearer
ApiKeyAuth Bearer = (ApiKeyAuth) defaultClient.getAuthentication("Bearer");
Bearer.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//Bearer.setApiKeyPrefix("Token");

ApiKeyApi apiInstance = new ApiKeyApi();
try {
    List<APIKey> result = apiInstance.aPIKeyInfo();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeyApi#aPIKeyInfo");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;APIKey&gt;**](APIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

