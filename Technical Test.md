##Pavers technical test

#Scope
Your task is to produce a simple modernized application to replace the existing legacy Label printing software. The data will be obtained via a API and would allow the user to print the returned data. Printing multiple items is a requirement for the user.
There is no specific requirement to what language this is written in. External libraries and frameworks are acceptable. The environment it will be installed on is Windows 7/10 with a default browser of Google Chrome. The local user will have administrative privileges.
The business would prefer the application to be easily accessible via a web page but would consider another language if a strong business case was put forward at the as to why the developer chose this.

#Context
The new application will retrieve data from the API, either by POS code or product name. The user will enter this into an input field and press a search button to execute the request.
If a POS code is entered, a single JSON object should be returned. If a product name is entered, an array of JSON objects will be returned. If multiple items are returned, this should be presented to the user to select the correct item.
A print list will be built up allowing the user to add multiple items to it, before then choosing to print it by clicking a print button.
Once the print button is clicked, it should loop through the print list and validate the data. This data should then be stored in a txt file containing a JSON object. In real life these would be sent to the printer and not stored. For the purpose of this exercise please code a solution to save the file to the local filesystem and then copy them to a folder called ‘output’ in your final solution.
Please email your final solution as a zip file to dave.grix@pavers.co.uk and james.busby@pavers.co.uk

#Endpoints
POS Code - https://testapi.paversdev.co.uk/getDataByPosCode/00001234
Product Name - https://testapi.paversdev.co.uk/getDataByName/P216

#Definitions
POS Code - An 8-digit number representing a barcode e.g. 00001234
Product Name – A string containing the name of the product e.g. P216

#Existing Solution
To view the existing solution, download the repository from https://github.com/Pavers/LabelIT and follow the instructions in the README.md
