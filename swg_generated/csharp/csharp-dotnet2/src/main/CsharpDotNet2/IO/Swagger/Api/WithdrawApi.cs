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
    public interface IWithdrawApi
    {
        /// <summary>
        /// 출금 가능 정보 ## 해당 통화의 가능한 출금 정보를 확인한다. 
        /// </summary>
        /// <param name="currency">Currency Symbol </param>
        /// <returns>WithdrawChance</returns>
        WithdrawChance WithdrawChance (string currency);
        /// <summary>
        /// 코인 출금하기 ## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param>
        /// <param name="amount">출금 수량 </param>
        /// <param name="address">출금 가능 주소에 등록된 출금 주소 </param>
        /// <param name="secondaryAddress">2차 출금 주소 (필요한 코인에 한해서) </param>
        /// <param name="transactionType">출금 유형 - default : 일반출금 - internal : 바로출금 </param>
        /// <returns>WithdrawCoin</returns>
        WithdrawCoin WithdrawCoin (string currency, string amount, string address, string secondaryAddress, string transactionType);
        /// <summary>
        /// 개별 출금 조회 ## 출금 UUID를 통해 개별 출금 정보를 조회한다. 
        /// </summary>
        /// <param name="uuid">출금 UUID </param>
        /// <param name="txid">출금 TXID </param>
        /// <param name="currency">Currency 코드 </param>
        /// <returns>Withdraw</returns>
        Withdraw WithdrawInfo (string uuid, string txid, string currency);
        /// <summary>
        /// 출금 리스트 조회 ## 출금 리스트를 조회한다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param>
        /// <param name="state">출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 </param>
        /// <param name="uuids">출금 UUID의 목록 </param>
        /// <param name="txids">출금 TXID의 목록 </param>
        /// <param name="limit">개수 제한 (default: 100, max: 100) </param>
        /// <param name="page">페이지 수, default: 1 </param>
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param>
        /// <returns>List&lt;Withdraw&gt;</returns>
        List<Withdraw> WithdrawInfoAll (string currency, string state, List<string> uuids, List<string> txids, decimal? limit, decimal? page, string orderBy);
        /// <summary>
        /// 원화 출금하기 ## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 
        /// </summary>
        /// <param name="amount">출금 원화 수량 </param>
        /// <returns>Withdraw</returns>
        Withdraw WithdrawKrw (string amount);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WithdrawApi : IWithdrawApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WithdrawApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WithdrawApi(String basePath)
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
        /// 출금 가능 정보 ## 해당 통화의 가능한 출금 정보를 확인한다. 
        /// </summary>
        /// <param name="currency">Currency Symbol </param> 
        /// <returns>WithdrawChance</returns>            
        public WithdrawChance WithdrawChance (string currency)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling WithdrawChance");
            
    
            var path = "/withdraws/chance";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (currency != null) queryParams.Add("currency", ApiClient.ParameterToString(currency)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawChance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawChance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WithdrawChance) ApiClient.Deserialize(response.Content, typeof(WithdrawChance), response.Headers);
        }
    
        /// <summary>
        /// 코인 출금하기 ## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param> 
        /// <param name="amount">출금 수량 </param> 
        /// <param name="address">출금 가능 주소에 등록된 출금 주소 </param> 
        /// <param name="secondaryAddress">2차 출금 주소 (필요한 코인에 한해서) </param> 
        /// <param name="transactionType">출금 유형 - default : 일반출금 - internal : 바로출금 </param> 
        /// <returns>WithdrawCoin</returns>            
        public WithdrawCoin WithdrawCoin (string currency, string amount, string address, string secondaryAddress, string transactionType)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling WithdrawCoin");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling WithdrawCoin");
            
            // verify the required parameter 'address' is set
            if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling WithdrawCoin");
            
    
            var path = "/withdraws/coin";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (address != null) formParams.Add("address", ApiClient.ParameterToString(address)); // form parameter
if (secondaryAddress != null) formParams.Add("secondary_address", ApiClient.ParameterToString(secondaryAddress)); // form parameter
if (transactionType != null) formParams.Add("transaction_type", ApiClient.ParameterToString(transactionType)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawCoin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawCoin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WithdrawCoin) ApiClient.Deserialize(response.Content, typeof(WithdrawCoin), response.Headers);
        }
    
        /// <summary>
        /// 개별 출금 조회 ## 출금 UUID를 통해 개별 출금 정보를 조회한다. 
        /// </summary>
        /// <param name="uuid">출금 UUID </param> 
        /// <param name="txid">출금 TXID </param> 
        /// <param name="currency">Currency 코드 </param> 
        /// <returns>Withdraw</returns>            
        public Withdraw WithdrawInfo (string uuid, string txid, string currency)
        {
            
    
            var path = "/withdraw";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (uuid != null) queryParams.Add("uuid", ApiClient.ParameterToString(uuid)); // query parameter
 if (txid != null) queryParams.Add("txid", ApiClient.ParameterToString(txid)); // query parameter
 if (currency != null) queryParams.Add("currency", ApiClient.ParameterToString(currency)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Withdraw) ApiClient.Deserialize(response.Content, typeof(Withdraw), response.Headers);
        }
    
        /// <summary>
        /// 출금 리스트 조회 ## 출금 리스트를 조회한다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param> 
        /// <param name="state">출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨 </param> 
        /// <param name="uuids">출금 UUID의 목록 </param> 
        /// <param name="txids">출금 TXID의 목록 </param> 
        /// <param name="limit">개수 제한 (default: 100, max: 100) </param> 
        /// <param name="page">페이지 수, default: 1 </param> 
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param> 
        /// <returns>List&lt;Withdraw&gt;</returns>            
        public List<Withdraw> WithdrawInfoAll (string currency, string state, List<string> uuids, List<string> txids, decimal? limit, decimal? page, string orderBy)
        {
            
    
            var path = "/withdraws";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (currency != null) queryParams.Add("currency", ApiClient.ParameterToString(currency)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (uuids != null) queryParams.Add("uuids", ApiClient.ParameterToString(uuids)); // query parameter
 if (txids != null) queryParams.Add("txids", ApiClient.ParameterToString(txids)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (orderBy != null) queryParams.Add("order_by", ApiClient.ParameterToString(orderBy)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawInfoAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawInfoAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Withdraw>) ApiClient.Deserialize(response.Content, typeof(List<Withdraw>), response.Headers);
        }
    
        /// <summary>
        /// 원화 출금하기 ## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 
        /// </summary>
        /// <param name="amount">출금 원화 수량 </param> 
        /// <returns>Withdraw</returns>            
        public Withdraw WithdrawKrw (string amount)
        {
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling WithdrawKrw");
            
    
            var path = "/withdraws/krw";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawKrw: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WithdrawKrw: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Withdraw) ApiClient.Deserialize(response.Content, typeof(Withdraw), response.Headers);
        }
    
    }
}
