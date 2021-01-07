/**
 * Upbit Open API
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * OpenAPI spec version: 1.1.6
 * Contact: ujhin942@gmail.com
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.17.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * CandleMinutes.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_MODEL_CandleMinutes_H_
#define IO_SWAGGER_CLIENT_MODEL_CandleMinutes_H_


#include "../ModelBase.h"

#include <cpprest/details/basic_types.h>

namespace io {
namespace swagger {
namespace client {
namespace model {

/// <summary>
/// 
/// </summary>
class  CandleMinutes
    : public ModelBase
{
public:
    CandleMinutes();
    virtual ~CandleMinutes();

    /////////////////////////////////////////////
    /// ModelBase overrides

    void validate() override;

    web::json::value toJson() const override;
    void fromJson(web::json::value& json) override;

    void toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) const override;
    void fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) override;

    /////////////////////////////////////////////
    /// CandleMinutes members

    /// <summary>
    /// 마켓명
    /// </summary>
    utility::string_t getMarket() const;
    bool marketIsSet() const;
    void unsetMarket();
    void setMarket(utility::string_t value);
    /// <summary>
    /// 캔들 기준 시각 (UTC 기준)
    /// </summary>
    utility::string_t getCandleDateTimeUtc() const;
    bool candleDateTimeUtcIsSet() const;
    void unsetCandle_date_time_utc();
    void setCandleDateTimeUtc(utility::string_t value);
    /// <summary>
    /// 캔들 기준 시각 (KST 기준)
    /// </summary>
    utility::string_t getCandleDateTimeKst() const;
    bool candleDateTimeKstIsSet() const;
    void unsetCandle_date_time_kst();
    void setCandleDateTimeKst(utility::string_t value);
    /// <summary>
    /// 시가
    /// </summary>
    double getOpeningPrice() const;
    bool openingPriceIsSet() const;
    void unsetOpening_price();
    void setOpeningPrice(double value);
    /// <summary>
    /// 고가
    /// </summary>
    double getHighPrice() const;
    bool highPriceIsSet() const;
    void unsetHigh_price();
    void setHighPrice(double value);
    /// <summary>
    /// 저가
    /// </summary>
    double getLowPrice() const;
    bool lowPriceIsSet() const;
    void unsetLow_price();
    void setLowPrice(double value);
    /// <summary>
    /// 종가
    /// </summary>
    double getTradePrice() const;
    bool tradePriceIsSet() const;
    void unsetTrade_price();
    void setTradePrice(double value);
    /// <summary>
    /// 해당 캔들에서 마지막 틱이 저장된 시각
    /// </summary>
    double getTimestamp() const;
    bool timestampIsSet() const;
    void unsetTimestamp();
    void setTimestamp(double value);
    /// <summary>
    /// 누적 거래 금액
    /// </summary>
    double getCandleAccTradePrice() const;
    bool candleAccTradePriceIsSet() const;
    void unsetCandle_acc_trade_price();
    void setCandleAccTradePrice(double value);
    /// <summary>
    /// 누적 거래량
    /// </summary>
    double getCandleAccTradeVolume() const;
    bool candleAccTradeVolumeIsSet() const;
    void unsetCandle_acc_trade_volume();
    void setCandleAccTradeVolume(double value);
    /// <summary>
    /// 분 단위(유닛)
    /// </summary>
    double getUnit() const;
    bool unitIsSet() const;
    void unsetUnit();
    void setUnit(double value);

protected:
    utility::string_t m_Market;
    bool m_MarketIsSet;
    utility::string_t m_Candle_date_time_utc;
    bool m_Candle_date_time_utcIsSet;
    utility::string_t m_Candle_date_time_kst;
    bool m_Candle_date_time_kstIsSet;
    double m_Opening_price;
    bool m_Opening_priceIsSet;
    double m_High_price;
    bool m_High_priceIsSet;
    double m_Low_price;
    bool m_Low_priceIsSet;
    double m_Trade_price;
    bool m_Trade_priceIsSet;
    double m_Timestamp;
    bool m_TimestampIsSet;
    double m_Candle_acc_trade_price;
    bool m_Candle_acc_trade_priceIsSet;
    double m_Candle_acc_trade_volume;
    bool m_Candle_acc_trade_volumeIsSet;
    double m_Unit;
    bool m_UnitIsSet;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_MODEL_CandleMinutes_H_ */