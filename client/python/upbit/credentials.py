import os
from configparser import ConfigParser

PATH = ".upbit/credentials"


class Credentials:
    """
    Credentials
    """

    @staticmethod
    def home():
        return os.path.expanduser("~")

    @staticmethod
    def get(profile: str = None) -> dict:
        profile = profile or "default"

        config = ConfigParser()
        config.read(f"{Credentials.home()}/{PATH}")

        return config._sections[profile]


if __name__ == '__main__':
    print(Credentials.get())
