# AccountApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountInfo**](AccountApi.md#accountInfo) | **GET** /accounts | 전체 계좌 조회
[**accountWallet**](AccountApi.md#accountWallet) | **GET** /status/wallet | 입출금 현황


<a name="accountInfo"></a>
# **accountInfo**
> List&lt;Account&gt; accountInfo()

전체 계좌 조회

## 내가 보유한 자산 리스트를 보여줍니다. 

### Example
```java
// Import classes:
//import io.swagger.client.api.AccountApi;

AccountApi apiInstance = new AccountApi();
try {
    List<Account> result = apiInstance.accountInfo();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountApi#accountInfo");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Account&gt;**](Account.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="accountWallet"></a>
# **accountWallet**
> List&lt;Wallet&gt; accountWallet()

입출금 현황

## 입출금 현황 및 블록 상태를 조회합니다.  **NOTE**: 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다.  입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다. 본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다. 

### Example
```java
// Import classes:
//import io.swagger.client.api.AccountApi;

AccountApi apiInstance = new AccountApi();
try {
    List<Wallet> result = apiInstance.accountWallet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountApi#accountWallet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Wallet&gt;**](Wallet.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

