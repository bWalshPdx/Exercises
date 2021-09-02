import unittest

if __name__ == '__main__':
    pass

class TupleCrud(object):
    _tuple = None

    def create(self, new_tuple: tuple) -> None:
        self._tuple = new_tuple

    def read(self) -> tuple:
        return self._tuple

    def update(self, test_tuple):
        if(test_tuple == None):
            raise Exception("No Tuple to Update")

        self._tuple = test_tuple