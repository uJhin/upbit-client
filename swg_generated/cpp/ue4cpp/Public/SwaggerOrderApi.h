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

class SWAGGER_API SwaggerOrderApi
{
public:
	SwaggerOrderApi();
	~SwaggerOrderApi();

	void SetURL(const FString& Url);
	void AddHeaderParam(const FString& Key, const FString& Value);
	void ClearHeaderParams();

	class OrderCancelRequest;
	class OrderCancelResponse;
	class OrderChanceRequest;
	class OrderChanceResponse;
	class OrderInfoRequest;
	class OrderInfoResponse;
	class OrderInfoAllRequest;
	class OrderInfoAllResponse;
	class OrderNewRequest;
	class OrderNewResponse;
	class OrderOrderbookRequest;
	class OrderOrderbookResponse;
	
    DECLARE_DELEGATE_OneParam(FOrderCancelDelegate, const OrderCancelResponse&);
    DECLARE_DELEGATE_OneParam(FOrderChanceDelegate, const OrderChanceResponse&);
    DECLARE_DELEGATE_OneParam(FOrderInfoDelegate, const OrderInfoResponse&);
    DECLARE_DELEGATE_OneParam(FOrderInfoAllDelegate, const OrderInfoAllResponse&);
    DECLARE_DELEGATE_OneParam(FOrderNewDelegate, const OrderNewResponse&);
    DECLARE_DELEGATE_OneParam(FOrderOrderbookDelegate, const OrderOrderbookResponse&);
    
    bool OrderCancel(const OrderCancelRequest& Request, const FOrderCancelDelegate& Delegate = FOrderCancelDelegate()) const;
    bool OrderChance(const OrderChanceRequest& Request, const FOrderChanceDelegate& Delegate = FOrderChanceDelegate()) const;
    bool OrderInfo(const OrderInfoRequest& Request, const FOrderInfoDelegate& Delegate = FOrderInfoDelegate()) const;
    bool OrderInfoAll(const OrderInfoAllRequest& Request, const FOrderInfoAllDelegate& Delegate = FOrderInfoAllDelegate()) const;
    bool OrderNew(const OrderNewRequest& Request, const FOrderNewDelegate& Delegate = FOrderNewDelegate()) const;
    bool OrderOrderbook(const OrderOrderbookRequest& Request, const FOrderOrderbookDelegate& Delegate = FOrderOrderbookDelegate()) const;
    
private:
    void OnOrderCancelResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderCancelDelegate Delegate) const;
    void OnOrderChanceResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderChanceDelegate Delegate) const;
    void OnOrderInfoResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderInfoDelegate Delegate) const;
    void OnOrderInfoAllResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderInfoAllDelegate Delegate) const;
    void OnOrderNewResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderNewDelegate Delegate) const;
    void OnOrderOrderbookResponse(FHttpRequestPtr HttpRequest, FHttpResponsePtr HttpResponse, bool bSucceeded, FOrderOrderbookDelegate Delegate) const;
    
	bool IsValid() const;
	void HandleResponse(FHttpResponsePtr HttpResponse, bool bSucceeded, Response& InOutResponse) const;

	FString Url;
	TMap<FString,FString> AdditionalHeaderParams;
};
	
}
