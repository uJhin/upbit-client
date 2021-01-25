# APIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**aPIKeyInfo**](APIKeyApi.md#aPIKeyInfo) | **GET** /api_keys | API 키 리스트 조회


<a name="aPIKeyInfo"></a>
# **aPIKeyInfo**
> List&lt;APIKey&gt; aPIKeyInfo()

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example
```java
// Import classes:
//import io.swagger.client.api.APIKeyApi;

APIKeyApi apiInstance = new APIKeyApi();
try {
    List<APIKey> result = apiInstance.aPIKeyInfo();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling APIKeyApi#aPIKeyInfo");
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

