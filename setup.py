import sys
import cx_Freeze
from cx_Freeze import setup, Executable

files = [cx_Freeze.Executable("ClassifierWrapper.py"),
                cx_Freeze.Executable("ConversionAndSplitting.py")]
base = None
setup(name="calculus",
      version="1.0",
      description="",
      executables=files)
