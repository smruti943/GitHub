# We try to create regression model to fins the "stringency_index" from COVID data set.
# Here we will try to find the 'stringency_index' of Poland.
# First we extract covid data for Poland from the main data sheet.
# Data sheet was updated to handle null values and other data types.

# After that we create an AML machine learning resource in Azure named 'pws'.
# From that resource we access 'Azure machine learning studio'.
# In side studio Compute instance  and cluster need to be created.

# Now crated csv data set was imported to machine learning studio.
# Regression models can be created in designer tab.
# In this project we created  two regression models
# 1. Linear Regression
# 2. Boosted Decision Tree Regression
# 3. Fast Forest Quantile Regression
