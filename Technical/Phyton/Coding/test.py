import pandas as pd
import os

# Automatically change to the script's directory
script_directory = os.path.dirname(os.path.abspath(__file__))
os.chdir(script_directory)

# Read the local CSV file
csv_link = "C:/Users/crameya02/Downloads/Interview/Technical/Phyton/Coding/test.csv"  # Ensure the file is in the same directory as your script
dataframe = pd.read_csv(csv_link)
print(dataframe.head())
print(os.getcwd())  # Prints the current working directory
