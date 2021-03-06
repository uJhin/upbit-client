# Upbit Open API
#
# ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
#
# OpenAPI spec version: 1.0.0
# Contact: ujhin942@gmail.com
# Generated by: https://github.com/swagger-api/swagger-codegen.git


#' Ask Class
#'
#' @field currency 
#' @field price_unit 
#' @field min_total 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
Ask <- R6::R6Class(
  'Ask',
  public = list(
    `currency` = NULL,
    `price_unit` = NULL,
    `min_total` = NULL,
    initialize = function(`currency`, `price_unit`, `min_total`){
      if (!missing(`currency`)) {
        stopifnot(is.character(`currency`), length(`currency`) == 1)
        self$`currency` <- `currency`
      }
      if (!missing(`price_unit`)) {
        stopifnot(is.character(`price_unit`), length(`price_unit`) == 1)
        self$`price_unit` <- `price_unit`
      }
      if (!missing(`min_total`)) {
        self$`min_total` <- `min_total`
      }
    },
    toJSON = function() {
      AskObject <- list()
      if (!is.null(self$`currency`)) {
        AskObject[['currency']] <- self$`currency`
      }
      if (!is.null(self$`price_unit`)) {
        AskObject[['price_unit']] <- self$`price_unit`
      }
      if (!is.null(self$`min_total`)) {
        AskObject[['min_total']] <- self$`min_total`
      }

      AskObject
    },
    fromJSON = function(AskJson) {
      AskObject <- jsonlite::fromJSON(AskJson)
      if (!is.null(AskObject$`currency`)) {
        self$`currency` <- AskObject$`currency`
      }
      if (!is.null(AskObject$`price_unit`)) {
        self$`price_unit` <- AskObject$`price_unit`
      }
      if (!is.null(AskObject$`min_total`)) {
        self$`min_total` <- AskObject$`min_total`
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "currency": %s,
           "price_unit": %s,
           "min_total": %s
        }',
        self$`currency`,
        self$`price_unit`,
        self$`min_total`
      )
    },
    fromJSONString = function(AskJson) {
      AskObject <- jsonlite::fromJSON(AskJson)
      self$`currency` <- AskObject$`currency`
      self$`price_unit` <- AskObject$`price_unit`
      self$`min_total` <- AskObject$`min_total`
    }
  )
)
