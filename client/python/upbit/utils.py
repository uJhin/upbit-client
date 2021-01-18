
from typing import Union


def validate_price(price: Union[int, float, str]) -> float:
    """
    Documents: https://docs.upbit.com/docs/market-info-trade-price-detail

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
        raise ValueError('Invaild Price')
    return price - (price % unit)
