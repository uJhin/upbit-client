# SWGMarketApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**marketInfoAll**](SWGMarketApi.md#marketinfoall) | **GET** /market/all | 마켓 코드 조회


# **marketInfoAll**
```objc
-(NSURLSessionTask*) marketInfoAllWithIsDetails: (NSNumber*) isDetails
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

마켓 코드 조회

## 업비트에서 거래 가능한 마켓 목록 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSNumber* isDetails = @false; // 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  (optional) (default to false)

SWGMarketApi*apiInstance = [[SWGMarketApi alloc] init];

// 마켓 코드 조회
[apiInstance marketInfoAllWithIsDetails:isDetails
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGMarketApi->marketInfoAll: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDetails** | **NSNumber***| 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)  | [optional] [default to false]

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

