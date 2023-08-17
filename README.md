<div align='center'>
  <img src="logo/logo.png" width="250" height="250">
  <br/><br/>
  <div>
    <a href="https://github.com/uJhin/upbit-client/releases">
      <img src="https://img.shields.io/github/v/release/uJhin/upbit-client"/>
    </a>
    <a href="https://pypi.org/project/upbit-client/">
      <img src="https://img.shields.io/pypi/v/upbit-client"/>
    </a>
  </div>
  <div>
    <a href="https://github.com/uJhin/upbit-client/issues">
      <img src="https://img.shields.io/github/issues/uJhin/upbit-client"/>
    </a>
    <a href="https://github.com/uJhin/upbit-client/blob/main/LICENSE">
      <img src="https://img.shields.io/github/license/uJhin/upbit-client"/>
    </a>
  </div>
  <br/>
  <a href="https://ujhin.github.io/upbit-client-docs/">
    <b>Upbit Client Documents</b>
  </a>
  <br/><br/>
  <div align="center">
    <h2>Support</h2>
    <a href="https://upbit.com/">
      <img src="logo/upbit_logo.png" width="250" height="100"/>
    </a>
    <a href="https://swagger.io/">
      <img src="logo/swagger_logo.png" width="250" height="100">
    </a>
    <br/><br/>
    <div>
      <!-- <img src="https://img.shields.io/github/stars/uJhin/upbit-client?style=social"/> -->
    </div>
    <br/>
  </div>  
</div>

<div align="center">
  <h1>Upbit Client</h1>
  <p>Upbit(업비트) Cryptocurrency Exchange API Client</p>
</div>

### Description
Upbit(업비트) Cryptocurrency Exchange Open API Client of Multi-Programming Language Support


### Swagger Generated Support Languages
- [Python](https://github.com/uJhin/upbit-client/tree/main/swg_generated/python/)
- [C++](https://github.com/uJhin/upbit-client/tree/main/swg_generated/cpp)
- [CSharp](https://github.com/uJhin/upbit-client/tree/main/swg_generated/csharp/)
- [Objective-C](https://github.com/uJhin/upbit-client/tree/main/swg_generated/objective-c)
- [Java](https://github.com/uJhin/upbit-client/tree/main/swg_generated/java/)
- [JavaScript](https://github.com/uJhin/upbit-client/tree/main/swg_generated/)
- [PHP](https://github.com/uJhin/upbit-client/tree/main/swg_generated/php/SwaggerClient-php/)
- [Android](https://github.com/uJhin/upbit-client/tree/main/swg_generated/android)
- [Kotlin](https://github.com/uJhin/upbit-client/tree/main/swg_generated/)
- [Go](https://github.com/uJhin/upbit-client/tree/main/swg_generated/go/)
- [Lua](https://github.com/uJhin/upbit-client/tree/main/swg_generated/lua)
- [R](https://github.com/uJhin/upbit-client/tree/main/swg_generated/r)
- [Rust](https://github.com/uJhin/upbit-client/tree/main/swg_generated/rust)
- [Scala](https://github.com/uJhin/upbit-client/tree/main/swg_generated/scala)

### Install
- `pip` command
```console
pip install upbit-client
```
- `git` command
```console
git clone https://github.com/uJhin/upbit-client.git
```


### Quick Start
#### Credentials
```shell
mkdir -p ~/.upbit
```
```
# vi ~/.upbit/credentials

[default]
access_key = a
secret_key = b

[a]
access_key = c
secret_key = d
```
```python
client = Upbit() # default
client = Upbit(profile="a")
```

#### REST Client
- Check Your API Keys
```python
# /v1/api_keys

from upbit.client import Upbit

access_key = "Your Access Key"
secret_key = "Your Secret Key"

client = Upbit(access_key, secret_key)
api_keys = client.APIKey.APIKey_info()
print(api_keys['result'])
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
)
print(order['result'])
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
    side='ask',
    volume='0.1',
    price='3000000',
    ord_type='limit'
)
print(order['result'])
```

#### WebSocket Client
- Get Real-Time Ticker
```python
# Using WebSocket

import json
import asyncio

from upbit.websocket import UpbitWebSocket


# Definition async function
async def ticker(sock, payload):
    async with sock as conn:
        await conn.send(payload)
        while True:
            recv = await conn.recv()
            data = recv.decode('utf8')
            result = json.loads(data)
            print(result)


sock = UpbitWebSocket()

currencies = ['KRW-BTC', 'KRW-ETH']
type_field = sock.generate_type_field(
    type='ticker',
    codes=currencies,
)
payload = sock.generate_payload(
    type_fields=[type_field]
)

event_loop = asyncio.get_event_loop()
event_loop.run_until_complete( ticker(sock, payload) )
```

### Donation
<div align="left">
  <img alt="uJhin's BTC" src="https://img.shields.io/badge/BTC-3NVw2seiTQddGQwc1apqudKxuTqebpyL3s-blue?style=flat-square&logo=bitcoin">
  <br/>
  <img alt="uJhin's ETH" src="https://img.shields.io/badge/ETH-0x60dd373f59862d9df776596889b997e24bee42eb-blue?style=flat-square&logo=ethereum">
</div>

### Contributor
```shell
deactivate

rm -rf venv

python3 -m venv venv
source venv/bin/activate

pip3 install -r client/python/requirements.txt
```