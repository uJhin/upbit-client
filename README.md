<div align='center'>
  <img src="logo/UPbit_Logo.png" />
  <br/>
  <br/>
  <h1>Upbit Client</h1>
  <div>
      <!-- <img src="https://img.shields.io/github/stars/uJhin/upbit-client?style=social"/> -->
  </div>
  <div>
    <img src="https://img.shields.io/github/v/release/uJhin/upbit-client"/>
  </div>
  <div>
    <img src="https://img.shields.io/github/issues/uJhin/upbit-client"/>
    <img src="https://img.shields.io/github/license/uJhin/upbit-client"/>
  </div>
  <br/>
  <br/>
  <p>Upbit(업비트) Cryptocurrency Trading Market API Client</p>
</div>

# Install
- `pip` command at PyPI
```bash
pip install upbit-client
```

- `git` command
```bash
git clone https://github.com/uJhin/upbit-client.git
```

# API Documents
- [Python](https://github.com/uJhin/upbit-client/tree/main/swg_generated/python/docs)
- [CSharp](https://github.com/uJhin/upbit-client/tree/main/swg_generated/csharp/docs)
- [Java](https://github.com/uJhin/upbit-client/tree/main/swg_generated/java/docs)
- [Go](https://github.com/uJhin/upbit-client/tree/main/swg_generated/go/docs)
- [JavaScript](https://github.com/uJhin/upbit-client/tree/main/swg_generated/javascript)
- [Kotlin](https://github.com/uJhin/upbit-client/tree/main/swg_generated/kotlin)
- [PHP](https://github.com/uJhin/upbit-client/tree/main/swg_generated/php/SwaggerClient-php/docs)

# Examples
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
