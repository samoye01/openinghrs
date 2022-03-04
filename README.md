# Accelerex
# Part 2:
Tell us what do you think about the data format. Is the current JSON structure the best 
way to store that kind of data or can you come up with a better version?

# Answer
JSON is a common format for storing and exchanging data on the web, and it all relies on what we want to achieve. 
It's also becoming more popular as a database migration format from modern apps. 
JSON is ideal for storing data that will be consumed by the entity that created it. 
User-generated data, such as information sent between an API and an app, is an excellent example. 
JSON data must be stored as text, however this means it may be used as a data format for any programming language, ensuring excellent compatibility. 
It also implies that data in JSON files may be readily transferred across servers.

# How to run this project
STEP 1. Clone this repository

STEP 2. Open the project solution in visual studio 2022

STEP 3. Run dotnet restore in the console to restores the packages

STEP 4. Run the project and a swagger Documentation will come up in the browser

STEP 5. Open Postman and make an Http POST request on {$endpointURL}​/api​/OpeningHours
Add the following JSON in the request body

{
    "monday": [],
    "tuesday": [
        {
            "type": "open",
            "value": 36000
        },
        {
            "type": "close",
            "value": 64800
        }
    ],
    "wednesday": [],
    "thursday": [
        {
            "type": "open",
            "value": 36000
        },
        {
            "type": "close",
            "value": 64800
        }
    ],
    "friday": [
        {
            "type": "open",
            "value": 64800 
        }
    ],
    "saturday": [
        {
            "type": "close",
            "value": 3600
        },
        {
            "type": "open",
            "value": 32400
        }
    ],
    "sunday": [
        {
            "type": "close",
            "value": 3600
        },
        {
            "type": "open",
            "value": 43200
        },
        {
            "type": "close",
            "value": 75600
        }
    ]
}
and click on SEND.
Woolah!!! 
