HandsOn 2 – Web API using Swagger & Postman
Objective:
To integrate Swagger into a .NET Core Web API project, test the API using Postman, and demonstrate route customization.

Steps Performed:
Installed Swashbuckle.AspNetCore via NuGet for Swagger support.

Configured Swagger in Program.cs using UseSwagger() and UseSwaggerUI().

Ran the application and accessed https://localhost:7237/swagger/index.html.

Clicked GET → Try it out → Execute and verified the JSON response.

Opened Postman, sent a GET request to the API endpoint, and checked the response and status.

Modified the [Route] attribute in the controller to "emp" and tested the new route in Postman.
