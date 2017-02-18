

import numpy as np 

import pandas as pd 

import seaborn as sns

from sklearn.neighbors import KNeighborsClassifier
 
from sklearn import metrics

from ClassifierWrapper import ClassifierWrapper

from sklearn.ensemble import RandomForestClassifier

from sklearn.cross_validation import train_test_split 

from sklearn.metrics import confusion_matrix

#Below the Data Set is being read (Replace the Path with the your path)


Data=pd.read_csv('PATH OF YOUR CSV')


olist=list(Data.select_dtypes(['object'])) 
# Selecting the Columns of OBJECT type


for col in olist:
 # Converting the OBJECT type to INTEGER type
	Data[col]=Data[col].astype('category').cat.codes

X=Data.drop("left",axis=1) 
# Loading the ATTRIBUTE columns 


Y=Data["left"].astype('category') 
# Loading the TARGET column


from sklearn.cross_validation import train_test_split

X_train,X_test,Y_train,Y_test=train_test_split(X,Y,random_state=3) 
# Splitting the DATA


kn =KNeighborsClassifier(n_neighbors=1) 
# Instanciating KNNEIGHBOURS Class


cw = ClassifierWrapper(kn,X_train,X_test,Y_train,Y_test)
 
# 
Calling the Wrapper Class
