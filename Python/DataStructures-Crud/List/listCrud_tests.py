import unittest
from listCrud import ListCrud

if __name__ == '__main__':
    pass

class TestListCrud(unittest.TestCase):
    _listCrud = ListCrud()

    def test_ReadSingleElement(self):
        self._listCrud.create(0)
        value = self._listCrud.read(0)
        self.assertEqual(0, value)

    def test_SaveSingleElement(self):
        self._listCrud.create(0)
        value = self._listCrud.read(0)
        self.assertEqual(0, value)

    def test_UpdateSingleElement(self):
        self._listCrud.create(0)
        self._listCrud.update(0, 1)
        value = self._listCrud.read(0)
        self.assertEqual(1, value)

    def test_DeleteSingleElement(self):
        self._listCrud.create(0)
        self._listCrud.delete(0)
        self.assertEqual(0, len(self._listCrud._myList))