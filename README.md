#  _Best Restaurants_

#### _A Collection of restaurants and their associated Cuisines / ratings_
##### __Created:__ 7/29/2020
##### __Last Updated:__ 7/30/2020 
##### By _**Tyson Lackey, Chris Yoon**_  


## Description

_{detailed desc}_

## Behaviors

| Spec| Example input | Example Output
| ----------- | ----------- | ----------- |
| The program takes a user input of restaurant name, location, rating, and cuisine type. | input | output |
| Behavior | input | output |
| Behavior | input | output |
| Behavior | input | output |
| Behavior | input | output |
| Behavior | input | output |
| Behavior | input | output |

## Setup/Installation Requirements

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Configue MySQL Workbench Database:
1. Launch MySQL Workbench
2. Select "Create a new schema in the selected server"
![CreateSchema](assets/images/readme/CreateSchema.PNG)


 ![Words to describe](assets/images/readme/copy-to.PNG)  |   

```
DROP DATABASE IF EXISTS: Best_Restaurant;
CREATE DATABASE Best_Restraunt;
USE Best_Restraunt;
CREATE TABLE `restaurants`(
    RestaurantId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    Rating INT NOT NULL,
    Location VARCHAR(255) NOT NULL,
    Phone Number VARCHAR(255) NOT NULL,
    CuisineID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
);
CREATE TABLE `Cuisine`(
    CuisineId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL
    Region VARCHAR(255) NOT NULL
);
```
##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open by downloading:
1. Internet Browser
2. Code editor like VScode to view the codebase

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open by downloading:

1. Download this repository onto your computer
2. Double click index.html to open it in your web browser

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone {github repo URL}"
2. Navigate into the "{project name}" directory in Visual Studio Code or preferred text editor:
3. Open the project
    "code ."
4. Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
5. Enter the command "dotnet build"in the terminal and press "Enter".
6. Enter the command "dotnet watch run" in the terminal and press "Enter".

## Known Bugs

* n/a

## Support and contact details

* Discord: TysonL#4409
* Email: lackeyt90@gmail.com


## Technologies Used

* Visual Studio Code
* HTML
* CSS
* Bootstrap
* C#
* MVC
* MySQL Workbench
* Entity Framework
* .NET Core

## Resources:

* 

### License

Copyright (c) 2020 **_Tyson Lackey, Chris Yoon_**

This software is licensed under the MIT license.