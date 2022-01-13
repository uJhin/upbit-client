"""
[Upbit Client]

Please read the official Upbit Client document.
Documents: https://ujhin.github.io/upbit-client-docs/

- Upbit OPEN API Version: 1.2.2
- Author: ujhin
- Email: ujhin942@gmail.com
- GitHub: https://github.com/uJhin
- Official OPEN API Documents: https://docs.upbit.com
- Official Support Email: open-api@upbit.com
"""

import logging
import requests

from distutils.version import LooseVersion


def _get_versions(package_name):
    url = f"https://pypi.org/pypi/{package_name}/json"
    resp = requests.get(url)
    data = resp.json()
    versions = data["releases"].keys()
    return sorted(versions, key=LooseVersion, reverse=True)


PACKAGE_NAME     = "upbit-client"

OPEN_API_VERSION = "1.2.2"
CURRENT_VERSION  = OPEN_API_VERSION+".4"

RELEASED_VERSION = _get_versions(PACKAGE_NAME)
LATEST_VERSION   = RELEASED_VERSION[0]


if LATEST_VERSION != CURRENT_VERSION:
    logging.basicConfig(format="[%(levelname)s] %(message)s")
    logging.warning(
        f"{PACKAGE_NAME} is currently a newer version: {LATEST_VERSION}\n"
        f"Please update to the latest version using the pip command:" 
        f"`pip install --upgrade {PACKAGE_NAME}`"
    )
