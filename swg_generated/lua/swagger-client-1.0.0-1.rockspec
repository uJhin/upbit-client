package = "swagger-client"
version = "1.0.0-1"
source = {
	url = "https://github.com/YOUR_GIT_USERNAME/YOUR_GIT_REPO.git"
}

description = {
	summary = "API client genreated by Swagger Codegen",
	detailed = [[
## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] ]],
	homepage = "https://github.com/swagger-api/swagger-codegen",
	license = "Unlicense",
	maintainer = "Swagger Codegen contributors",
}

dependencies = {
	"lua >= 5.2",
	"http",
	"dkjson",
	"basexx"
}

build = {
	type = "builtin",
	modules = {
		["swagger-client.api.api_key_api"] = "swagger-client/api/api_key_api.lua";
		["swagger-client.api.account_api"] = "swagger-client/api/account_api.lua";
		["swagger-client.api.candle_api"] = "swagger-client/api/candle_api.lua";
		["swagger-client.api.deposit_api"] = "swagger-client/api/deposit_api.lua";
		["swagger-client.api.market_api"] = "swagger-client/api/market_api.lua";
		["swagger-client.api.order_api"] = "swagger-client/api/order_api.lua";
		["swagger-client.api.trade_api"] = "swagger-client/api/trade_api.lua";
		["swagger-client.api.withdraw_api"] = "swagger-client/api/withdraw_api.lua";
		["swagger-client.model.account"] = "swagger-client/model/account.lua";
		["swagger-client.model.api_key"] = "swagger-client/model/api_key.lua";
		["swagger-client.model.ask"] = "swagger-client/model/ask.lua";
		["swagger-client.model.ask_account"] = "swagger-client/model/ask_account.lua";
		["swagger-client.model.bid"] = "swagger-client/model/bid.lua";
		["swagger-client.model.bid_account"] = "swagger-client/model/bid_account.lua";
		["swagger-client.model.candle_date"] = "swagger-client/model/candle_date.lua";
		["swagger-client.model.candle_days"] = "swagger-client/model/candle_days.lua";
		["swagger-client.model.candle_minutes"] = "swagger-client/model/candle_minutes.lua";
		["swagger-client.model.currency"] = "swagger-client/model/currency.lua";
		["swagger-client.model.deposit"] = "swagger-client/model/deposit.lua";
		["swagger-client.model.deposit_complete_response"] = "swagger-client/model/deposit_complete_response.lua";
		["swagger-client.model.deposit_transfer_response"] = "swagger-client/model/deposit_transfer_response.lua";
		["swagger-client.model.error"] = "swagger-client/model/error.lua";
		["swagger-client.model.error_info"] = "swagger-client/model/error_info.lua";
		["swagger-client.model.market"] = "swagger-client/model/market.lua";
		["swagger-client.model.market_info"] = "swagger-client/model/market_info.lua";
		["swagger-client.model.member_level"] = "swagger-client/model/member_level.lua";
		["swagger-client.model.new_order"] = "swagger-client/model/new_order.lua";
		["swagger-client.model.order"] = "swagger-client/model/order.lua";
		["swagger-client.model.order_chance"] = "swagger-client/model/order_chance.lua";
		["swagger-client.model.order_info"] = "swagger-client/model/order_info.lua";
		["swagger-client.model.orderbook"] = "swagger-client/model/orderbook.lua";
		["swagger-client.model.orderbook_unit"] = "swagger-client/model/orderbook_unit.lua";
		["swagger-client.model.ticker"] = "swagger-client/model/ticker.lua";
		["swagger-client.model.trade"] = "swagger-client/model/trade.lua";
		["swagger-client.model.trade_ticks"] = "swagger-client/model/trade_ticks.lua";
		["swagger-client.model.wallet"] = "swagger-client/model/wallet.lua";
		["swagger-client.model.withdraw"] = "swagger-client/model/withdraw.lua";
		["swagger-client.model.withdraw_chance"] = "swagger-client/model/withdraw_chance.lua";
		["swagger-client.model.withdraw_coin"] = "swagger-client/model/withdraw_coin.lua";
		["swagger-client.model.withdraw_limit"] = "swagger-client/model/withdraw_limit.lua";
	}
}
