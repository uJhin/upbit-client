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
    public interface ICandleApi
    {
        /// <summary>
        /// 시세 캔들 조회 (일 단위) ## 일(Day) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param>
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param>
        /// <param name="count">캔들 개수 </param>
        /// <param name="convertingPriceUnit">종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다. </param>
        /// <returns>Object</returns>
        Object CandleDays (string market, string to, decimal? count, string convertingPriceUnit);
        /// <summary>
        /// 시세 캔들 조회 (분 단위) ## 분(Minute) 캔들 
        /// </summary>
        /// <param name="unit">분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 </param>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param>
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param>
        /// <param name="count">캔들 개수 (최대 200개까지 요청 가능) </param>
        /// <returns>Object</returns>
        Object CandleMinutes (int? unit, string market, string to, decimal? count);
        /// <summary>
        /// 시세 캔들 조회 (월 단위) ## 월(Month) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param>
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param>
        /// <param name="count">캔들 개수 </param>
        /// <returns>Object</returns>
        Object CandleMonth (string market, string to, decimal? count);
        /// <summary>
        /// 시세 캔들 조회 (주 단위) ## 주(Week) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param>
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param>
        /// <param name="count">캔들 개수 </param>
        /// <returns>Object</returns>
        Object CandleWeeks (string market, string to, decimal? count);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CandleApi : ICandleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CandleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CandleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CandleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CandleApi(String basePath)
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
        /// 시세 캔들 조회 (일 단위) ## 일(Day) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param> 
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param> 
        /// <param name="count">캔들 개수 </param> 
        /// <param name="convertingPriceUnit">종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다. </param> 
        /// <returns>Object</returns>            
        public Object CandleDays (string market, string to, decimal? count, string convertingPriceUnit)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling CandleDays");
            
    
            var path = "/candles/days";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (convertingPriceUnit != null) queryParams.Add("convertingPriceUnit", ApiClient.ParameterToString(convertingPriceUnit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleDays: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleDays: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// 시세 캔들 조회 (분 단위) ## 분(Minute) 캔들 
        /// </summary>
        /// <param name="unit">분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 </param> 
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param> 
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param> 
        /// <param name="count">캔들 개수 (최대 200개까지 요청 가능) </param> 
        /// <returns>Object</returns>            
        public Object CandleMinutes (int? unit, string market, string to, decimal? count)
        {
            
            // verify the required parameter 'unit' is set
            if (unit == null) throw new ApiException(400, "Missing required parameter 'unit' when calling CandleMinutes");
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling CandleMinutes");
            
    
            var path = "/candles/minutes/{unit}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unit" + "}", ApiClient.ParameterToString(unit));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleMinutes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleMinutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// 시세 캔들 조회 (월 단위) ## 월(Month) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param> 
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param> 
        /// <param name="count">캔들 개수 </param> 
        /// <returns>Object</returns>            
        public Object CandleMonth (string market, string to, decimal? count)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling CandleMonth");
            
    
            var path = "/candles/months";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleMonth: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleMonth: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// 시세 캔들 조회 (주 단위) ## 주(Week) 캔들 
        /// </summary>
        /// <param name="market">마켓 코드 (ex. KRW-BTC) </param> 
        /// <param name="to">마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들 </param> 
        /// <param name="count">캔들 개수 </param> 
        /// <returns>Object</returns>            
        public Object CandleWeeks (string market, string to, decimal? count)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling CandleWeeks");
            
    
            var path = "/candles/weeks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleWeeks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CandleWeeks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
