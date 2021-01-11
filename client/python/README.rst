.. image:: https://raw.githubusercontent.com/uJhin/upbit-client/main/logo/logo.png
    :align: center

- `Base Repository <https://github.com/uJhin/upbit-client/>`_
- `Python Upbit Client Repository <https://github.com/uJhin/python-upbit-client>`_

Upbit OPEN API Client
**********************
- @Author: `uJhin <https://github.com/uJhin>`_
- @GitHub: https://github.com/uJhin/upbit-client/
- @Official Documents: https://ujhin.github.io/upbit-client-docs/

Install
========
- pip command

.. code:: console

    pip install upbit-client

- git command

.. code:: console

    git clone https://github.com/uJhin/python-upbit-client.git


Simple Examples
===============

- Check Your API Keys

.. code:: python

    # /v1/api_keys

    from upbit.client import Upbit

    access_key = "Your Access Key"
    secret_key = "Your Secret Key"

    client = Upbit(access_key, secret_key)
    print(client.APIKey.APIKey_info().result())


- Buy Currency

.. code:: python

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


- Sell Currency

.. code:: python

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
    ).result()
    print(order)

Donation
*********
- BTC: 3NVw2seiTQddGQwc1apqudKxuTqebpyL3s
- ETH: 0x60dd373f59862d9df776596889b997e24bee42eb
