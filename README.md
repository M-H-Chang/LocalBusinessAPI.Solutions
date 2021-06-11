# LocalBusinessAPI.Solution

## Tech Used
1. C#
2. .NET
3. ASP .NET Core
4. Entity Framework
5. MySQL
6. Razor Templates
7. HTML5/CSS3
8. Identity Framework for Auth(entication/orization)

## Requirements
- C#/.NET
- MySql
- Entity Framework

## Setup Instructions
1. Clone repo in to destinated directory
2. Change directory to LocalBusinessAPI.Solution/LocalBusiness
3. Install Dependencies with `dotnet restore`
4. Create file name appsettings.json and enter following: `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=businesses;uid=[user mysql username];pwd=[user mysql password];" } }`
5. To create the database needed using the migrations tool `dotnet ef database update`
6. To watch for live changes `dotnet watch run` in http://localhost:5000/

## API Documentation
#### Launching API
1. Navigate to the root LocalBusiness file
2. Using the command `dotnet run` in your terminal it will launch http://localhost:5000/ for you
3. Access postman to make requests using the API

#### Using Swagger
- To use swagger nagivate to the http://localhost:5000/swagger page.
- When running the API you can use swagger to document your api calls.
- Swagger lets you see all the different requests accessed in the controller.
- To test one of the requests simply click on the request(GET/POST/PUT/DELETE) then click try it out and then execute.
  - You will see the response body and the request URL for documentation.

#### Businesses

#### Business HTTP requests
1. GET /api/business
2. POST /api/business
3. GET /api/business/{id}
4. PUT /api/bean/{id}
5. DELETE /api/business/{id}

#### Path Parameters
- Parameter: name, Type: string, Required: true

### Known Bugs
- None identified

### License
- GPL 3.0 or later

#### Contact Information
- Min Chang: minchangmhc at gmail dot com