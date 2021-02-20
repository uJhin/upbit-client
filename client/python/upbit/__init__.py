
import logging

from upbit.utils import Version


__all__ = ['client', 'websocket']
__module_name__ = 'upbit-client'

__version__ = '1.1.7.0'
__released_version__ = Version.get_versions(__module_name__)
__latest_version__ = __released_version__[0]


if __latest_version__ != __version__:
    logging.basicConfig(format="[%(levelname)s] %(message)s")
    logging.warning(
        f"{__module_name__} is currently a newer version: "
        f"{__latest_version__}\n"
        f"Please update to the latest version using the pip command: "
        f"`pip install --upgrade {__module_name__}`"
    )
