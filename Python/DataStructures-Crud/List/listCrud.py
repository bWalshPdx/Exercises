class ListCrud:
    _myList = []

    def main(self):
        return

    def read(self, index):
        return self._myList[index]

    def create(self, value):
        self._myList.append(value)

    def update(self, index, value):
        self._myList[index] = value

    def delete(self, index):
        del self._myList[index]
