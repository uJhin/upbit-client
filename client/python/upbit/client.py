
from bravado.requests_client import RequestsClient as rc
from bravado.client import SwaggerClient as sc
from bravado.http_future import HttpFuture as hf

from upbit.authentication import APIKeyAuthenticator


HOST = "https://api.upbit.com"
SPEC_URI = "https://raw.githubusercontent.com/uJhin/upbit-client/main/mapper/swg_mapper.json"


def Upbit(access_key: str = None, secret_key: str = None, **kwargs) -> sc:
    """
    Upbit Client
    Please read the official Upbit Client document.
    Documents: https://ujhin.github.io/upbit-client-docs/

    - Base URL: https://api.upbit.com
    - Base Path: /v1
    - Upbit OPEN API Version: 1.1.6
    - Author: ujhin
    - Email: ujhin942@gmail.com
    - GitHub: https://github.com/uJhin
    - Official OPEN API Documents: https://docs.upbit.com
    - Official Support Email: open-api@upbit.com
    """

    arg_config = kwargs.get('config')
    arg_spec_uri = kwargs.get('spec_uri')
    config = {
        'also_return_response': False,
        'validate_responses': False,
        'use_models': False,
        'host': HOST
    } if not arg_config else arg_config
    spec_uri = SPEC_URI if not arg_spec_uri else arg_spec_uri

    if access_key and secret_key:

        request_client = rc()
        request_client.authenticator = APIKeyAuthenticator(
            config['host'], access_key, secret_key)

        client = sc.from_url(
            spec_url=spec_uri, http_client=request_client, config=config)

    else:

        client = sc.from_url(spec_url=spec_uri, config=config)

    client.__class__.__name__ = 'UpbitClient'
    return client


def remaining_request(result: hf) -> dict:
    """
    Check Request limit times
    Please read the official Upbit Client document.
    Documents: https://ujhin.github.io/upbit-client-docs/
    """

    future = result.future
    headers = future.result().headers
    req = headers['Remaining-Req']
    return {
        k: v
        for k, v in
        [p.split('=') for p in req.split('; ')]
    }
