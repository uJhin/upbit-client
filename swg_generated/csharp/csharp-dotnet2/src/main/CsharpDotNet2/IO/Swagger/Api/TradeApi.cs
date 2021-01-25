using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITradeApi
    {
        /// <summary>
        /// 시세 Ticker 조회 ## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 
        /// </summary>
        /// <param name="markets">반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) </param>
        /// <returns>Object</returns>
        Object TradeTicker (string markets);
        /// <summary>
        /// 시세 체결 조회 ## 최근 체결 내역 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC, BTC-BCC) </param>
        /// <param name="to">마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터 </param>
        /// <param name="count">체결 개수 </param>
        /// <param name="cursor">페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. </param>
        /// <param name="daysAgo">최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) </param>
        /// <returns>Object</returns>
        Object TradeTicks (string market, string to, decimal? count, string cursor, decimal? daysAgo);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TradeApi : ITradeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TradeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TradeApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// 시세 Ticker 조회 ## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 
        /// </summary>
        /// <param name="markets">반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) </param> 
        /// <returns>Object</returns>            
        public Object TradeTicker (string markets)
        {
            
            // verify the required parameter 'markets' is set
            if (markets == null) throw new ApiException(400, "Missing required parameter 'markets' when calling TradeTicker");
            
    
            var path = "/ticker";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (markets != null) queryParams.Add("markets", ApiClient.ParameterToString(markets)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TradeTicker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TradeTicker: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// 시세 체결 조회 ## 최근 체결 내역 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC, BTC-BCC) </param> 
        /// <param name="to">마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터 </param> 
        /// <param name="count">체결 개수 </param> 
        /// <param name="cursor">페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다. </param> 
        /// <param name="daysAgo">최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) </param> 
        /// <returns>Object</returns>            
        public Object TradeTicks (string market, string to, decimal? count, string cursor, decimal? daysAgo)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling TradeTicks");
            
    
            var path = "/trades/ticks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
 if (daysAgo != null) queryParams.Add("daysAgo", ApiClient.ParameterToString(daysAgo)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TradeTicks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TradeTicks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
