

class TupleCrud:
    _tuple = ()
    def create(self, newTuple: tuple) -> None:
        self._tuple = newTuple

    def read(self) -> tuple:
        return self._tuple

    def update(self, updatedTuple: tuple) -> None:
        self._tuple = updatedTuple
    
    def delete(self) -> None:
        self._tuple = None
        