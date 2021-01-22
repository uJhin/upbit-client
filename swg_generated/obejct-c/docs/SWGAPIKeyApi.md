# SWGAPIKeyApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**aPIKeyInfo**](SWGAPIKeyApi.md#apikeyinfo) | **GET** /api_keys | API 키 리스트 조회


# **aPIKeyInfo**
```objc
-(NSURLSessionTask*) aPIKeyInfoWithCompletionHandler: 
        (void (^)(NSArray<SWGAPIKey>* output, NSError* error)) handler;
```

API 키 리스트 조회

## API 키 목록 및 만료 일자를 조회합니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];



SWGAPIKeyApi*apiInstance = [[SWGAPIKeyApi alloc] init];

// API 키 리스트 조회
[apiInstance aPIKeyInfoWithCompletionHandler: 
          ^(NSArray<SWGAPIKey>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGAPIKeyApi->aPIKeyInfo: %@", error);
                        }
                    }];
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NSArray<SWGAPIKey>***](SWGAPIKey.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

