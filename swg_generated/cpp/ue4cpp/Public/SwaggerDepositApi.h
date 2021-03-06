/**
 * Upbit Open API
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: ujhin942@gmail.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
#pragma once

#include "CoreMinimal.h"
#include "SwaggerBaseModel.h"

namespace Swagger 
{

class SWAGGER_API SwaggerDepositApi
{
public:
	SwaggerDepositApi();
	~SwaggerDepositApi();

	void SetURL(const FString& Url);
	void AddHeaderParam(const FString& Key, const FString& Value);
	void ClearHeaderParams();

	class DepositCoinAddressRequest;
	class DepositCoinAddressResponse;
	class DepositCoinAddressesRequest;
	class DepositCoinAddressesResponse;
	class DepositGenerateCoinAddressRequest;
	class DepositGenerateCoinAddressResponse;
	class DepositInfoRequest;
	class DepositInfoResponse;
	class DepositInfoAllRequest;
	class DepositInfoAllResponse;
	
    DECLARE_DELEGATE_OneParam(FDepositCoinAddressDelegate, const DepositCoinAddressResponse&);
    DECLARE_DELEGATE_OneParam(FDepositCoinAddressesDelegate, const DepositCoinAddressesResponse&);
    DECLARE_DELEGATE_OneParam(FDepositGenerateCoinAddressDelegate, const DepositGenerateCoinAddressResponse&);
    DECLARE_DELEGATE_OneParam(FDepositInfoDelegate, const DepositInfoResponse&);
    DECLARE_DELEGATE_OneParam(FDepositInfoAllDelegate, const DepositInfoAllResponse&);
    
    bool DepositCoinAddress(const DepositCoinAddressRequest& Request, const FDepositCoinAddressDelegate& Delegate = FDepositCoinAddressDelegate()) const;
    bool DepositCoinAddresses(const DepositCoinAddressesRequest& Request, const FDepositCoinAddressesDelegate& Delegate = FDepositCoinAddressesDelegate()) const;
    bool DepositGenerateCoinAddress(const DepositGenerateCoinAddressRequest& Request, const FDepositGenerateCoinAddressDelegate& Delegate = FDepositGenerateCoinAddressDelegate()) const;
    bool DepositInfo(const DepositInfoRequest& Request, const FDepositInfoDelegate& Delegate = FDepositInfoDelegate()) const;
    bool DepositInfoAll(const DepositInfoAllRequest& Request, const FDepositInfoAllDelegate& Delegate = FDepositInfoAllDelegate()) const;
    
private:
    void OnDepositCoinAddressResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FDepositCoinAddressDelegate Delegate) const;
    void OnDepositCoinAddressesResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FDepositCoinAddressesDelegate Delegate) const;
    void OnDepositGenerateCoinAddressResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FDepositGenerateCoinAddressDelegate Delegate) const;
    void OnDepositInfoResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FDepositInfoDelegate Delegate) const;
    void OnDepositInfoAllResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FDepositInfoAllDelegate Delegate) const;
    
	bool IsValid() const;
	void HandleResponse(FHttpResponsePtr HttpResponse, bool bSucceeded, Response& InOutResponse) const;

	FString Url;
	TMap<FString,FString> AdditionalHeaderParams;
};
	
}
