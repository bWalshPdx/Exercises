class ListCrud:
    _list = []

    def create(self, value) -> None:
        self._list.append(value)
        return

    def read(self, index) -> object:
        return self._list[index]

    def update(self, index, value) -> None:
        self._list[index] = value

    def delete(self, index) -> None:
        del self._list[index]
