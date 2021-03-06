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


#include "SWGErrorInfo.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {

SWGErrorInfo::SWGErrorInfo(QString json) {
    init();
    this->fromJson(json);
}

SWGErrorInfo::SWGErrorInfo() {
    init();
}

SWGErrorInfo::~SWGErrorInfo() {
    this->cleanup();
}

void
SWGErrorInfo::init() {
    message = new QString("");
    m_message_isSet = false;
    name = new QString("");
    m_name_isSet = false;
}

void
SWGErrorInfo::cleanup() {
    if(message != nullptr) { 
        delete message;
    }
    if(name != nullptr) { 
        delete name;
    }
}

SWGErrorInfo*
SWGErrorInfo::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGErrorInfo::fromJsonObject(QJsonObject pJson) {
    ::Swagger::setValue(&message, pJson["message"], "QString", "QString");
    
    ::Swagger::setValue(&name, pJson["name"], "QString", "QString");
    
}

QString
SWGErrorInfo::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
SWGErrorInfo::asJsonObject() {
    QJsonObject obj;
    if(message != nullptr && *message != QString("")){
        toJsonValue(QString("message"), message, obj, QString("QString"));
    }
    if(name != nullptr && *name != QString("")){
        toJsonValue(QString("name"), name, obj, QString("QString"));
    }

    return obj;
}

QString*
SWGErrorInfo::getMessage() {
    return message;
}
void
SWGErrorInfo::setMessage(QString* message) {
    this->message = message;
    this->m_message_isSet = true;
}

QString*
SWGErrorInfo::getName() {
    return name;
}
void
SWGErrorInfo::setName(QString* name) {
    this->name = name;
    this->m_name_isSet = true;
}


bool
SWGErrorInfo::isSet(){
    bool isObjectUpdated = false;
    do{
        if(message != nullptr && *message != QString("")){ isObjectUpdated = true; break;}
        if(name != nullptr && *name != QString("")){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}

