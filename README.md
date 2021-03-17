<p align="center"><img src="https://user-images.githubusercontent.com/34022590/111371494-2cd65500-86a2-11eb-8479-f2241d6b6e51.jpg" width="300px"></p>

<h1 align="center">
    <strong>MVC Web Application</strong>
</h1>
<h3 align="center">
    <p>ASP.NET MVC CRUD Web Application</p>
</h3>

## Contents
- [Screens](#screens)
- [Tools needed](#tools-needed)
- [Database](#database)
- [Creating Project](#creating-project)

## Screens

### List of items:

<p align="center"><img src="list.png" width="300px"></p>

### Create item:

<p align="center"><img src="create.png" width="300px"></p>

### Edit item:

<p align="center"><img src="edit.png" width="300px"></p>

### Delete item:

<p align="center"><img src="delete.png" width="300px"></p>

## Tools needed
* Visual Studio           - https://visualstudio.microsoft.com/
* Microsoft SQL Server    - https://www.microsoft.com/en-us/sql-server/sql-server-downloads

## Database
In Microsof SQL Server Management Studio we'll create the database\
DB Name:  'Mobile'\
Table Name: 'phone'\
Columns:

| Name | Data Type | Allow Nulls |
|-|-|-|
| Model_Name | nvarchar(50) | null |
| Launch | date | null |
| Camera | navchar(50) | null |
| Ram | navchar(50) | null |
| Battery | navchar(50) | null |
| Network | navchar(50) | null |
| weight | navchar(50) | null |
| Memory | navchar(50) | null |

## Creating project
In Visual Studio we'll create new 'ASP.NET Web Application' with MVC

In 'Models' we create connecttion to database by adding 'ADO.NET Entity Data Model'\
We'll copy server name and database name from Server Manager to our connection.

<img src="https://user-images.githubusercontent.com/34022590/111438995-8f186f80-870d-11eb-860e-d659e88bb4c5.jpg">

AlertifyJS  - https://alertifyjs.com/ \
AlertifyJS not only provides a replacement for default browser dialogs, it makes it super easy to create your own! 

We will add 'Alertify' package to our project with NuGet\
and connect alertify and bootstrap to our '_Layout.cshtml'

In 'RouteConfig.cs' we will configure our main page route
```
defaults: new { controller = "phone", action = "Index", id = UrlParameter.Optional }
```

# HAPPY CODING !!! :)
