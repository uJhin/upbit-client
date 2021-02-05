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
    public interface IOrderApi
    {
        /// <summary>
        /// 주문 취소 접수 ## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 
        /// </summary>
        /// <param name="uuid">취소할 주문의 UUID </param>
        /// <param name="identifier">조회용 사용자 지정 값 </param>
        /// <returns>Order</returns>
        Order OrderCancel (string uuid, string identifier);
        /// <summary>
        /// 주문 가능 정보 ## 마켓별 주문 가능 정보를 확인한다. 
        /// </summary>
        /// <param name="market">Market ID </param>
        /// <returns>OrderChance</returns>
        OrderChance OrderChance (string market);
        /// <summary>
        /// 개별 주문 조회 ## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 
        /// </summary>
        /// <param name="uuid">주문 UUID </param>
        /// <param name="identifier">조회용 사용자 지정 값 </param>
        /// <returns>OrderInfo</returns>
        OrderInfo OrderInfo (string uuid, string identifier);
        /// <summary>
        /// 주문 리스트 조회 ## 주문 리스트를 조회한다. 
        /// </summary>
        /// <param name="market">마켓 아이디 </param>
        /// <param name="state">주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 </param>
        /// <param name="states">주문 상태의 목록 </param>
        /// <param name="uuids">주문 UUID의 목록 </param>
        /// <param name="identifiers">주문 identifier의 목록 </param>
        /// <param name="page">페이지 수, default: 1 </param>
        /// <param name="limit">요청 개수, default: 100 </param>
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param>
        /// <returns>List&lt;Order&gt;</returns>
        List<Order> OrderInfoAll (string market, string state, List<string> states, List<string> uuids, List<string> identifiers, decimal? page, decimal? limit, string orderBy);
        /// <summary>
        /// 주문하기 ## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  &#x60;identifier&#x60;는 서비스에서 발급하는 &#x60;uuid&#x60;가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 &#x60;identifier&#x60; 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 &#x60;ord_type&#x60; 필드를 &#x60;price&#x60; or &#x60;market&#x60; 으로 설정해야됩니다. 매수 주문의 경우 &#x60;ord_type&#x60;을 &#x60;price&#x60;로 설정하고 &#x60;volume&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 매도 주문의 경우 &#x60;ord_type&#x60;을 &#x60;market&#x60;로 설정하고 &#x60;price&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 
        /// </summary>
        /// <param name="market">마켓 ID (필수) </param>
        /// <param name="side">주문 종류 (필수) - bid : 매수 - ask : 매도 </param>
        /// <param name="ordType">주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) </param>
        /// <param name="volume">주문량 (지정가, 시장가 매도 시 필수) </param>
        /// <param name="price">주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) </param>
        /// <param name="identifier">조회용 사용자 지정값 (선택) </param>
        /// <returns>NewOrder</returns>
        NewOrder OrderNew (string market, string side, string ordType, string volume, string price, string identifier);
        /// <summary>
        /// 시세 호가 정보(Orderbook) 조회 ## 호가 정보 조회 
        /// </summary>
        /// <param name="markets">마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) </param>
        /// <returns>List&lt;Orderbook&gt;</returns>
        List<Orderbook> OrderOrderbook (List<string> markets);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderApi : IOrderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(String basePath)
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
        /// 주문 취소 접수 ## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 
        /// </summary>
        /// <param name="uuid">취소할 주문의 UUID </param> 
        /// <param name="identifier">조회용 사용자 지정 값 </param> 
        /// <returns>Order</returns>            
        public Order OrderCancel (string uuid, string identifier)
        {
            
    
            var path = "/order";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (uuid != null) queryParams.Add("uuid", ApiClient.ParameterToString(uuid)); // query parameter
 if (identifier != null) queryParams.Add("identifier", ApiClient.ParameterToString(identifier)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderCancel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderCancel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Order) ApiClient.Deserialize(response.Content, typeof(Order), response.Headers);
        }
    
        /// <summary>
        /// 주문 가능 정보 ## 마켓별 주문 가능 정보를 확인한다. 
        /// </summary>
        /// <param name="market">Market ID </param> 
        /// <returns>OrderChance</returns>            
        public OrderChance OrderChance (string market)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling OrderChance");
            
    
            var path = "/orders/chance";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderChance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrderChance) ApiClient.Deserialize(response.Content, typeof(OrderChance), response.Headers);
        }
    
        /// <summary>
        /// 개별 주문 조회 ## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: &#x60;uuid&#x60; 혹은 &#x60;identifier&#x60; 둘 중 하나의 값이 반드시 포함되어야 합니다. 
        /// </summary>
        /// <param name="uuid">주문 UUID </param> 
        /// <param name="identifier">조회용 사용자 지정 값 </param> 
        /// <returns>OrderInfo</returns>            
        public OrderInfo OrderInfo (string uuid, string identifier)
        {
            
    
            var path = "/order";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (uuid != null) queryParams.Add("uuid", ApiClient.ParameterToString(uuid)); // query parameter
 if (identifier != null) queryParams.Add("identifier", ApiClient.ParameterToString(identifier)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrderInfo) ApiClient.Deserialize(response.Content, typeof(OrderInfo), response.Headers);
        }
    
        /// <summary>
        /// 주문 리스트 조회 ## 주문 리스트를 조회한다. 
        /// </summary>
        /// <param name="market">마켓 아이디 </param> 
        /// <param name="state">주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소 </param> 
        /// <param name="states">주문 상태의 목록 </param> 
        /// <param name="uuids">주문 UUID의 목록 </param> 
        /// <param name="identifiers">주문 identifier의 목록 </param> 
        /// <param name="page">페이지 수, default: 1 </param> 
        /// <param name="limit">요청 개수, default: 100 </param> 
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param> 
        /// <returns>List&lt;Order&gt;</returns>            
        public List<Order> OrderInfoAll (string market, string state, List<string> states, List<string> uuids, List<string> identifiers, decimal? page, decimal? limit, string orderBy)
        {
            
    
            var path = "/orders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (market != null) queryParams.Add("market", ApiClient.ParameterToString(market)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (states != null) queryParams.Add("states", ApiClient.ParameterToString(states)); // query parameter
 if (uuids != null) queryParams.Add("uuids", ApiClient.ParameterToString(uuids)); // query parameter
 if (identifiers != null) queryParams.Add("identifiers", ApiClient.ParameterToString(identifiers)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (orderBy != null) queryParams.Add("order_by", ApiClient.ParameterToString(orderBy)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderInfoAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderInfoAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Order>) ApiClient.Deserialize(response.Content, typeof(List<Order>), response.Headers);
        }
    
        /// <summary>
        /// 주문하기 ## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  &#x60;identifier&#x60;는 서비스에서 발급하는 &#x60;uuid&#x60;가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 &#x60;identifier&#x60; 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 &#x60;ord_type&#x60; 필드를 &#x60;price&#x60; or &#x60;market&#x60; 으로 설정해야됩니다. 매수 주문의 경우 &#x60;ord_type&#x60;을 &#x60;price&#x60;로 설정하고 &#x60;volume&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 매도 주문의 경우 &#x60;ord_type&#x60;을 &#x60;market&#x60;로 설정하고 &#x60;price&#x60;을 &#x60;null&#x60; 혹은 제외해야됩니다. 
        /// </summary>
        /// <param name="market">마켓 ID (필수) </param> 
        /// <param name="side">주문 종류 (필수) - bid : 매수 - ask : 매도 </param> 
        /// <param name="ordType">주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) </param> 
        /// <param name="volume">주문량 (지정가, 시장가 매도 시 필수) </param> 
        /// <param name="price">주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) </param> 
        /// <param name="identifier">조회용 사용자 지정값 (선택) </param> 
        /// <returns>NewOrder</returns>            
        public NewOrder OrderNew (string market, string side, string ordType, string volume, string price, string identifier)
        {
            
            // verify the required parameter 'market' is set
            if (market == null) throw new ApiException(400, "Missing required parameter 'market' when calling OrderNew");
            
            // verify the required parameter 'side' is set
            if (side == null) throw new ApiException(400, "Missing required parameter 'side' when calling OrderNew");
            
            // verify the required parameter 'ordType' is set
            if (ordType == null) throw new ApiException(400, "Missing required parameter 'ordType' when calling OrderNew");
            
    
            var path = "/orders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (market != null) formParams.Add("market", ApiClient.ParameterToString(market)); // form parameter
if (side != null) formParams.Add("side", ApiClient.ParameterToString(side)); // form parameter
if (volume != null) formParams.Add("volume", ApiClient.ParameterToString(volume)); // form parameter
if (price != null) formParams.Add("price", ApiClient.ParameterToString(price)); // form parameter
if (ordType != null) formParams.Add("ord_type", ApiClient.ParameterToString(ordType)); // form parameter
if (identifier != null) formParams.Add("identifier", ApiClient.ParameterToString(identifier)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderNew: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderNew: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NewOrder) ApiClient.Deserialize(response.Content, typeof(NewOrder), response.Headers);
        }
    
        /// <summary>
        /// 시세 호가 정보(Orderbook) 조회 ## 호가 정보 조회 
        /// </summary>
        /// <param name="markets">마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) </param> 
        /// <returns>List&lt;Orderbook&gt;</returns>            
        public List<Orderbook> OrderOrderbook (List<string> markets)
        {
            
            // verify the required parameter 'markets' is set
            if (markets == null) throw new ApiException(400, "Missing required parameter 'markets' when calling OrderOrderbook");
            
    
            var path = "/orderbook";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrderOrderbook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrderOrderbook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Orderbook>) ApiClient.Deserialize(response.Content, typeof(List<Orderbook>), response.Headers);
        }
    
    }
}
