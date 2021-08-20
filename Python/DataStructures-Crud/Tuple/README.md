## Reference:
https://www.datacamp.com/community/tutorials/python-tuples-tutorial?utm_source=adwords_ppc&utm_campaignid=14051819510&utm_adgroupid=&utm_device=c&utm_keyword=&utm_matchtype=&utm_network=x&utm_adpostion=&utm_creative=&utm_targetid=&utm_loc_interest_ms=&utm_loc_physical_ms=9061082&gclid=CjwKCAjw3_KIBhA2EiwAaAAlimUjHZmdwLXVDaf6xILMmyn-yD066vYqLRPIutELRLU6qOZ7N15RzBoCv24QAvD_BwE




## Iteration Notes

### Iteration 1

This passed which was unexpected:
```python
class TupleCrud(unittest.TestCase):
    
    def test_Create(self):
        newTuple = 1,2
        self._tupleCrud.create(newTuple)
```

Getting:

```python
an 0 tests in 0.000s

OK
```