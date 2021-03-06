/**
 * Upbit Open API
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: ujhin942@gmail.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * SWGBid.h
 *
 * 매수 시 제약사항
 */

#ifndef SWGBid_H_
#define SWGBid_H_

#include <QJsonObject>


#include "SWGNumber.h"
#include <QString>

#include "SWGObject.h"

namespace Swagger {

class SWGBid: public SWGObject {
public:
    SWGBid();
    SWGBid(QString json);
    ~SWGBid();
    void init();
    void cleanup();

    QString asJson () override;
    QJsonObject asJsonObject() override;
    void fromJsonObject(QJsonObject json) override;
    SWGBid* fromJson(QString jsonString) override;

    QString* getCurrency();
    void setCurrency(QString* currency);

    QString* getPriceUnit();
    void setPriceUnit(QString* price_unit);

    SWGNumber* getMinTotal();
    void setMinTotal(SWGNumber* min_total);


    virtual bool isSet() override;

private:
    QString* currency;
    bool m_currency_isSet;

    QString* price_unit;
    bool m_price_unit_isSet;

    SWGNumber* min_total;
    bool m_min_total_isSet;

};

}

#endif /* SWGBid_H_ */
