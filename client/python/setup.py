from setuptools import setup
from setuptools import find_packages

long_description = '''Upbit OPEN API Client\n
@Author: ujhin\n
@GitHub: https://github.com/uJhin/upbit-client\n
@Official Documents: https://ujhin.github.io/upbit-client-docs\n 
'''

setup(
    name='upbit_client',
    version='1.1.6.11',
    packages=find_packages(),
    install_requires=[
        'bravado>=11.0.2',
        'PyJWT>=2.0'
    ],
    extras_require= {
        'fido': ['fido>=4.2.1']
    },
    python_requires='>=3.8',
    keywords=[
        'Upbit',
        'upbit',
        'upbit-client',
        'Upbit-Client',
        'Upbit_client',
        'upbit'
    ],
    url='https://github.com/uJhin/upbit-client',
    license='MIT License',
    author='ujhin',
    author_email='ujhin942@gmail.com',
    description='Upbit OPEN API Client',
    long_description=long_description
)
