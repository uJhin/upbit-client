
import requests

from distutils.version import LooseVersion


def get_versions(package_name):
    url = f"https://pypi.org/pypi/{package_name}/json"
    resp = requests.get(url)
    data = resp.json()
    versions = data["releases"].keys()
    return sorted(versions, key=LooseVersion, reverse=True)