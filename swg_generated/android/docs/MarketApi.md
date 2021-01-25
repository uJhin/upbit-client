# MarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**marketInfoAll**](MarketApi.md#marketInfoAll) | **GET** /market/all | 마켓 코드 조회


<a name="marketInfoAll"></a>
# **marketInfoAll**
> Object marketInfoAll(isDetails)

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Example
```java
// Import classes:
//import io.swagger.client.api.MarketApi;

MarketApi apiInstance = new MarketApi();
Boolean isDetails = false; // Boolean | 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터) 
try {
    Object result = apiInstance.marketInfoAll(isDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MarketApi#marketInfoAll");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **Boolean**| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

