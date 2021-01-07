<div align='center'>
  <img src="logo/UPbit_Logo.png" />
</div>

# Upbit Client
Upbit(업비트) Cryptocurrency Trading Market API Client
- Base: Upbit Official Open API

# Install
```bash
pip install upbit-client
```

or

```bash
git clone https://github.com/uJhin/upbit-client.git
```

# Using Package
```python
from upbit.client import Upbit

access_key = "Your Access Key"
secret_key = "Your Secret Key"

client = Upbit(access_key, secret_key)
print(client.APIKey.APIKey_info().result())
```
