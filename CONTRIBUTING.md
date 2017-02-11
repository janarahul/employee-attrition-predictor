# Contributing
This document is a guide to contributing to this repo. Please ensure that you follow the guidelines below.

## Python Code
* Your Python code must follow the [PEP8](https://www.python.org/dev/peps/pep-0008/) guidelines. Your code will be verified for conformance with the [PEP8 tool](https://pypi.python.org/pypi/pep8). You can use the following commands to test it yourself.
```
pip install pep8
pep8 --first source_file.py
```
* Please use docstrings before every function and module for ease of understanding the code. Refer `ClassifierWrapper.py` for examples of docstrings. 
* Except loop counters, try naming variables descriptively, yet not too long. If this is not possible, write a comment beside the declaration explaining what the variable is for.