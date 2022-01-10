
from setuptools import setup
from setuptools import find_packages

from upbit import pkginfo


with open('README.rst') as readme:
    long_description = readme.read()


setup(
    name     = pkginfo.PACKAGE_NAME,
    version  = pkginfo.CURRENT_VERSION,
    packages = find_packages(),
    install_requires = [
        'bravado>=11.0.2',
        'PyJWT>=2.0',
        'websockets>=10.1'
    ],
    extras_require  = {
        'fido': [
            'fido>=4.2.1'
        ]
    },
    python_requires = '>=3.8',
    classifiers     = [
        'Programming Language :: Python :: 3.8',
        'Programming Language :: Python :: 3.9'
    ],
    keywords        = [
        'Upbit',
        'upbit',
        'upbit-client',
        'Upbit-Client',
        'Upbit_client',
        'Upbit-api-connector',
        'upbit-api-connector',
        'Upbit_api_connector',
        'upbit_api_connector'
    ],
    url                           = 'https://github.com/uJhin/upbit-client',
    download_url                  = 'https://github.com/uJhin/upbit-client/releases',
    license                       = 'MIT License',
    author                        = 'ujhin',
    author_email                  = 'ujhin942@gmail.com',
    description                   = 'Upbit OPEN API Client',
    long_description_content_type = 'text/x-rst',
    long_description              = long_description
)
