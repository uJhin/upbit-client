import jwt
import hashlib
import uuid
from urllib.parse import urlencode

from bravado.requests_client import Authenticator


class APIKeyAuthenticator(Authenticator):
    def __init__(self, host, access_key, secret_key):
        super(APIKeyAuthenticator, self).__init__(host)
        self.host = host
        self.access_key = access_key
        self.secret_key = secret_key

    def matches(self, url):
        return 'swg_mapper.json' not in url

    def apply(self, request):
        request.headers['User-Agent'] = "ujhin's Upbit SDKs"
        request.headers['Accept-Encoding'] = 'gzip, deflate'
        request.headers['Accept'] = '*/*'
        request.headers['Connection'] = 'keep-alive'
        request.headers['Authorization'] = self.generate_payload(request)
        return request

    def generate_payload(self, request):
        params = request.params
        data = request.data

        payload = {
            'access_key': self.access_key,
            'nonce': str(uuid.uuid4())
        }
        if isinstance(data, dict):
            params.update(data)
        if params:
            query = urlencode(params).encode()
            h = hashlib.sha512()
            h.update(query)
            query_hash = h.hexdigest()
            payload['query_hash'] = query_hash
            payload['query_hash_alg'] = 'SHA512'

        jwt_token = jwt.encode(payload, self.secret_key)
        authorize_token = f"Bearer {jwt_token}"
        return authorize_token
