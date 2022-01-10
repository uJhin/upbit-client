.. image:: https://raw.githubusercontent.com/uJhin/upbit-client/main/logo/logo.png
    :align: center

- `Base Repository <https://github.com/uJhin/upbit-client/>`_
- `Python Upbit Client Repository <https://github.com/uJhin/python-upbit-client>`_

Upbit OPEN API Client
######################
- @Author: `uJhin <https://github.com/uJhin>`_
- @GitHub: https://github.com/uJhin/upbit-client/
- @Official Documents: https://ujhin.github.io/upbit-client-docs/

Install
*******
- pip command

.. code:: console

    pip install upbit-client

- git command

.. code:: console

    git clone https://github.com/uJhin/python-upbit-client.git


Quick Start
***************

REST Client
===========

- Check Your API Keys

.. code:: python

    # /v1/api_keys

    from upbit.client import Upbit

    access_key = "Your Access Key"
    secret_key = "Your Secret Key"

    client = Upbit(access_key, secret_key)
    api_keys = client.APIKey.APIKey_info()
    print(api_keys['result'])


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
    )
    print(order['result'])


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
    )
    print(order['result'])

WebSocket Client
================

- Get Real-Time Ticker

.. code:: python

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

Donation
*********
.. image:: https://img.shields.io/badge/BTC-3NVw2seiTQddGQwc1apqudKxuTqebpyL3s-blue?style=flat-square&logo=bitcoin
  :alt: uJhin's BTC
.. image:: https://img.shields.io/badge/ETH-0x60dd373f59862d9df776596889b997e24bee42eb-blue?style=flat-square&logo=ethereum
  :alt: uJhin's ETH
