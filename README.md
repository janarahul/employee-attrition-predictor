# Employee Attrition Predictor
This project aims to predict who will leave a company using historical data. Sample data is taken from [Kaggle](https://www.kaggle.com/ludobenistant/hr-analytics).

# Source Files
The source code is organized as below.
## Windows UI
The UI is coded in VB.NET, and uses the [MetroFramework](https://thielj.github.io/MetroFramework) library. The UI has a [Console control](https://www.codeproject.com/Articles/335909/Embedding-a-Console-in-a-C-Application), which runs the Python programs freezed using [PyInstaller](http://www.pyinstaller.org/). The Python code and the UI communicate using files, stored in the user's Temp folder.

## ClassifierWrapper.py
A wrapper for scikit-learn classifiers. The class takes a classifier instance, training and test data and fits the model according to the classifier, and has a method to return all the required values.

## ConversionAndSplitting.py
This file takes the data from the UI generated files, formats them appropriately and passes them to a K-Nearest Neighbors classifier through the ClassifierWrapper. After training the model, it predicts the output of the query, taken from the CSV chosen by the user.

## Building Python Files
PyInstaller was used to freeze the Python code to executables. To use PyInstaller, execute the following commands in the same directory:
```
pip install PyInstaller
pyinstaller ConversionAndSplitting.py --hidden-import sklearn.neighbors.typedefs
```