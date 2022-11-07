# _Animal_Shelter_API_

#### By _Spencer Dennis_

#### _An API that shows the available animals at a local animal shelter._

## Technologies Used

* _C#_
* _.Net_
* _Enitity_
* _MySQL_
* _Identity_
* _JWT_

## Description

_An API where you can access the dogs and cats in an animal shelter. The animals have species, id, name, and age. When you make a request to the Animal Shelter API, you will specify an HTTP method and a path. Additionally, you might also specify request headers and path, query, or body parameters. The API will return the response status code, response headers, and potentially a response body.

## Documentation/EndPoints

* _(Further Exploration WIP) Authentication Token Using JWT: Before making your first request, you must get a token for authentication. In Postman or another API caller, type in: localhost:5001/api/Users/authenticate as Post request with the following code in the body: {"Name": "[YOUR USERNAME HERE]", "Password": "[YOUR PASSWORD]"} This will return a token to use to make your requests._
* _Making your requests: To make a request, first find the HTTP method and the path for the operation that you want to use. 

The GET request: localhost:5001/api/animals if you would like to specify you can search by species, name, or Age. You can also get animals by id the request is localhost:5001/api/animals/[id]

The POST request: localhost:5001/api/animals if you would like to add a new animal. The JSON format is this:
{
  "animalName": "{ANIMAL NAME}",
  "animalSpecies"; "{ANIMAL SPECIES}",
  "animalAge": {ANIMAL AGE}
}

The PUT request: 
Edit an animal: localhost:5001/api/animals/{id}

The DELETE request: 
Delete an animal: localhost:5001/api/animals/{id}_

_In the API reader you are using using postman as an example, you can also set parameters to search the specific animal values. You can set the key to animalAge, animalName, or animalSpecies. Once you have done this you can set the value for animalSpecies to either "Cat" or "Dog", for animalName you can search by the "Animals Name", and for animalAge you can input the animals age as an int._

## Setup/Installation Requirements

* _Clone the repository using $git clone._
* _Open the project using $code ._
* _Build the project using $dotnet build._
* _Create a file called appsettings.json in the directory of your project's production folder, AnimalShelter_
* _Add this line of code to appsettings.json file:_
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
* _Put your password for My SQL Workbench in the section that reads [YOUR-PASWORD-HERE]_
* _Update the database with $dotnet ef database update_
* _Run the program with $dotnet run._
* _Get an authentication token, explained above in documentation._
* _Run requests to the API in Postman or another API caller._


## Known Bugs

* _JWT authorization not working properly_

## License

_MIT License_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
 
Copyright (c) _11/07/2022_ _Spencer Dennis_