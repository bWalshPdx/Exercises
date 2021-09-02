import unittest

from TupleCrud import TupleCrud

if __name__ == '__main__':
    pass

class TestTupleCrud(unittest.TestCase):
    _tupleCrud = TupleCrud()

    def test_Create(self):
        test_tuple = ("one", "two")
        self._tupleCrud.create(test_tuple)

    def test_Read(self):
        test_tuple = ("one", "two")
        self._tupleCrud.create(test_tuple)
        returned_tuple = self._tupleCrud.read()
        self.assertEqual(test_tuple, returned_tuple)

    def test_Update_IfNoneThrowError(self):
        test_tuple = None
        self.assertRaises(Exception, self._tupleCrud.update, test_tuple)

    def test_Update(self):
        test_tuple = ("one", "two")
        self._tupleCrud.create(test_tuple)
        update_tuple = ("three", "four")
        self._tupleCrud.update(update_tuple)
        returned_tuple =  self._tupleCrud.read()
        self.assertTupleEqual(returned_tuple, update_tuple)


