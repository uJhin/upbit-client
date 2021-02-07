
import requests

from distutils.version import LooseVersion
from typing import Union


class HTTPFutureExtractor:

    @staticmethod
    def remaining_request(headers: dict) -> dict:
        """
        Check Request limit times

        Please read the official Upbit Client document.
        Documents: https://ujhin.github.io/upbit-client-docs/
        """

        remaining = headers['Remaining-Req']
        return {
            k: v
            for k, v in [
                param.split('=')
                for param
                in remaining.split('; ')
            ]
        }

    @staticmethod
    def future_extraction(http_future) -> dict:
        resp = http_future.future.result()
        remaining = HTTPFutureExtractor.remaining_request(resp.headers)
        resp.raise_for_status()
        return {
            "remaining_request": remaining,
            "result": resp.json()
        }


class Version:

    @staticmethod
    def get_versions(package_name):
        url = f"https://pypi.org/pypi/{package_name}/json"
        resp = requests.get(url)
        data = resp.json()
        versions = data["releases"].keys()
        return sorted(versions, key=LooseVersion, reverse=True)


class Validator:

    @staticmethod
    def validate_price(price: Union[int, float, str]) -> float:
        """
        Please read the official Upbit Client document.
        Documents: https://ujhin.github.io/upbit-client-docs/

        [Order price units]
        ~10         : 0.01
        ~100        : 0.1
        ~1,000      : 1
        ~10,000     : 5
        ~100,000    : 10
        ~500,000    : 50
        ~1,000,000  : 100
        ~2,000,000  : 500
        +2,000,000  : 1,000
        """

        price = float(price)
        unit = 0.01
        if price <= 10:
            unit = 0.01
        elif price <= 100:
            unit = 0.1
        elif price <= 1_000:
            unit = 1
        elif price <= 10_000:
            unit = 5
        elif price <= 100_000:
            unit = 10
        elif price <= 500_000:
            unit = 50
        elif price <= 1_000_000:
            unit = 100
        elif price <= 2_000_000:
            unit = 500
        elif price > 2_000_000:
            unit = 1000
        else:
            raise ValueError('Invalid Price')
        return price - (price % unit)
