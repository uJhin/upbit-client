use hyper;
use serde;
use serde_json;

#[derive(Debug)]
pub enum Error<T> {
    Hyper(hyper::Error),
    Serde(serde_json::Error),
    ApiError(ApiError<T>),
}

#[derive(Debug)]
pub struct ApiError<T> {
    pub code: hyper::StatusCode,
    pub content: Option<T>,
}

impl<'de, T> From<(hyper::StatusCode, &'de [u8])> for Error<T> 
    where T: serde::Deserialize<'de> {
    fn from(e: (hyper::StatusCode, &'de [u8])) -> Self {
        if e.1.len() == 0 {
            return Error::ApiError(ApiError{
                code: e.0,
                content: None,
            });
        }
        match serde_json::from_slice::<T>(e.1) {
            Ok(t) => Error::ApiError(ApiError{
                code: e.0,
                content: Some(t),
            }),
            Err(e) => {
                Error::from(e)
            }
        }
    }
}

impl<T> From<hyper::Error> for Error<T> {
    fn from(e: hyper::Error) -> Self {
        return Error::Hyper(e)
    }
}

impl<T> From<serde_json::Error> for Error<T> {
    fn from(e: serde_json::Error) -> Self {
        return Error::Serde(e)
    }
}

use super::models::*;

mod api_key_api;
pub use self::api_key_api::{ APIKeyApi, APIKeyApiClient };
mod account_api;
pub use self::account_api::{ AccountApi, AccountApiClient };
mod candle_api;
pub use self::candle_api::{ CandleApi, CandleApiClient };
mod deposit_api;
pub use self::deposit_api::{ DepositApi, DepositApiClient };
mod market_api;
pub use self::market_api::{ MarketApi, MarketApiClient };
mod order_api;
pub use self::order_api::{ OrderApi, OrderApiClient };
mod trade_api;
pub use self::trade_api::{ TradeApi, TradeApiClient };
mod withdraw_api;
pub use self::withdraw_api::{ WithdrawApi, WithdrawApiClient };

pub mod configuration;
pub mod client;
