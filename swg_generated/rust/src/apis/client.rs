use std::rc::Rc;

use hyper;
use super::configuration::Configuration;

pub struct APIClient<C: hyper::client::Connect> {
  configuration: Rc<Configuration<C>>,
  api_key_api: Box<::apis::APIKeyApi>,
  account_api: Box<::apis::AccountApi>,
  candle_api: Box<::apis::CandleApi>,
  deposit_api: Box<::apis::DepositApi>,
  market_api: Box<::apis::MarketApi>,
  order_api: Box<::apis::OrderApi>,
  trade_api: Box<::apis::TradeApi>,
  withdraw_api: Box<::apis::WithdrawApi>,
}

impl<C: hyper::client::Connect> APIClient<C> {
  pub fn new(configuration: Configuration<C>) -> APIClient<C> {
    let rc = Rc::new(configuration);

    APIClient {
      configuration: rc.clone(),
      api_key_api: Box::new(::apis::APIKeyApiClient::new(rc.clone())),
      account_api: Box::new(::apis::AccountApiClient::new(rc.clone())),
      candle_api: Box::new(::apis::CandleApiClient::new(rc.clone())),
      deposit_api: Box::new(::apis::DepositApiClient::new(rc.clone())),
      market_api: Box::new(::apis::MarketApiClient::new(rc.clone())),
      order_api: Box::new(::apis::OrderApiClient::new(rc.clone())),
      trade_api: Box::new(::apis::TradeApiClient::new(rc.clone())),
      withdraw_api: Box::new(::apis::WithdrawApiClient::new(rc.clone())),
    }
  }

  pub fn api_key_api(&self) -> &::apis::APIKeyApi{
    self.api_key_api.as_ref()
  }

  pub fn account_api(&self) -> &::apis::AccountApi{
    self.account_api.as_ref()
  }

  pub fn candle_api(&self) -> &::apis::CandleApi{
    self.candle_api.as_ref()
  }

  pub fn deposit_api(&self) -> &::apis::DepositApi{
    self.deposit_api.as_ref()
  }

  pub fn market_api(&self) -> &::apis::MarketApi{
    self.market_api.as_ref()
  }

  pub fn order_api(&self) -> &::apis::OrderApi{
    self.order_api.as_ref()
  }

  pub fn trade_api(&self) -> &::apis::TradeApi{
    self.trade_api.as_ref()
  }

  pub fn withdraw_api(&self) -> &::apis::WithdrawApi{
    self.withdraw_api.as_ref()
  }


}
