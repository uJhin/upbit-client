/*
 * Upbit Open API
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * OpenAPI spec version: 1.1.6
 * Contact: ujhin942@gmail.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.17
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.UpbitOpenApi) {
      root.UpbitOpenApi = {};
    }
    root.UpbitOpenApi.Deposit = factory(root.UpbitOpenApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Deposit model module.
   * @module model/Deposit
   * @version 1.1.6
   */

  /**
   * Constructs a new <code>Deposit</code>.
   * @alias module:model/Deposit
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>Deposit</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Deposit} obj Optional instance to populate.
   * @return {module:model/Deposit} The populated <code>Deposit</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('type'))
        obj.type = ApiClient.convertToType(data['type'], 'String');
      if (data.hasOwnProperty('uuid'))
        obj.uuid = ApiClient.convertToType(data['uuid'], 'String');
      if (data.hasOwnProperty('currency'))
        obj.currency = ApiClient.convertToType(data['currency'], 'String');
      if (data.hasOwnProperty('txid'))
        obj.txid = ApiClient.convertToType(data['txid'], 'String');
      if (data.hasOwnProperty('state'))
        obj.state = ApiClient.convertToType(data['state'], 'String');
      if (data.hasOwnProperty('created_at'))
        obj.createdAt = ApiClient.convertToType(data['created_at'], 'String');
      if (data.hasOwnProperty('done_at'))
        obj.doneAt = ApiClient.convertToType(data['done_at'], 'String');
      if (data.hasOwnProperty('amount'))
        obj.amount = ApiClient.convertToType(data['amount'], 'String');
      if (data.hasOwnProperty('fee'))
        obj.fee = ApiClient.convertToType(data['fee'], 'String');
      if (data.hasOwnProperty('transaction_type'))
        obj.transactionType = ApiClient.convertToType(data['transaction_type'], 'String');
    }
    return obj;
  }

  /**
   * 입출금 종류
   * @member {String} type
   */
  exports.prototype.type = undefined;

  /**
   * 입금에 대한 고유 아이디
   * @member {String} uuid
   */
  exports.prototype.uuid = undefined;

  /**
   * 화폐를 의미하는 영문 대문자 코드
   * @member {String} currency
   */
  exports.prototype.currency = undefined;

  /**
   * 입금의 트랜잭션 아이디
   * @member {String} txid
   */
  exports.prototype.txid = undefined;

  /**
   * 입금 상태
   * @member {String} state
   */
  exports.prototype.state = undefined;

  /**
   * 입금 생성 시간
   * @member {String} createdAt
   */
  exports.prototype.createdAt = undefined;

  /**
   * 입금 완료 시간
   * @member {String} doneAt
   */
  exports.prototype.doneAt = undefined;

  /**
   * 입금 수량
   * @member {String} amount
   */
  exports.prototype.amount = undefined;

  /**
   * 입금 수수료
   * @member {String} fee
   */
  exports.prototype.fee = undefined;

  /**
   * 입금 유형 - default : 일반출금 - internal : 바로입금 
   * @member {String} transactionType
   */
  exports.prototype.transactionType = undefined;

  return exports;

}));