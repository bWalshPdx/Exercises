# Create a LeetCode Solution

## Introduction

### Pass in parameters
https://www.tutorialspoint.com/python/python_command_line_arguments.htm

```python
#!/usr/bin/python

import sys

print 'Number of arguments:', len(sys.argv), 'arguments.'
print 'Argument List:', str(sys.argv)
```

### Create Folder

https://www.pythontutorial.net/python-basics/python-directory/

```python
import os

dir = os.path.join("C:\\","temp","python")
if not os.path.exists(dir):
    os.mkdir(dir)
```

### Create README
https://www.codegrepper.com/code-examples/python/python+os+create+file

```python
file = open(“testfile.txt”,”w”) 
 
file.write(“Hello World”) 
file.write(“This is our new text file”) 
file.write(“and this is another line.”) 
file.write(“Why? Because we can.”) 
 
file.close() 
```


### - Add Reference to README for the link
### - Create a test file
- test file creates has the solution
- test file has the initial test
- enters the new directory

### opens pycharm with 'sjp .'

https://stackoverflow.com/questions/2918362/writing-string-to-a-file-on-a-new-line-every-time
```python
os.chdir(path)
```