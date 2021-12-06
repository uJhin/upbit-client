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

from . import pkginfo


__all__     = ['client', 'websocket']
__version__ = pkginfo.CURRENT_VERSION
