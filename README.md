# Employee Attrition Predictor
This project aims to predict who will leave a company using historical data. Sample data is taken from [Kaggle](https://www.kaggle.com/ludobenistant/hr-analytics).

# Source Files
The source code is organized as below.
## Windows UI (to be uploaded)
The UI is coded in VB.NET, and uses the [MetroFramework](https://thielj.github.io/MetroFramework) library. The UI has a [Console control](https://www.codeproject.com/Articles/335909/Embedding-a-Console-in-a-C-Application), which calls a Python interpreter to run the Python source files. The Python code and the UI communicate using files.

## ClassifierWrapper.py
A wrapper for scikit-learn classifiers. The class takes a classifier instance, training and test data and fits the model according to the classifier, and has a method to return all the required values.
