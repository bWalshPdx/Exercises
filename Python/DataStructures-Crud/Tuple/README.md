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

I wrote this half in pycharm and half in vs code. I think once I get pycharm working well I like that better. I just don't know why it breaks sometimes.

#### Lessons

I need to get pycharm tdd locked down.
    - The navigation is better. (And I don't need to learn a new thing)

I learned how to use types as parameters and return types.

I think I needed to add this to my tests in order to make it work:
```python

if __name__ == '__main__':
    pass
```

We also needed to hit play in a certain spot of the file. Still trying to master that part.

<NA> Write tuplecrud iteration 3