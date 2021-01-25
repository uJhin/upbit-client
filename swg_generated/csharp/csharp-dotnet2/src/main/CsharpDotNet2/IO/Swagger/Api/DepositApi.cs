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
    public interface IDepositApi
    {
        /// <summary>
        /// 개별 입금 주소 조회 ## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 
        /// </summary>
        /// <param name="currency">Currency symbol </param>
        /// <returns>DepositCompleteResponse</returns>
        DepositCompleteResponse DepositCoinAddress (string currency);
        /// <summary>
        /// 전체 입금 주소 조회 ## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 
        /// </summary>
        /// <returns>Object</returns>
        Object DepositCoinAddresses ();
        /// <summary>
        /// 입금 주소 생성 요청 입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param>
        /// <returns>DepositCompleteResponse</returns>
        DepositCompleteResponse DepositGenerateCoinAddress (string currency);
        /// <summary>
        /// 개별 입금 조회 ## 개별 입금 조회 
        /// </summary>
        /// <param name="uuid">입금 UUID </param>
        /// <param name="txid">입금 TXID </param>
        /// <param name="currency">Currency 코드 </param>
        /// <returns>Deposit</returns>
        Deposit DepositInfo (string uuid, string txid, string currency);
        /// <summary>
        /// 입금 리스트 조회 ## 입금 리스트 조회 
        /// </summary>
        /// <param name="currency">Currency 코드 </param>
        /// <param name="state">출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중 </param>
        /// <param name="uuids">입금 UUID의 목록 </param>
        /// <param name="txids">입금 TXID의 목록 </param>
        /// <param name="limit">개수 제한 (default: 100, max: 100) </param>
        /// <param name="page">페이지 수, default: 1 </param>
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param>
        /// <returns>List&lt;Deposit&gt;</returns>
        List<Deposit> DepositInfoAll (string currency, string state, List<string> uuids, List<string> txids, decimal? limit, decimal? page, string orderBy);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DepositApi : IDepositApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DepositApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DepositApi(String basePath)
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
        /// 개별 입금 주소 조회 ## 개별 입금 주소 조회 **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 
        /// </summary>
        /// <param name="currency">Currency symbol </param> 
        /// <returns>DepositCompleteResponse</returns>            
        public DepositCompleteResponse DepositCoinAddress (string currency)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling DepositCoinAddress");
            
    
            var path = "/deposits/coin_address";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DepositCoinAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositCoinAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DepositCompleteResponse) ApiClient.Deserialize(response.Content, typeof(DepositCompleteResponse), response.Headers);
        }
    
        /// <summary>
        /// 전체 입금 주소 조회 ## 내가 보유한 자산 리스트를 보여줍니다. **NOTE**: 입금 주소 조회 요청 API 유의사항 입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 
        /// </summary>
        /// <returns>Object</returns>            
        public Object DepositCoinAddresses ()
        {
            
    
            var path = "/deposits/coin_addresses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositCoinAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositCoinAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// 입금 주소 생성 요청 입금 주소 생성을 요청한다. **NOTE**: 입금 주소 생성 요청 API 유의사항 입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 
        /// </summary>
        /// <param name="currency">Currency 코드 </param> 
        /// <returns>DepositCompleteResponse</returns>            
        public DepositCompleteResponse DepositGenerateCoinAddress (string currency)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling DepositGenerateCoinAddress");
            
    
            var path = "/deposits/generate_coin_address";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "Bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositGenerateCoinAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositGenerateCoinAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DepositCompleteResponse) ApiClient.Deserialize(response.Content, typeof(DepositCompleteResponse), response.Headers);
        }
    
        /// <summary>
        /// 개별 입금 조회 ## 개별 입금 조회 
        /// </summary>
        /// <param name="uuid">입금 UUID </param> 
        /// <param name="txid">입금 TXID </param> 
        /// <param name="currency">Currency 코드 </param> 
        /// <returns>Deposit</returns>            
        public Deposit DepositInfo (string uuid, string txid, string currency)
        {
            
    
            var path = "/deposit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DepositInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Deposit) ApiClient.Deserialize(response.Content, typeof(Deposit), response.Headers);
        }
    
        /// <summary>
        /// 입금 리스트 조회 ## 입금 리스트 조회 
        /// </summary>
        /// <param name="currency">Currency 코드 </param> 
        /// <param name="state">출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중 </param> 
        /// <param name="uuids">입금 UUID의 목록 </param> 
        /// <param name="txids">입금 TXID의 목록 </param> 
        /// <param name="limit">개수 제한 (default: 100, max: 100) </param> 
        /// <param name="page">페이지 수, default: 1 </param> 
        /// <param name="orderBy">정렬 방식 - asc : 오름차순 - desc : 내림차순 (default) </param> 
        /// <returns>List&lt;Deposit&gt;</returns>            
        public List<Deposit> DepositInfoAll (string currency, string state, List<string> uuids, List<string> txids, decimal? limit, decimal? page, string orderBy)
        {
            
    
            var path = "/deposits";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DepositInfoAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DepositInfoAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Deposit>) ApiClient.Deserialize(response.Content, typeof(List<Deposit>), response.Headers);
        }
    
    }
}
