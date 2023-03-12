# _Hair Salon_

#### By _Jacob Maier_

#### _A web application using MySql for a database of the customers Stylists and Clients_

## Technologies Used

* _C#_
* _.NET_
* _Entity Framework Core_
* _MYSQL/MySql Workbench_
* _HTML_ 
* _CSS_ 

## Description

_This web application is using the Entity Framework to store user inputted data tying that information to the corosponding information. For example each client has an ID that is tied to the Stylists specific ID to track which clients belong to which stylists. The MySql database track both tables IDs and specific names tied to them. Future goals with this project are to add more options for the company owner having separate locations and the ability to filter employees and customers through each store location as well as customers being able to switch between stylists._ 

## Requirements

* _Mysql/MySqlWorkbench_

* _.NET 6_

## Setup/Installation 

* _Clone this repo._

* _Open the terminal and navigate to this project's production directory `ProjectName`._

* _Within the production create a new file named `appsettings.json and place the following code inside replacing the text in the brackets with your MySql user name and password respectively._

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
} 
```

* _From your terminal enter `dotnet run` to build project and run the page in your browser from the address: `localhost:5001`_

## Importing The Database



## Known Bugs

* _Show all Clients links not working as expected right now._


## License

_MIT_

Copyright (c) _2023_ _Jacob Maier_