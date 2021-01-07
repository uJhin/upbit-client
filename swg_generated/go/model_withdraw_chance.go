/*
 * Upbit Open API
 *
 * ## REST API for Upbit Exchange - Base URL: [https://api.upbit.com] - Official Upbit API Documents: [https://docs.upbit.com] - Official Support email: [open-api@upbit.com] 
 *
 * API version: 1.1.6
 * Contact: ujhin942@gmail.com
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */

package swagger

type WithdrawChance struct {
	MemberLevel *MemberLevel `json:"member_level,omitempty"`
	Currency *Currency `json:"currency,omitempty"`
	Account *Account `json:"account,omitempty"`
	WithdrawLimit *WithdrawLimit `json:"withdraw_limit,omitempty"`
}