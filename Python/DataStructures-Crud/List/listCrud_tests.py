import unittest
from listCrud import ListCrud

if __name__ == '__main__':
    pass

class TestListCrud(unittest.TestCase):
    _listCrud = ListCrud()

    def test_ReturnsSingleElement(self):
        value = self._listCrud.Read()
        self.assertEqual(0, value)

    def test_SaveSingleElement(self):
        self._listCrud.Create(0)
        value = self._listCrud.Read()
        self.assertEqual(0, value)

    def test_UpdateSingleElement(self):
        self._listCrud.Create(0)
        value = self._listCrud.Update(1)
        self._listCrud.Update(0, 1)
        value = self._listCrud.Read(0)
        self.assertEqual(1, value)

