# VehicleAppWebAPI

## 💻 About The Project
This projects is web API project built with .NET Core. (.NET 6)  
Project developed with Code-First approach and N-Tier Architect.

- Language : C#
- Database : MS SQL Server
- ORM Tool : Entity Framework Core

The following libraries, patterns and principles were also used in the project;
- SOLID Principles
- Dependency Injection
- Generic Repository
- AutoMapper
- ASP.NET Web API
- IOC / DI Container

## 📝 Overview
The user can have access to a repository of cars, boats, and buses with different colors (red, blue, black, white). 
The car is a vehicle (base class). A vehicle can have a color and buses and boats can be a vehicle. 
The car have wheels and headlights. 

#### Accessible API's:
- [GET] User can select cars by color.
- [GET] User can select buses by color.
- [GET] User can select boats by color.
- [PUT] User can turn on/off headlights of the car by car’s ID.
- [DELETE] User can delete the car. 

![image](https://user-images.githubusercontent.com/107391205/202271799-2ba12d17-f9b4-4fb8-9d59-daa105920d2f.png)

## ⚙️ Getting Started
To get a local copy up and running follow these simple steps.

#### Prerequisites
- .NET 6

#### Installation
1. Clone the repo
```git clone https://github.com/BahadirErdogan/VehicleAppWebAPI.git```
2. Configure appsettings.json in WebAPI.
3. Run Update-Database command with Package Manager Console in WebAPI to create tables and seed datas in sql server.

## ⚖️ Licence
See ```LICENCE``` for more information

## 📧 Contact
E-Mail : **bahadirerdogan@outlook.com.tr**
