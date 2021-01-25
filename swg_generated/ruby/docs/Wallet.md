# SwaggerClient::Wallet

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**currency** | **String** | 화폐를 의미하는 영문 대문자 코드 | [optional] 
**wallet_state** | **String** | 입출금 상태 - working : 입출금 가능 - withdraw_only : 출금만 가능 - deposit_only : 입금만 가능 - paused : 입출금 중단 - unsupported : 입출금 미지원  | [optional] 
**block_state** | **String** | 블록 상태 - normal : 정상 - delayed : 지연 - inactive : 비활성 (점검 등)  | [optional] 
**block_height** | **Float** | 블록 높이 | [optional] 
**block_updated_at** | **String** | 블록 갱신 시각 | [optional] 


