#import <Foundation/Foundation.h>
#import "SWGError.h"
#import "SWGApi.h"

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



@interface SWGCandleApi: NSObject <SWGApi>

extern NSString* kSWGCandleApiErrorDomain;
extern NSInteger kSWGCandleApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// 시세 캔들 조회 (일 단위)
/// ## 일(Day) 캔들 
///
/// @param market 마켓 코드 (ex. KRW-BTC) 
/// @param to 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  (optional)
/// @param count 캔들 개수  (optional)
/// @param convertingPriceUnit 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  (optional) (default to KRW)
/// 
///  code:200 message:"OK",
///  code:400 message:"Status: Bad Request ",
///  code:401 message:"Status: Unauthorized ",
///  code:403 message:"Status: Forbidden ",
///  code:404 message:"Status: Not Found ",
///  code:500 message:"Status: Internal Server Error "
///
/// @return NSObject*
-(NSURLSessionTask*) candleDaysWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    convertingPriceUnit: (NSString*) convertingPriceUnit
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// 시세 캔들 조회 (분 단위)
/// ## 분(Minute) 캔들 
///
/// @param unit 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
/// @param market 마켓 코드 (ex. KRW-BTC) 
/// @param to 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  (optional)
/// @param count 캔들 개수 (최대 200개까지 요청 가능)  (optional)
/// 
///  code:200 message:"OK",
///  code:400 message:"Status: Bad Request ",
///  code:401 message:"Status: Unauthorized ",
///  code:403 message:"Status: Forbidden ",
///  code:404 message:"Status: Not Found ",
///  code:500 message:"Status: Internal Server Error "
///
/// @return NSObject*
-(NSURLSessionTask*) candleMinutesWithUnit: (NSNumber*) unit
    market: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// 시세 캔들 조회 (월 단위)
/// ## 월(Month) 캔들 
///
/// @param market 마켓 코드 (ex. KRW-BTC) 
/// @param to 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  (optional)
/// @param count 캔들 개수  (optional)
/// 
///  code:200 message:"OK",
///  code:400 message:"Status: Bad Request ",
///  code:401 message:"Status: Unauthorized ",
///  code:403 message:"Status: Forbidden ",
///  code:404 message:"Status: Not Found ",
///  code:500 message:"Status: Internal Server Error "
///
/// @return NSObject*
-(NSURLSessionTask*) candleMonthWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// 시세 캔들 조회 (주 단위)
/// ## 주(Week) 캔들 
///
/// @param market 마켓 코드 (ex. KRW-BTC) 
/// @param to 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  (optional)
/// @param count 캔들 개수  (optional)
/// 
///  code:200 message:"OK",
///  code:400 message:"Status: Bad Request ",
///  code:401 message:"Status: Unauthorized ",
///  code:403 message:"Status: Forbidden ",
///  code:404 message:"Status: Not Found ",
///  code:500 message:"Status: Internal Server Error "
///
/// @return NSObject*
-(NSURLSessionTask*) candleWeeksWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;



@end
