# Employee Attrition Predictor
This project aims to predict who will leave a company using historical data. Sample data is taken from [Kaggle](https://www.kaggle.com/ludobenistant/hr-analytics).

# Source Files
The source code is organized as below.
## Windows UI
The UI is coded in VB.NET, and uses the [MetroFramework](https://thielj.github.io/MetroFramework) library. The UI has a [Console control](https://www.codeproject.com/Articles/335909/Embedding-a-Console-in-a-C-Application), which runs the Python programs freezed using [cx_Freeze](https://anthony-tuininga.github.io/cx_Freeze/). The Python code and the UI communicate using files, stored in the user's Temp folder.

## ClassifierWrapper.py
A wrapper for scikit-learn classifiers. The class takes a classifier instance, training and test data and fits the model according to the classifier, and has a method to return all the required values.

## setup.py
This is code to freeze the Python programs to executables.