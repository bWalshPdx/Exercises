import unittest
from TupleCrud import TupleCrud


class TupleCrud(unittest.TestCase):
    _tupleCrud = TupleCrud()

    def test_Create(self):
        newTuple: tuple = 1, 2
        self._tupleCrud.create(newTuple)

    def test_Read(self):
        newTuple: tuple = 1, 3
        self._tupleCrud.create(newTuple)
        returnedTuple: tuple = self._tupleCrud.read()
        self.assertEqual(newTuple, returnedTuple)

    def test_Update(self):
        newTuple = 1, 1
        updatedTuple = 1, 2
        self._tupleCrud.create(newTuple)
        self._tupleCrud.update(updatedTuple)
        returnedTuple = self._tupleCrud.read()
        expectedTuple = 1, 2
        self.assertEqual(expectedTuple, returnedTuple)

    def test_Delete(self):
        newTuple = 1, 1
        self._tupleCrud.create(newTuple)
        self._tupleCrud.delete()
        returnedTuple = self._tupleCrud.read()
        self.assertEqual(None, returnedTuple)
