<div align='center'>
  <img src="logo/logo.png" width="250" height="250">
  <br/><br/>
  <div>
    <a href="https://github.com/uJhin/upbit-client/releases">
      <img src="https://img.shields.io/github/v/release/uJhin/upbit-client"/>
    </a>
  </div>
  <br/>
  <a href="https://ujhin.github.io/upbit-client-docs/">
    <b>Upbit Client Documents</b>
  </a>
  <br/><br/><br/><br/>
  <img src="logo/UPbit_Logo.png" />
  <br/><br/>
  <div>
      <!-- <img src="https://img.shields.io/github/stars/uJhin/upbit-client?style=social"/> -->
  </div>
  <br/>
  <div>
    <a href="https://github.com/uJhin/upbit-client/issues">
      <img src="https://img.shields.io/github/issues/uJhin/upbit-client"/>
    </a>
    <a href="https://github.com/uJhin/upbit-client/blob/main/LICENSE">
      <img src="https://img.shields.io/github/license/uJhin/upbit-client"/>
    </a>
  </div>
  <br/>
  <p>Upbit(업비트) Cryptocurrency Exchange API Client</p>
  <p>패키지 개발에 도움을 주신 Upbit OPEN API 지원팀에게 감사의 말씀을 전합니다.</p>
</div>

### Swagger Generated API Documents
- [Python](https://github.com/uJhin/upbit-client/tree/main/swg_generated/python/docs)
- [CSharp](https://github.com/uJhin/upbit-client/tree/main/swg_generated/csharp/docs)
- [Java](https://github.com/uJhin/upbit-client/tree/main/swg_generated/java/docs)
- [Go](https://github.com/uJhin/upbit-client/tree/main/swg_generated/go/docs)
- [JavaScript](https://github.com/uJhin/upbit-client/tree/main/swg_generated/javascript)
- [Kotlin](https://github.com/uJhin/upbit-client/tree/main/swg_generated/kotlin)
- [PHP](https://github.com/uJhin/upbit-client/tree/main/swg_generated/php/SwaggerClient-php/docs)

### Simple Examples
- Your API Keys
```python
# /v1/api_keys

from upbit.client import Upbit

access_key = "Your Access Key"
secret_key = "Your Secret Key"

client = Upbit(access_key, secret_key)
print(client.APIKey.APIKey_info().result())
```

- Buy Currency
```python
# /v1/orders

from upbit.client import Upbit

access_key = "Your Access Key"
secret_key = "Your Secret Key"

client = Upbit(access_key, secret_key)
order = client.Order.Order_new(
    market='KRW-BTC',
    side='bid',
    volume='0.1',
    price='3000000',
    ord_type='limit'
).result()
print(order)
```

- Sell Currency

```python
# /v1/orders

from upbit.client import Upbit

access_key = "Your Access Key"
secret_key = "Your Secret Key"

client = Upbit(access_key, secret_key)
order = client.Order.Order_new(
    market='KRW-BTC',
    side='sid',
    volume='0.1',
    price='3000000',
    ord_type='limit'
).result()
print(order)
```

### Donation
- BTC: 3NVw2seiTQddGQwc1apqudKxuTqebpyL3s
- ETH: 0x60dd373f59862d9df776596889b997e24bee42eb
